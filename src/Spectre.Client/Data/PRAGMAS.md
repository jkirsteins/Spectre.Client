# On the use of pragmas

## IDE1006, SA1300, CA1707, SA1609

Refit expects an exact mapping of model field names to API payload field names
(i.e. "id" instead of "Identifier", "data" instead of "Data", etc.)

[AliasAs] permits mapping the names for responses, but it doesn't work for
requests (so e.g. ParamWrapper would not work in both directions.)

Ultimately, it is less hassle to just have exact names. Pull requests (to fix
this and permit more idiomatic naming in a simple manner) are most welcome.

# CA2227

Refit expects collection fields to have public setters. However, having setters
for collections triggers a code warning.
