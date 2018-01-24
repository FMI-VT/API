﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Interface
{
    internal interface IStrategy
    {
        void Start(string sourcePath, string destinationPath);
    }
}