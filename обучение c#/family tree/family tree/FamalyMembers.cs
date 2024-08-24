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
        public Gender gender { get; set; }
        public FamilyMembers Mother { get; set; }
        public FamilyMembers Father { get; set; }
        public FamilyMembers Wife { get; set; }
        public FamilyMembers Husband { get; set; }
        
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
        public FamilyMembers[] GetSpouses()
        {
            return new FamilyMembers[] { Wife, Husband };
        }
        

    }
    public enum Gender { male, female }
}
