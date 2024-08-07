## Process this file with automake to produce Makefile.in

include ../generic/generic.mk

## Test programs to be run
TESTS = smoketest.rb
LOG_COMPILER = $(MACOS_SIP_HACK_ENV) $(RUBY)
AM_LOG_FLAGS = -I'$(_libs)' -I'$(srcdir)'

installcheck-local:
	$(MAKE) check AM_LOG_FLAGS=

SWIG_GENERATED = xapian_wrap.cc xapian_wrap.h

EXTRA_DIST = ruby.i extra.i docs/index.rst $(TESTS) \
	$(SWIG_GENERATED)

BUILT_SOURCES = $(SWIG_GENERATED)

rubylibdir = $(RUBY_LIB)
dist_rubylib_DATA = xapian.rb

rubylibarchdir = $(RUBY_LIB_ARCH)
rubylibarch_LTLIBRARIES = _xapian.la

# Remove the .la file - _xapian.la is never linked against (it's a module)
# and Ruby doesn't use libltdl.  Note that the library gets installed by
# install-data, so that's where we need to hook.
install-data-hook:
	rm -f $(DESTDIR)$(rubylibarchdir)/_xapian.la

AM_CPPFLAGS = -I$(RUBY_INC) -I$(RUBY_INC_ARCH)
AM_CXXFLAGS = @SWIG_CXXFLAGS@ $(XAPIAN_CXXFLAGS)
_xapian_la_LDFLAGS = -avoid-version -module -shrext ".$(RUBY_DLEXT)" $(NO_UNDEFINED)
_xapian_la_SOURCES = xapian_wrap.cc xapian_wrap.h
_xapian_la_LIBADD = $(XAPIAN_LIBS) $(RUBY_LIBS)

CLEANFILES =
if MAINTAINER_MODE
stamp = xapian_wrap.stamp
RUN_SWIG = stamp='$(stamp)' $(PERL) '$(top_srcdir)'/swig-depcomp $(SWIG)

xapian_wrap.cc xapian_wrap.h: $(stamp)
	$(make_many_locked)
$(stamp):
	$(multitarget_begin)
	$(RUN_SWIG) $(SWIG_WERROR) -I'$(srcdir)' $(SWIG_FLAGS) -c++ \
	    -initname _xapian -ruby \
	    -o xapian_wrap.cc '$(srcdir)/'ruby.i
	$(multitarget_end)

-include xapian_wrap.d

CLEANFILES += $(stamp)
endif
MAINTAINERCLEANFILES = $(BUILT_SOURCES)

# Compatibility wrapper which configure creates when required.
DISTCLEANFILES = rubyio.h

exampledatadir = $(docdir)/ruby/examples
dist_exampledata_DATA = \
	docs/examples/simpleexpand.rb \
	docs/examples/simpleindex.rb \
	docs/examples/simplematchdecider.rb \
	docs/examples/simplesearch.rb

install-data-local:
	$(mkinstalldirs) $(DESTDIR)$(docdatadir)
	## In a VPATH build, install files from srcdir first.  Use
	## $(abs_builddir) because we need to cd there having already
	## changed directory.
	@paths=docs ; \
	  test '$(abs_srcdir)' = '$(abs_builddir)' || paths='$(srcdir)/docs $(abs_builddir)/docs' ; \
	  for docs in $$paths ; do \
	    cd "$$docs" && for dir in `find rdocs -type d -print` ; do \
	      echo " $(mkinstalldirs) '$(DESTDIR)$(docdatadir)/$$dir'"; \
	      $(mkinstalldirs) "$(DESTDIR)$(docdatadir)/$$dir"; \
	    done && for f in `find rdocs -type f -print` ; do \
	      echo " $(INSTALL_DATA) '$$f' '$(DESTDIR)$(docdatadir)/$$f'"; \
	      $(INSTALL_DATA) "$$f" "$(DESTDIR)$(docdatadir)/$$f"; \
	    done ; \
	  done

uninstall-local:
	## Because we don't install the .la file, "make uninstall" doesn't work
	## and we need to remove the file ourselves.
	rm -f $(DESTDIR)$(rubylibarchdir)/_xapian.$(RUBY_DLEXT)
	@paths=docs ; \
	  test '$(abs_srcdir)' = '$(abs_builddir)' || paths='$(srcdir)/docs $(abs_builddir)/docs' ; \
	  for docs in $$paths ; do \
	    cd "$$docs" && for f in `find rdocs -type f -print` ; do \
	      echo " rm -f '$(DESTDIR)$(docdatadir)/$$f'"; \
	      rm -f "$(DESTDIR)$(docdatadir)/$$f"; \
	    done; \
	  done

docdatadir = $(docdir)/ruby
dist_docdata_DATA = docs/index.html

EXTRA_DIST += generate-rdoc-stubs docs/xapian.rb

BUILT_SOURCES += docs/rdocs/index.html

docs/rdocs/index.html: docs/xapian.rb
	rm -rf docs/rdocs
	$(MKDIR_P) docs
	cd docs && $(RDOC) --op rdocs `test -f xapian.rb||echo '$(abs_srcdir)/docs/'`xapian.rb

if DOCUMENTATION_RULES
docs/xapian.rb: generate-rdoc-stubs xapian.rb ../doxygen-xml/index.xml
	$(PERL) $(srcdir)/generate-rdoc-stubs

BUILT_SOURCES += docs/index.html

.rst.html:
	-case "$@" in */*) d=`echo "$@"|sed 's,/[^/]*$$,,'`; $(MKDIR_P) "$$d" ;; esac
	$(RST2HTML) --exit-status=warning $< $@

CLEANFILES += docs/xapian.rb
endif
