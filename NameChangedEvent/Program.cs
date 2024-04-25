using NameChangedEvent;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Event'e bir handler ekleme
        person.NameChanged += PersonNameChanged!;
        person.Name = "Mert"; // Default boş geldiği için ek burada da çalışacak
        person.Name = "Mert Can";
    }

    // Event handler metodu
    private static void PersonNameChanged(object sender, NameChangedEventArgs e)
    {
        Console.WriteLine($"İsim değiştirildi, eski değer: '{e.OldName}', yeni değer: '{e.NewName}'.");
    }
}