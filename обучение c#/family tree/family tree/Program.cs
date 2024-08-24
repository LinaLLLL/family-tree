using family_tree;
using Microsoft.VisualBasic.FileIO;

public class Program
{
    public static void Main(string[] args)
    {
        FamilyMembers GrandFatherOne = new FamilyMembers()
        {
            FullName = "Иванов Иван Иванович",
            Age = 68,
            gender = Gender.male,
            
        };
        
        FamilyMembers GrandMatherOne = new FamilyMembers()
        {
            FullName = "Иванова Галина Сергеевна",
            Age = 64,
            gender = Gender.female,
            Husband = GrandFatherOne,
            
        };

        GrandFatherOne.Wife = GrandMatherOne;

        FamilyMembers GrandFatherTwo = new FamilyMembers()
        {
            FullName = "Петров Николай Иванович",
            Age = 75,
            gender = Gender.male,
            
        };

        FamilyMembers GrandMatherTwo = new FamilyMembers()
        {
            FullName = "Петрова Лариса Владиславовна",
            Age = 70,
            gender = Gender.female,
            Husband= GrandFatherTwo,
        };

        GrandFatherTwo.Wife = GrandMatherTwo;

        FamilyMembers Mother = new FamilyMembers()
        {
            FullName = "Иванова Мария Николаевна",
            Age = 43,
            gender = Gender.female,
            Mother = GrandMatherTwo,
            Father = GrandFatherTwo,
        };
        Mother.Wife = Mother;

        FamilyMembers Father = new FamilyMembers()
        {
            FullName = "Иванов Геннадий Иванович",
            Age = 49,
            gender = Gender.male,
            Mother = GrandMatherOne,
            Father = GrandFatherOne,
            Wife = Mother,
            
        };

        Mother.Husband = Father;
        Father.Husband = Father;

        FamilyMembers Son = new FamilyMembers()
        {
            FullName = "Иванов Роман Геннадьевич",
            Age = 23,
            gender = Gender.male,
            Mother = Mother,
            Father = Father,
        };
        var GrandMother = Son.GetGrandMother();
        Console.WriteLine(GrandMother[0]?.FullName);
        Console.WriteLine(GrandMother[1]?.FullName);
        Console.WriteLine("_________________________________________________");
        var Parents = Son.GetParents();
        Console.WriteLine(Parents[0]?.FullName);
        Console.WriteLine(Parents[1]?.FullName);
        Console.WriteLine("_________________________________________________");

        var Sposes = Father.GetSpouses();
        Console.WriteLine(Sposes[0]?.FullName);
        Console.WriteLine(Sposes[1]?.FullName);


    }
}