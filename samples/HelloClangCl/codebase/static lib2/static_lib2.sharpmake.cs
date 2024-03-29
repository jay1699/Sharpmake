﻿// Copyright (c) 2021 Ubisoft Entertainment
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Sharpmake;

namespace HelloClangCl
{
    [Sharpmake.Generate]
    public class StaticLib2Project : CommonProject
    {
        public StaticLib2Project()
        {
            AddTargets(CommonTarget.GetDefaultTargets());
            Name = "static lib2";
        }

        public override void ConfigureAll(Configuration conf, CommonTarget target)
        {
            base.ConfigureAll(conf, target);

            conf.SolutionFolder = "StaticLibs";

            // skip the generation of the lib, and use the obj for the link instead
            conf.Options.Add(Options.Vc.Linker.UseLibraryDependencyInputs.Enable);

            conf.IncludePaths.Add(SourceRootPath);
        }
    }
}
