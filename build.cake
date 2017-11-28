#tool "xunit.runner.console"

var target = Argument("target", "default");
var configuration = Argument("configuration", "Debug");
var solutions = GetFiles("./src/*.sln");

Task("version")    
    .Does(() =>
{
    var file = "./src/version.cs";
	var version = "0.1.0";
	
    CreateAssemblyInfo(file, new AssemblyInfoSettings
    {
        Product = "Sample Submission",
        Version = version,
        FileVersion = version,
        InformationalVersion = version        
    });
});

Task("restorepackages")    
    .Does(() =>
{    
    foreach(var solution in solutions)
    {
        Information("Restoring {0}", solution);
        NuGetRestore(solution);
    }
});


Task("build")    
	.IsDependentOn("restorepackages")
	.IsDependentOn("version")	
    .Does(() =>
{    
    foreach(var solution in solutions)
    {
        Information("Building {0}", solution);
        MSBuild(solution, settings =>
            settings
					.SetVerbosity(Verbosity.Diagnostic)
					.SetMSBuildPlatform(MSBuildPlatform.Automatic)
					.SetPlatformTarget(PlatformTarget.MSIL)
                    .WithTarget("Build")
                    .SetConfiguration(configuration));
    }
});

Task("tests")
    .IsDependentOn("build")
    .Does(() =>
{
	EnsureDirectoryExists("artifacts");

    XUnit2("./src/**/bin/" + configuration + "/*.Tests.dll", new XUnit2Settings
    {
        OutputDirectory = "./artifacts/",
        HtmlReport = true
    });
});

Task("default")
    .IsDependentOn("tests");
	
RunTarget(target);