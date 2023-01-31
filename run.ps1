msbuild -nologo -m -clp:verbosity=minimal $PSScriptRoot\conn.sln
& $PSScriptRoot\net31\bin\Debug\netcoreapp3.1\net31.exe
& $PSScriptRoot\net50\bin\Debug\net5.0\net50.exe
& $PSScriptRoot\net60\bin\Debug\net6.0\net60.exe
