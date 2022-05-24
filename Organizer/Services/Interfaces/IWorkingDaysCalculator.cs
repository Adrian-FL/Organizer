using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    interface IWorkingDaysCalculator
    {
        int GetWorkingDays(DateTime startDate, DateTime endDate);
    }
}
