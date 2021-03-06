﻿// [[[[INFO>
// Copyright 2015 Epicycle (http://epicycle.org, https://github.com/open-epicycle)
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
// 
// For more information check https://github.com/open-epicycle/Epicycle.Math-cs
// ]]]]

namespace Epicycle.Math.Geometry
{
    public static class Vector2iUtils
    {
        public sealed class YamlSerialization
        {
            public int X { get; set; }
            public int Y { get; set; }

            public YamlSerialization() { }

            public YamlSerialization(Vector2i v)
            {
                X = v.X;
                Y = v.Y;
            }

            public Vector2i Deserialize()
            {
                return new Vector2i(X, Y);
            }
        }
    }
}
