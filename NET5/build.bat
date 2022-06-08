mkdir .\packages
REM set PATH=%WINDIR%\Microsoft.Net\Framework64\v3.5;%PATH%
nuget restore NET5.sln -OutputDirectory ./packages
dotnet msbuild NET5.sln  -t:Rebuild -p:Configuration=Release -v:n

pause