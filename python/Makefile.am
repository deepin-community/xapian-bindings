## Process this file with automake to produce Makefile.in

include ../generic/generic.mk

## Test programs to be run
TESTS = smoketest.py pythontest.py
AM_TESTS_ENVIRONMENT = \
	PYTHON='$(PYTHON2)' ;\
	export PYTHON ;
LOG_COMPILER = '$(srcdir)'/run-python-test

installcheck-local:
	$(MAKE) check LOG_COMPILER='$(PYTHON2)' AM_TESTS_ENVIRONMENT= \
	    PYTHONDONTWRITEBYTECODE=1

RST_DOCS = \
	docs/examples.rst \
	docs/index.rst \
	docs/introduction.rst \
	docs/xapian.rst

BUILT_SOURCES = xapian_wrap.cc xapian_wrap.h xapian__init__.py

EXTRA_DIST = python.i util.i extra.i extracomments.i except.i \
	doccomments.i \
	doxy2swig.py \
	fixup-swig-py2-wrapper \
	generate-python-exceptions \
	run-python-test \
	testsuite.py \
	test_xapian_star.py \
	$(TESTS) $(BUILT_SOURCES) $(RST_DOCS)

pkgpylibdir = @PYTHON2_LIB@/xapian

# Install as _DATA rather than _SCRIPTS because we don't want to make these
# executable (they don't have a #! line).
pkgpylib_DATA = xapian/__init__.py \
		xapian/__init__.pyc \
		xapian/__init__.pyo

pkgpylib_LTLIBRARIES = _xapian.la

# Remove the .la file - _xapian.la is never linked against (it's a module)
# and Python doesn't use libltdl.  Note that the library gets installed by
# install-data, so that's where we need to hook.
install-data-hook:
	rm -f $(DESTDIR)$(pkgpylibdir)/_xapian.la

# Because we don't install the .la file, "make uninstall" doesn't work and
# we need to remove the file ourselves.
uninstall-local:
	rm -f $(DESTDIR)$(pkgpylibdir)/_xapian$(PYTHON2_SO)

AM_CPPFLAGS = -I$(PYTHON2_INC)
AM_CXXFLAGS = $(SWIG_CXXFLAGS) $(XAPIAN_CXXFLAGS)
_xapian_la_LDFLAGS = -avoid-version -module -shrext "$(PYTHON2_SO)" $(NO_UNDEFINED)
_xapian_la_SOURCES = xapian_wrap.cc
_xapian_la_LIBADD = $(XAPIAN_LIBS) $(PYTHON2_LIBS)

# We want `xapian/__init__.py` so the module is treated as a package.
xapian/__init__.py: xapian__init__.py
	$(MKDIR_P) xapian
	cp `test -f xapian__init__.py || echo '$(srcdir)/'`xapian__init__.py xapian/__init__.py

# We "import _xapian" first so that if we fail to import the glue library
# we don't generate a broken .pyc or .pyo, and we do it with the current
# directory set to where the module is as Python with -c always searches the
# current directory first.
#
# We then "import xapian" as a separate command, as that's more like how things
# are once installed - in particular this will fail if the SWIG shadow wrapper
# doesn't cope with being xapian/__init__.py (currently it needs fixing
# up, which is done by fixup-swig-py2-wrapper).
xapian/__init__.pyc: xapian/__init__.py xapian/_xapian$(PYTHON2_SO)
	$(MACOS_SIP_HACK_ENV) $(PYTHON2) -c 'import os;os.chdir("xapian");import _xapian'
	$(MACOS_SIP_HACK_ENV) $(PYTHON2) -c 'import xapian'

xapian/__init__.pyo: xapian/__init__.py xapian/_xapian$(PYTHON2_SO)
	$(MACOS_SIP_HACK_ENV) $(PYTHON2) -O -c 'import os;os.chdir("xapian");import _xapian'
	$(MACOS_SIP_HACK_ENV) $(PYTHON2) -O -c 'import xapian'

xapian/_xapian$(PYTHON2_SO): _xapian.la
	$(MKDIR_P) xapian
	cp $(_libs)/_xapian$(PYTHON2_SO) xapian

CLEANFILES = \
    xapian/_xapian$(PYTHON2_SO) \
    xapian/__init__.py xapian/__init__.pyc xapian/__init__.pyo \
    $(srcdir)/*.pyc

# Clean the xapian directory which we created, if it's empty, and any
# databases created by test cases.
clean-local:
	-rmdir xapian
	rm -rf db_test_* dbs_replication

if MAINTAINER_MODE
BUILT_SOURCES += except.i doccomments.i
except.i: $(srcdir)/generate-python-exceptions ../../xapian-core/exception_data.pm
	$(PERL) -w -I$(srcdir)/../../xapian-core $(srcdir)/generate-python-exceptions

if MAINTAINER_NO_DOCS
doccomments.i:
	: > doccomments.i
else
doccomments.i: doxy2swig.py ../../xapian-core/exception_data.pm ../doxygen-xml/index.xml
	$(PYTHON) $(srcdir)/doxy2swig.py ../doxygen-xml/index.xml doccomments.i
endif

# We need to explicitly set -outdir because on Windows, SWIG splits paths at
# "\" when extracting the output directory from the value passed to the -o
# option.

stamp = xapian_wrap.stamp
RUN_SWIG = stamp='$(stamp)' $(PERL) '$(top_srcdir)'/swig-depcomp $(SWIG)
SWIG_FLAGS += -DSWIG_PYTHON_LEGACY_BOOL

xapian_wrap.cc xapian_wrap.h xapian.py__init__.py xapian_wrap.d: $(stamp)
	$(make_many_locked)
$(stamp): except.i doccomments.i fixup-swig-py2-wrapper
	$(multitarget_begin)
	$(RUN_SWIG) $(SWIG_WERROR) -I. -I'$(srcdir)' $(SWIG_FLAGS) -c++ \
	    -python -threads -shadow -O \
	    -o xapian_wrap.cc '$(srcdir)/'python.i
	$(PERL) $(srcdir)/fixup-swig-py2-wrapper xapian.py > xapian__init__.py
	rm xapian.py
	$(multitarget_end)

-include xapian_wrap.d

CLEANFILES += xapian_wrap.d $(stamp)
endif
MAINTAINERCLEANFILES = $(BUILT_SOURCES)

exampledatadir = $(docdir)/python/examples
dist_exampledata_DATA = \
	docs/examples/simpleindex.py \
	docs/examples/simpleexpand.py \
	docs/examples/simplematchdecider.py \
	docs/examples/simplesearch.py

sphinxdocs = docs/html/index.html

install-data-local:
	$(mkinstalldirs) '$(DESTDIR)$(docdir)/python'
	cp -R -p `test -r docs/html || echo '$(srcdir)/'`docs/html '$(DESTDIR)$(docdir)/python'

all-local: $(sphinxdocs)

$(sphinxdocs): xapian/__init__.py xapian/_xapian$(PYTHON2_SO) docs/conf.py $(RST_DOCS) $(dist_exampledata_DATA)
## We need to run Sphinx for the right version of Python here, so we can't
## just run sphinx-build as that might be for a different version.
##
## sphinx >= 1.7.0 no longer skips the first argument passed to
## sphinx.main(). Therefore we have to skip it ourselves (by
## taking a slice of sys.argv), and then have a skippable first
## argument for sphinx < 1.7.0. -bhtml duplicates the subsequent
## -b html, and so apparently is safe.
##
## Change was merged here: https://github.com/sphinx-doc/sphinx/pull/3668
	PYTHONPATH=..:$$PYTHONPATH $(MACOS_SIP_HACK_ENV) $(PYTHON2) \
		-c 'import sphinx,sys;sys.exit(sphinx.main(sys.argv[1:]))' \
		-bhtml -b html -d doctrees -c docs $(srcdir)/docs docs/html
