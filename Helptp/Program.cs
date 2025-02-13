// See https://aka.ms/new-console-template for more information

using System.CommandLine;
using helptp.Extensions;

var command = new RootCommand("prints the name of a given http status code");
var statusCode = new Argument<int>("http status code");
command.AddArgument(statusCode);
command.SetHandler((code) => Console.WriteLine(code.GetHttpStatusName()), statusCode);

await command.InvokeAsync(args);
