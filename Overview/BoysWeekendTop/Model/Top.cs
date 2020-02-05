using System;
using System.Collections.Generic;
using System.Text;

namespace BoysWeekendTop.Model
{
    public class Top
    {
        public enum CategoryType
        {
            onenightstand,
            relatie,
            anaal,
            pijpslet,
            gangbangslet
        }

        public Boy Owner { get; set; }
        public CategoryType Category { get; set; }

        public Girl First { get; set; }
        public Girl Second { get; set; }
        public Girl Third { get; set; }
    }
}
