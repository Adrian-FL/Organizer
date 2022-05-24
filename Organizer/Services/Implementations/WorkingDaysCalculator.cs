using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class WorkingDaysCalculator : IWorkingDaysCalculator
    {
        public int GetWorkingDays(DateTime startDate, DateTime endDate)
        {
            return endDate.Subtract(startDate).Days + 1;
            //return endDate.Subtract(startDate).Days;
        }
    }
}
