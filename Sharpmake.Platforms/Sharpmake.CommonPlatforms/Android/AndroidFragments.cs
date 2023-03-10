// Copyright (c) 2021 Ubisoft Entertainment
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

using System;

namespace Sharpmake
{
    public static partial class Android
    {
        [Fragment, Flags]
        public enum AndroidBuildTargets
        {
            armeabi_v7a = 1 << 0,
            arm64_v8a = 1 << 1,
            x86 = 1 << 2,
            x86_64 = 1 << 3,
        }

        [Fragment, Flags]
        public enum AndroidBuildType
        {
            Ant = 1 << 0,
            Gradle = 1 << 1
        }
    }
}
