using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.alg_and_data_str.HW3 {
    public  class Student {
        public string SurName { get; set; }

        public string FirstName { get; set; }

        public DateTime Birthday { get; set; }

        public int Group { get; set; }

        public override string ToString() {
            return $"{SurName} {FirstName} {Birthday.ToShortDateString()} - {Group}";
        }
    }
}
