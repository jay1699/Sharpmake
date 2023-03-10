// Copyright (c) 2017, 2019-2020 Ubisoft Entertainment
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace Sharpmake
{
    public static partial class Options
    {
        public static class Makefile
        {
            public static class General
            {
                public enum PlatformToolset
                {
                    [Default]
                    Gcc,
                    Clang
                }
            }

            public static class Compiler
            {
                public enum CppLanguageStandard
                {
                    [Default]
                    Default,
                    Cpp98,
                    Cpp11,
                    Cpp14,
                    Cpp17,
                    Cpp2a,
                    GnuCpp98,
                    GnuCpp11,
                    GnuCpp14,
                    GnuCpp17,
                    GnuCpp2a,
                }

                public enum Exceptions
                {
                    Enable,
                    [Default]
                    Disable
                }

                public enum ExtraWarnings
                {
                    Enable,
                    [Default]
                    Disable
                }

                public enum GenerateDebugInformation
                {
                    [Default]
                    Enable,
                    Disable
                }

                public enum OptimizationLevel
                {
                    [Default(DefaultTarget.Debug)]
                    Disable,
                    Standard,
                    Full,
                    [Default(DefaultTarget.Release)]
                    FullWithInlining,
                    ForSize
                }

                public enum Rtti
                {
                    [Default]
                    Disable,
                    Enable
                }

                public enum TreatWarningsAsErrors
                {
                    Enable,
                    [Default]
                    Disable
                }

                public enum Warnings
                {
                    NormalWarnings,
                    [Default]
                    MoreWarnings,
                    Disable
                }
            }

            public static class Linker
            {
                public enum LibGroup
                {
                    Enable,
                    [Default]
                    Disable
                }
            }
        }
    }
}
