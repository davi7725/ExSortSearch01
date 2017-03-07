using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSortSearch01
{
    class ClubMember : IComparable
    {
        public int Nr { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public ClubMember(int nr, string fname, string lname, int age)
        {
            Nr = nr;
            Fname = fname;
            Lname = lname;
            Age = age;
        }

        public int CompareTo(object data)
        {
            int result = 0;
            ClubMember cm = (ClubMember)data;

            if(this.Nr > cm.Nr)
            {
                result = 1;
            }
            else if (this.Nr < cm.Nr)
            {
                result = -1;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            bool allEqual = false;
            ClubMember cm = (ClubMember)obj;

            if(this.Nr == cm.Nr && this.Fname == cm.Fname && this.Lname == cm.Lname && this.Age == cm.Age)
            {
                allEqual = true;
            }

            return allEqual;
        }

        public override int GetHashCode()
        {
            return Age.GetHashCode() + Fname.GetHashCode() + Lname.GetHashCode() + Nr.GetHashCode();
        }

        public override string ToString()
        {
            return Nr + " " + Fname + " " + Lname + " " + Age;
        }
    }
}
