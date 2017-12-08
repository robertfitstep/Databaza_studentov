using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaza_studentov
{
    struct Student
    {
        public string meno;
        public string priezvysko;
        public int vek;

        public Student(string meno, string priezvysko, int vek)
        {
            this.meno = meno;
            this.priezvysko = priezvysko;
            this.vek = vek;
        }

    }

    
}
