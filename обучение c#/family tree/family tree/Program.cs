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
        FamilyMembers GrandFatherTwo = new FamilyMembers()
        {
            FullName = "Петров Николай Иванович",
            Age = 75,
            gender = Gender.male,
        };
        FamilyMembers GrandMatherOne = new FamilyMembers()
        {
            FullName = "Иванова Галина Сергеевна",
            Age = 56,
            gender = Gender.female,
        };
        FamilyMembers GrandMatherTwo = new FamilyMembers()
        {
            FullName = "Петрова Лариса Владиславовна",
            Age = 70,
            gender = Gender.female,
        };
        FamilyMembers Mother = new FamilyMembers()
        {
            FullName = "Иванова Мария Николаевна",
            Age = 43,
            gender = Gender.female,
            Mother = GrandMatherTwo,
            Father = GrandFatherTwo,
        };
        FamilyMembers Father = new FamilyMembers()
        {
            FullName = "Иванов Геннадий Иванович",
            Age = 49,
            gender = Gender.male,
            Mother = GrandMatherOne,
            Father = GrandFatherOne,
        };
        FamilyMembers Son = new FamilyMembers()
        {
            FullName = "Иванов Роман Геннадьевич",
            Age = 23,
            gender = Gender.male,
            Mother = Mother,
            Father = Father,
        };

    }
}