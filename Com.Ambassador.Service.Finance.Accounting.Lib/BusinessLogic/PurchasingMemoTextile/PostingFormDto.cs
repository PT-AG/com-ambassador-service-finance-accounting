﻿using System.Collections.Generic;

namespace Com.Ambassador.Service.Finance.Accounting.Lib.BusinessLogic.PurchasingMemoTextile
{
    public class PostingFormDto
    {
        public PostingFormDto()
        {
            Ids = new List<int>();
        }

        public List<int> Ids { get; set; }
    }
}