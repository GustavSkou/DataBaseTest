class Teacher
{
    private string firstName, lastName, subject;
    private int id, salary;
    public Teacher(int id, string firstName, string lastName, string subject, int salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.subject = subject;
        this.salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public override string ToString()
    {
        return $"ID: {id},\nFirst name: {firstName},\nLast name: {lastName},\nSubject: {subject},\nSalary: {salary}";
    }
}