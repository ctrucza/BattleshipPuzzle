Get-ChildItem -include bin,obj -recurse | foreach ($_) { write-output $_.fullname; Remove-Item $_.FullName -Recurse }
Pause