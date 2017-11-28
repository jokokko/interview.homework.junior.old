# Tasks by project #

Follow the instructions below so that build (build.bat) passes.

## Sample.Tasks.Domain & Sample.Tasks.Domain.Tests ##

Implement BusinessFinder and BusinessAddressFinder so that their respective unit tests
in the test assembly pass.

Fetch the data through the PRH Open Data API, documented in http://avoindata.prh.fi/index_en.html (hint: a possible library for interfacing with the API http://restsharp.org/). 

## Sample.Tasks.Console ##

By using the implementations from Sample.Tasks.Domain, complete BusinessFinderActor
and AddressFinderActor so that they can fetch and print business records and their respective addresses based on user input. 

Use the referenced Proto Actor framework, documented in http://proto.actor/docs/dotnet/.

Note: This project pulls in a lot of dependencies. Let NuGet resolve them all for you.

## Lastly ##

The codebase has questions embedded in *<question>* tags in parts of the XML documentation. Answer the provided questions in *<answer>* tags, placed under the questions. 

# Technical Details #

## Building & Versioning ##

The solution is built via Cake (C# Make): http://cakebuild.net/
The build process also generates assembly version information and runs unit tests.  

All the assemblies target .NET Framework 4.6.2. See that you have the necessary
build tools installed for the said version (https://www.microsoft.com/en-us/download/details.aspx?id=53321).

Note: Sample.Tasks.Console project uses C# 7.0 (pattern matching).

## Other Stuff ##

Feel free to upgrade any libraries used.
Feel free to use any new libraries, but give a rationale for introducing new dependencies.

The solution with all the files included can be edited with

Visual Studio Community: https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx Full-fledged .NET IDE

Visual Studio Code: https://code.visualstudio.com/ Extensible code editor