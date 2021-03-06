﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Node.net
{
    public class HostModule : IronJS.AutoWrapObject
    {
        /// <summary>
        /// A protected constructor for the HostModule base class.
        /// </summary>
        /// <param name="env">The JavaScript environment.</param>
        protected HostModule(IronJS.Environment env) : base(env)
        {
        }
    }
}
