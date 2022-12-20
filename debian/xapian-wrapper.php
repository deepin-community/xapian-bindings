<?php
// Debian-specific wrapper to allow PHP5 and PHP7 bindings to be concurrently
// installed.  If this require fails, you probably need to install php7-xapian.
require "_xapian-".PHP_MAJOR_VERSION.".php";
?>
