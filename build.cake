var target = Argument("target", "default");
var configuration = Argument("configuration", "release");

var solution = File("./ProductivityTools.PSMasterConfiguration.sln");

var directory="module";

Task("Default")
  .Does(() =>
{
  Information("Hello World!");
  DotNetBuild(solution);
  
  CopyDirectory(@"out\bin\Debug", "Module");
});

RunTarget(target);