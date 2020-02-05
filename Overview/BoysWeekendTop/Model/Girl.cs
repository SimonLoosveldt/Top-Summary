using System;
using System.Collections.Generic;
using System.Text;

namespace BoysWeekendTop.Model
{
    public class Girl
    {
        public enum DepartmentType
        {
            Kabouters,
            Sloebers,            
            SpeelclubJongens,
            SpeelclubMeisjes,
            Rakkers,
            Kwiks,
            Toppers,
            Tippers,
            Kerels,
            Tiptiens,
            Aspis,
            Aspies
        }

        public string Name { get; set; }
        public DepartmentType Department { get; set; }
    }
}
