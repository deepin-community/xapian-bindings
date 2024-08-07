# RedHat-style .spec file for Xapian
# xapian-bindings.spec.  Generated from xapian-bindings.spec.in by configure.
#
# If you don't want to try building packages for all the supported bindings,
# you can disable particular bindings by passing these options to rpmbuild:
#
#	--without csharp	Disable C# bindings
#	--without perl		Disable Perl bindings
#	--without php		Disable PHP 8 bindings
#	--without python	Disable Python bindings
#	--without ruby		Disable Ruby bindings
#	--without tcl8		Disable Tcl8 bindings

%if 0%{?!_without_python:1}
%define python_ver %(%{__python} -c "import sys; print sys.version[:3]")
%endif

%if 0%{?!_without_php:1}
%define php_extension_dir %(php-config --extension-dir)
%endif

%if 0%{?!_without_ruby:1}
%define ruby_ver %(ruby -e "print RUBY_VERSION")
%endif

%if 0%{?!_without_tcl8:1}
%define tcl_lib %(echo 'foreach d $tcl_pkgPath {if {![regexp {/share(/|$)} $d]} {break}};puts $d'|tclsh)
%endif

%if 0%{?!_without_perl:1}
%define perl_lib %(%{__perl} -MConfig -e 'print $Config{installsitelib}')
%define perl_arch %(%{__perl} -MConfig -e 'print $Config{installsitearch}')
%endif

Summary: Bindings for the Xapian Search Engine Library
Name: xapian-bindings
Version: 1.4.25
Release: 1
License: GPL
Vendor: xapian.org
Group: Development/Libraries
URL: https://xapian.org/
Requires: xapian-core-libs = %{version}
%if 0%{?!_without_python:1}
BuildRequires: python-devel >= 2.3
%endif
%if 0%{?!_without_php:1}
BuildRequires: php-devel >= 8.0
%endif
%if 0%{?!_without_ruby:1}
BuildRequires: ruby-devel >= 1.8
%endif
%if 0%{?!_without_tcl8:1}
BuildRequires: tcl-devel >= 8.1
%endif
%if 0%{?!_without_csharp:1}
BuildRequires: mono-devel >= 1.1
%endif
%if 0%{?!_without_perl:1}
# https://fedoraproject.org/wiki/Packaging:Perl
# perl-devel doesn't exist on RHEL 5 so use ExtUtils::MakeMaker for perl.h
BuildRequires: perl(ExtUtils::MakeMaker)
%endif
BuildRequires: autoconf automake libtool
Source0: https://oligarchy.co.uk/xapian/%{version}/%{name}-%{version}.tar.xz
Buildroot: %{_tmppath}/%{name}-%{version}-%{release}-root

%description
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for scripts which use Xapian.

%if 0%{?!_without_ruby:1}
%package ruby
Group: Development/Libraries
Summary: Files needed for Ruby scripts which use Xapian.
Requires: %{name} = %{version}, ruby >= %{ruby_ver}

%description ruby
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for developing and running
Ruby scripts which use Xapian.
%endif

%if 0%{?!_without_python:1}
%package python
Group: Development/Libraries
Summary: Files needed for Python scripts which use Xapian.
Requires: %{name} = %{version}, python >= %{python_ver}

%description python
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for developing and running
Python scripts which use Xapian.
%endif

%if 0%{?!_without_php:1}
%package php
Group: Development/Libraries
Summary: Files needed for PHP scripts which use Xapian.
Requires: %{name} = %{version}, php

%description php
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for developing and running
PHP scripts which use Xapian.
%endif

%if 0%{?!_without_tcl8:1}
%package tcl8
Group: Development/Libraries
Summary: Files needed for Tcl scripts which use Xapian.
Requires: %{name} = %{version}, tcl

%description tcl8
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for developing and running
Tcl scripts which use Xapian.
%endif

%if 0%{?!_without_csharp:1}
%package csharp
Group: Development/Libraries
Summary: Files needed for C# applications which use Xapian.
Requires: %{name} = %{version}, mono-core

%description csharp
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for developing and running
C# applications which use Xapian.
%endif

%if 0%{?!_without_perl:1}
%package perl
Group: Development/Libraries
Summary: Files needed for Perl applications which use Xapian.
Requires: %{name} = %{version}
Requires: perl(:MODULE_COMPAT_%(eval "`%{__perl} -V:version`"; echo $version))
Requires: perl(Exporter) perl(DynaLoader)

%description perl
Xapian is a highly adaptable toolkit which allows developers to easily
add advanced indexing and search facilities to their own applications.
It has built-in support for several families of weighting models and
also supports a rich set of boolean query operators.

This package provides the files needed for developing and running
Perl applications which use Xapian.
%endif

%prep
%setup -q -n %{name}-%{version}

%build
# As of 1.1.0, Xapian uses libtool 2.2.x which allows us to override libtool's
# sometimes conservative take on which directories are in the default dynamic
# linker search path, so we no longer incorrectly try to set rpath for
# /usr/lib64.  Hence there's no longer a need to run "autoreconf --force" here
# and it's better not to as it avoids having to cope with incompatibilities
# with older versions of the autotools which older distros have.
#autoreconf --force
# Only build the bindings we want.
%configure %{?!_without_python:--with-python} %{?!_without_php:--with-php} %{?!_without_tcl8:--with-tcl} %{?!_without_csharp:--with-csharp} %{?!_without_ruby:--with-ruby} %{?!_without_perl:--with-perl}
make

%install
[ "%{buildroot}" != "/" ] && rm -rf %{buildroot}
mkdir -p %{buildroot}
# Installation of some files does not obey prefix, so use make install with
# DESTDIR instead of makeinstall.
make install DESTDIR=%{buildroot}
# Move the docs to the right places.
%{?!_without_python: mv %{buildroot}%{_datadir}/doc/%{name}/python %{buildroot}%{_datadir}/doc/%{name}-python-%{version}}
%{?!_without_php: mv %{buildroot}%{_datadir}/doc/%{name}/php %{buildroot}%{_datadir}/doc/%{name}-php-%{version}}
%{?!_without_tcl8: mv %{buildroot}%{_datadir}/doc/%{name}/tcl8 %{buildroot}%{_datadir}/doc/%{name}-tcl8-%{version}}
%{?!_without_csharp: mv %{buildroot}%{_datadir}/doc/%{name}/csharp %{buildroot}%{_datadir}/doc/%{name}-csharp-%{version}}

%clean
[ "%{buildroot}" != "/" ] && rm -rf %{buildroot}

%files
%defattr(-, root, root)
# There are no common files at the moment
%doc AUTHORS ChangeLog COPYING NEWS README

%if 0%{?!_without_python:1}
%files python
%defattr(-, root, root)
%{_libdir}/python%{python_ver}/site-packages/xapian/_xapian.so
%{_libdir}/python%{python_ver}/site-packages/xapian/__init__.py
%{_libdir}/python%{python_ver}/site-packages/xapian/__init__.pyc
%ghost %{_libdir}/python%{python_ver}/site-packages/xapian/__init__.pyo
%doc %{_datadir}/doc/%{name}-python-%{version}
%endif

%if 0%{?!_without_php:1}
%files php
%defattr(-, root, root)
%{php_extension_dir}/xapian.so
%doc %{_datadir}/doc/%{name}-php-%{version}
%endif

%if 0%{?!_without_ruby:1}
%files ruby
%defattr(-, root, root)
%{_libdir}/ruby
/usr/lib/ruby
%defattr(0644, root, root)
%{_docdir}/xapian-bindings/ruby/
%endif

%if 0%{?!_without_tcl8:1}
%files tcl8
%defattr(-, root, root)
%{tcl_lib}/xapian%{version}
%doc %{_datadir}/doc/%{name}-tcl8-%{version}
%endif

%if 0%{?!_without_csharp:1}
%files csharp
%defattr(-, root, root)
%{_libdir}/_XapianSharp.so
%{_libdir}/mono/XapianSharp
%{_libdir}/mono/gac/XapianSharp
%doc %{_datadir}/doc/%{name}-csharp-%{version}
%endif

%if 0%{?!_without_perl:1}
%files perl
%defattr(-, root, root)
%{perl_arch}/auto/Xapian/Xapian.so
%{perl_lib}/Xapian.pm
%{perl_lib}/Xapian
%doc %{_datadir}/doc/%{name}/perl
%endif
