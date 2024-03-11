namespace lab_1;

public class PersonalInfo
{
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }
    public Sex Sex { get; private set; }
    public DateTime Birthday { get; private set; }
    
    public PersonalInfo(string firstName, string middleName, string lastName, Sex sex, DateTime birthday)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        Sex = sex;
        Birthday = birthday;
    }
}