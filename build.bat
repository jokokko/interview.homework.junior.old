@echo off
cls
where msbuild.exe >nul 2>nul
if %errorlevel%==1 (
    @echo msbuild.exe not found in path.
    exit /b
)
If Not Exist src\.nuget\nuget.exe msbuild src\.nuget\NuGet.targets -Target:RestorePackages
If Not Exist src\packages\Cake\Cake.exe tools\nuget.exe Install Cake -OutputDirectory "src\packages" -ExcludeVersion -NonInteractive
src\packages\Cake\Cake.exe build.cake -target=default -verbosity=diagnostic