// Copyright (C) 2024 negative_seven
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not
// distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace Exapt.Wrappers;

public class FindMemberException : Exception
{
    public FindMemberException() { }

    public FindMemberException(string message)
        : base(message) { }

    public FindMemberException(string message, Exception innerException)
        : base(message, innerException) { }
}
