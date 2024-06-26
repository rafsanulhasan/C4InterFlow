﻿// See https://aka.ms/new-console-template for more information
using C4InterFlow.Cli;
using C4InterFlow.Cli.Root;
using C4InterFlow.Cli.Commands;

var root = RootCommandBuilder
    .CreateDefaultBuilder(args)
    .Configure(context =>
    {
        context.Add<DrawDiagramsCommand>();
        context.Add<QueryUseFlowsCommand>();
        context.Add<QueryByInputCommand>();
        context.Add<ExecuteAaCStrategyCommand>();
        context.Add<GenerateDocumentationCommand>();
        context.Add<PublishSiteCommand>();
    });

await root.Run();