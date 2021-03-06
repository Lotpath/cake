﻿using Cake.Core;

namespace Cake.Commands
{
    internal sealed class HelpCommand : ICommand
    {
        private readonly IConsole _console;

        // Delegate factory used by Autofac.
        public delegate HelpCommand Factory();

        public HelpCommand(IConsole console)
        {
            _console = console;
        }

        public void Execute(CakeOptions options)
        {
            _console.WriteLine("Usage: Cake.exe <build-script> [-verbosity=value] [-showdescription] [..]");
            _console.WriteLine();
            _console.WriteLine("Example: Cake.exe build.cake");
            _console.WriteLine("Example: Cake.exe build.cake -verbosity=quiet");
            _console.WriteLine("Example: Cake.exe build.cake -showdescription");
            _console.WriteLine();
            _console.WriteLine("Options:");
            _console.WriteLine("    -verbosity=value    Specifies the amount of information to be displayed.");
            _console.WriteLine("    -showdescription    Shows description about tasks.");
            _console.WriteLine("    -help               Displays usage information.");
        }
    }
}
