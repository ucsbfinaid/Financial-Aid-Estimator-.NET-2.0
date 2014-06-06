using System.Collections.Generic;
namespace Ucsb.Sa.FinAid.AidEstimation
{
    public class CostOfAttendance
    {
        public double OutOfStateFees { get; set; }

        /// <summary>
        /// The list of items that constitute the Cost of Attendance.
        /// This does not include Out of State Fees
        /// </summary>
        public List<CostOfAttendanceItem> Items
        {
            get;
            private set;
        }

        /// <summary>
        /// Total Cost of Attendance (not including Out of State Fees)
        /// </summary>
        public double Total
        {
            get
            {
                double total = 0;

                foreach (CostOfAttendanceItem item in Items)
                {
                    total += item.Value;
                }

                return total;
            }
        }

        public CostOfAttendance(params CostOfAttendanceItem[] items)
            : this()
        {
            Items.AddRange(items);
        }

        public CostOfAttendance(double outOfStateFees, params CostOfAttendanceItem[] items)
            : this(items)
        {
            OutOfStateFees = outOfStateFees;
        }

        public CostOfAttendance()
        {
            Items = new List<CostOfAttendanceItem>();
        }
    }
}