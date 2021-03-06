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

using NUnit.Framework;
using SharpNL.Utility.Normalizer;

namespace SharpNL.Tests.Utility.Normalizers {
    [TestFixture]
    public class UrlStringNormalizerTest {

        [Test]
        public void normalizeUrl() {
            Assert.AreEqual("asdf   2nnfdf", UrlStringNormalizer.Instange.Normalize("asdf http://asdf.com/dfa/cxs 2nnfdf"));

            Assert.AreEqual("asdf   2nnfdf  ", UrlStringNormalizer.Instange.Normalize("asdf http://asdf.com/dfa/cxs 2nnfdf http://asdf.com/dfa/cxs"));
        }

        [Test]
        public void normalizeEmail() {
            Assert.AreEqual("asdf   2nnfdf", UrlStringNormalizer.Instange.Normalize("asdf asd.fdfa@hasdk23.com.br 2nnfdf"));

            Assert.AreEqual("asdf   2nnfdf  ", UrlStringNormalizer.Instange.Normalize("asdf asd.fdfa@hasdk23.com.br 2nnfdf asd.fdfa@hasdk23.com.br"));
        }
    }
}
