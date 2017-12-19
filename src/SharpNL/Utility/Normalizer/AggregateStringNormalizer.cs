﻿// 
//  Copyright 2017 Gustavo J Knuppe (https://github.com/knuppe)
// 
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//  

using System;
using System.Linq;

namespace SharpNL.Utility.Normalizer {

    /// <summary>
    /// Agregates analyzers into this analyzers.
    /// </summary>
    /// <inheritdoc />
    public sealed class AggregateStringNormalizer : IStringNormalizer {

        private readonly IStringNormalizer[] normalizers;

        /// <summary>
        /// Creates a new instance of aggregate string analyzer with the specified analyzers. 
        /// </summary>
        /// <param name="normalizers">The analyzers.</param>
        public AggregateStringNormalizer(params IStringNormalizer[] normalizers) {
            if (normalizers.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(normalizers));

            this.normalizers = normalizers;
        }

        /// <inheritdoc />
        public string Normalize(string text) {
            return normalizers.Aggregate(text, (current, normalizer) => normalizer.Normalize(current));
        }
    }
}
