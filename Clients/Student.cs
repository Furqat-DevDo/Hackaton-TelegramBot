global using System.ComponentModel.DataAnnotations.Schema;
global using System.ComponentModel.DataAnnotations;

namespace Ilmhub.Clients;
public class Student
{
    [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
    public long ChatId { get; set; }
    public string Studentname { get; set; }
    public string Fullname { get; set; }
    public string PhoneNumber { get; set; }
    public string SelectedCourse { get; set; }
    public string SelectedLanguage { get; set; }
    public Student() { }
    public Student(long ChatId, string PhoneNumber, string fullName, string Studentname)
    {
        this.ChatId = ChatId;
        this.PhoneNumber = PhoneNumber;
        this.Fullname = fullName;
        this.Studentname = Studentname;
    }
}