// Copyright (C) 2024 negative_seven
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not
// distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Exapt.Wrappers.Meta;

namespace Exapt.Wrappers;

[ClassWrapper("ReliableRandom")]
public class Random(ulong seed) : NonStaticWrapper<Random>(CallConstructor(seed)!) { }
