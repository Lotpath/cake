﻿using System;
using System.Collections.Generic;
using Cake.Core.Diagnostics;
using Cake.Core.IO;

namespace Cake
{
    public sealed class CakeOptions
    {
        private readonly Dictionary<string, string> _arguments;

        public Verbosity Verbosity { get; set; }
        public FilePath Script { get; set; }

        public IDictionary<string, string> Arguments
        {
            get { return _arguments; }
        }

        public bool ShowDescription { get; set; }
        public bool ShowHelp { get; set; }
        public bool ShowVersion { get; set; }

        public CakeOptions()
        {
            _arguments = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            Verbosity = Verbosity.Normal;
            ShowDescription = false;
            ShowHelp = false;
        }
    }
}
