﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW__16
{
    interface DataInterface
    {
        List<RawDataItem> GetRawData();
        List<SummaryDataItem> GetSummaryData();
    }
}
