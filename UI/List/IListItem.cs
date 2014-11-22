////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) GHI Electronics, LLC.
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

using Microsoft.SPOT;

using GHI.Glide.Display;

namespace GHI.Glide.UI
{
    interface IListItem
    {
        string Label { get; set; }
        object Value { get; set; }
    }
}
