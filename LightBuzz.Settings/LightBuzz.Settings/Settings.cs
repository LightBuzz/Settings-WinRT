// Copyright (c) LightBuzz, Inc.
// All rights reserved.
//
// http://lightbuzz.com
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions
// are met:
//
// 1. Redistributions of source code must retain the above copyright
//    notice, this list of conditions and the following disclaimer.
//
// 2. Redistributions in binary form must reproduce the above copyright
//    notice, this list of conditions and the following disclaimer in the
//    documentation and/or other materials provided with the distribution.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED
// AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
// LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY
// WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
// POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace LightBuzz.Settings
{
    public static class Settings
    {
        /// <summary>
        /// Inserts the specified value to the specified settings key, or creates a new pair.
        /// </summary>
        /// <typeparam name="T">A primitive type.</typeparam>
        /// <param name="key">The name of the setting.</param>
        /// <param name="value">The content of the setting.</param>
        public static void Set<T>(string key, T value)
        {
            ApplicationData.Current.LocalSettings.Values[key] = value;
        }

        /// <summary>
        /// Retrieves the contents of the specified setting key.
        /// </summary>
        /// <typeparam name="T">A primitive type.</typeparam>
        /// <param name="key">The name of the setting.</param>
        /// <returns>The content of the spcified setting.</returns>
        public static T Get<T>(string key)
        {
            if (ApplicationData.Current.LocalSettings.Values.Keys.Contains(key))
            {
                return (T)ApplicationData.Current.LocalSettings.Values[key];
            }

            T value = default(T);

            Set<T>(key, value);

            return value;
        }

        /// <summary>
        /// Deletes the specified setting.
        /// </summary>
        /// <param name="key">The name of the setting.</param>
        public static void Remove(string key)
        {
            ApplicationData.Current.LocalSettings.Values.Remove(key);
        }
    }
}
