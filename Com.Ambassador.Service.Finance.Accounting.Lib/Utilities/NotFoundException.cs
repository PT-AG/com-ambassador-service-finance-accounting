﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.Utilities
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("this object is not exist")
        {

        }
    }
}
