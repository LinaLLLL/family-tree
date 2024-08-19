using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_tree
{
    public class FamilyMembers
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        Gender gender { get; set; }
        FamilyMembers Mother { get; set; }
        FamilyMembers Father { get; set; }

        public FamilyMembers[] GetGrandMother()
        {
            return new FamilyMembers[] { Mother.Mother, Father.Mother };
        }
        public FamilyMembers[] GetGrandFather()
        {
            return new FamilyMembers[] { Father.Father, Mother.Father };
        }
        public FamilyMembers[] GetParents()
        {
            return new FamilyMembers[] { Mother, Father };
        }
        //public FamilyMembers GetChildren()
        //{
        //    //return new FamilyMembers ;
        //}

    }
    public enum Gender { male, female }
}
