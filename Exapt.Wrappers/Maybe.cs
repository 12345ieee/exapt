// Copyright (C) 2024 negative_seven
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not
// distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace Exapt.Wrappers;

internal sealed class Maybe : NonStaticWrapper<Maybe>
{
    internal Maybe(object inner)
        : base(inner) { }

    public bool IsSome()
    {
        return (bool)Call("#=qgQ5O1bL8ilWB5y5e4ATciQ==")!;
    }

    public object Unwrap()
    {
        return Call("#=qmoDLSpl1snp9jPcvZqncJg==")!;
    }
}
