## Process this file with automake to produce Makefile.in

include ../generic/generic.mk

# Disable parallel build for this make invocation; some tests depend
# on previous ones having set up their database for them.
.NOTPARALLEL:

## Test programs to be run
TESTS = \
	t/01use.t \
	t/02pod.t \
	t/03podcoverage.t \
	t/04functions.t \
	t/10query.t \
	t/collapse.t \
	t/create.t \
	t/databasemodified.t \
	t/document.t \
	t/exception.t \
	t/index.t \
	t/parser.t \
	t/search.t \
	t/sorter.t \
	t/stem.t \
	t/symbol-test.t \
	t/termgenerator.t \
	t/thread.t \
	t/tied.t \
	t/valuerange.t \
	t/writabledatabase.t
AM_TESTS_ENVIRONMENT = \
	srcdir='$(srcdir)' ;\
	CPPFLAGS="$(CPPFLAGS)" ;\
	CXX="$(CXX)" ;\
	CXXFLAGS="$(CXXFLAGS)" ;\
	XAPIAN_CONFIG="$(XAPIAN_CONFIG)" ;\
	export srcdir ;\
	export CPPFLAGS ;\
	export CXX ;\
	export CXXFLAGS ;\
	export XAPIAN_CONFIG ;
LOG_COMPILER = \
    $(LIBTOOL) -dlopen Xapian.la --mode=execute $(MACOS_SIP_HACK_ENV) $(PERL) \
	$(srcdir)/run-perl-test

installcheck-local:
	$(MAKE) AM_LOG_FLAGS=

clean-local:
	rm -rf testdb* auto

BUILT_SOURCES = Xapian.pm xapian_wrap.cc \
	auto/Xapian/Xapian$(PERL_SO)

auto/Xapian/Xapian$(PERL_SO): Xapian.la
	@$(MKDIR_P) auto/Xapian
	cp "$(_libs)/Xapian$(PERL_SO)" auto/Xapian

EXTRA_DIST = perl.i except.i extra.i $(TESTS) \
	generate-perl-exceptions \
	run-perl-test \
	Xapian.pm xapian_wrap.cc \
	t/symbol-test/SymbolTest.pm \
	t/symbol-test/typemap \
	t/symbol-test/SymbolTest.xs \
	t/symbol-test/Makefile.PL

exampledatadir = $(docdir)/perl/examples
dist_exampledata_DATA = \
	docs/examples/full-indexer.pl \
	docs/examples/full-searcher.pl \
	docs/examples/simpleexpand.pl \
	docs/examples/simpleindex.pl \
	docs/examples/simplematchdecider.pl \
	docs/examples/simplesearch.pl

perlarchdir = $(PERL_ARCH)/auto/Xapian
perlarch_LTLIBRARIES = Xapian.la

# Remove the .la file - Xapian.la is never linked against (it's a module)
# and Perl doesn't use libltdl.  Note that the library gets installed by
# install-data, so that's where we need to hook.
install-data-hook:
	rm -f $(DESTDIR)$(perlarchdir)/Xapian.la

install-data-local:
	$(mkinstalldirs) "$(DESTDIR)$(docdatadir)/Xapian"
	@cd docs ; for f in Xapian/*.html ; do \
	  echo " $(INSTALL_DATA) '$$f' '$(DESTDIR)$(docdatadir)/$$f'"; \
	  $(INSTALL_DATA) "$$f" "$(DESTDIR)$(docdatadir)/$$f"; \
	done

uninstall-local:
	## Because we don't install the .la file, "make uninstall" doesn't work and
	## we need to remove the file ourselves.
	rm -f $(DESTDIR)$(perlarchdir)/Xapian$(PERL_SO)
	@cd docs ; for f in Xapian/*.html ; do \
	  echo " rm -f '$(DESTDIR)$(docdatadir)/$$f'"; \
	  rm -f "$(DESTDIR)$(docdatadir)/$$f"; \
	done


perllibdir = $(PERL_LIB)
nobase_dist_perllib_DATA = \
	Xapian.pm \
	Xapian/AssertionError.pm \
	Xapian/BM25Weight.pm \
	Xapian/BoolWeight.pm \
	Xapian/DatabaseCorruptError.pm \
	Xapian/DatabaseCreateError.pm \
	Xapian/DatabaseError.pm \
	Xapian/DatabaseLockError.pm \
	Xapian/DatabaseModifiedError.pm \
	Xapian/DatabaseOpeningError.pm \
	Xapian/Database.pm \
	Xapian/DatabaseVersionError.pm \
	Xapian/DocNotFoundError.pm \
	Xapian/Document.pm \
	Xapian/Enquire.pm \
	Xapian/Error.pm \
	Xapian/ESetIterator.pm \
	Xapian/ESet.pm \
	Xapian/FeatureUnavailableError.pm \
	Xapian/InternalError.pm \
	Xapian/InvalidArgumentError.pm \
	Xapian/InvalidOperationError.pm \
	Xapian/LogicError.pm \
	Xapian/MSetIterator.pm \
	Xapian/MSet.pm \
	Xapian/MultiValueSorter.pm \
	Xapian/NetworkError.pm \
	Xapian/NetworkTimeoutError.pm \
	Xapian/PositionIterator.pm \
	Xapian/PostingIterator.pm \
	Xapian/QueryParserError.pm \
	Xapian/QueryParser.pm \
	Xapian/Query.pm \
	Xapian/RangeError.pm \
	Xapian/RSet.pm \
	Xapian/RuntimeError.pm \
	Xapian/SimpleStopper.pm \
	Xapian/Stem.pm \
	Xapian/Stopper.pm \
	Xapian/TermGenerator.pm \
	Xapian/TermIterator.pm \
	Xapian/TradWeight.pm \
	Xapian/UnimplementedError.pm \
	Xapian/ValueIterator.pm \
	Xapian/Weight.pm \
	Xapian/WritableDatabase.pm

AM_CPPFLAGS = -I$(PERL_INC)
AM_CXXFLAGS = @SWIG_CXXFLAGS@ $(XAPIAN_CXXFLAGS)
Xapian_la_LDFLAGS = -avoid-version -module -shrext $(PERL_SO) $(NO_UNDEFINED)
Xapian_la_SOURCES = xapian_wrap.cc
Xapian_la_LIBADD = $(XAPIAN_LIBS) $(PERL_LIBS)

CLEANFILES =

if MAINTAINER_MODE
BUILT_SOURCES += except.i
except.i: $(srcdir)/generate-perl-exceptions ../../xapian-core/exception_data.pm
	$(PERL) -w -I$(srcdir)/../../xapian-core $(srcdir)/generate-perl-exceptions

stamp = xapian_wrap.stamp
RUN_SWIG = stamp='$(stamp)' $(PERL) '$(top_srcdir)'/swig-depcomp $(SWIG)

xapian_wrap.cc Xapian.pm: $(stamp)
	$(make_many_locked)
$(stamp): except.i
	$(multitarget_begin)
	$(RUN_SWIG) $(SWIG_WERROR) -I. -I'$(srcdir)' $(SWIG_FLAGS) -c++ \
	    -perl -module Xapian -const \
	    -DPERL_XAPIAN_VERSION='"$(PERL_XAPIAN_VERSION)"' \
	    -o xapian_wrap.cc '$(srcdir)/'perl.i
	$(multitarget_end)

-include xapian_wrap.d

CLEANFILES += xapian_wrap.d $(stamp)
endif
MAINTAINERCLEANFILES = $(BUILT_SOURCES)

docdatadir = $(docdir)/perl
docdata_DATA = docs/Xapian.html

CLEANFILES += docs/Xapian.html pod2html?.tmp

docs/Xapian.html: $(nobase_dist_perllib_DATA)
	$(MKDIR_P) docs
	$(MKDIR_P) docs/Xapian
	$(PERL) -MPod::Html -e 'for (@ARGV) { my $$pm = $$_; s/pm$$/html/; $$pm = "$(srcdir)/$$pm" unless -f $$pm; pod2html("--podpath=.", "--htmldir=docs", "--infile=$$pm", "--outfile=docs/$$_") }' $(nobase_dist_perllib_DATA)
	rm -f pod2htm?.tmp
