namespace NameChangedEvent
{
	public class Person
	{
        private string name; // Eski değeri tutar

        public string Name
        {
            get => name;
            set
            {
                // Eğer yeni değer eski değerden farklıysa, önceki değeri kontrol eden ve yeni değeri atayan event'i tetikle
                if (value != name)
                {
                    OnNameChanged(name, value);
                    name = value;
                }
            }
        }

        // NameChanged event'i
        public event EventHandler<NameChangedEventArgs> NameChanged;

        // Event'i tetikleyen yardımcı metod
        protected virtual void OnNameChanged(string oldName, string newName)
        {
            NameChanged?.Invoke(this, new NameChangedEventArgs(oldName, newName));
        }
    }
}

// NameChanged event'inin veri yapısı
public class NameChangedEventArgs : EventArgs
{
    public string OldName { get; }
    public string NewName { get; }

    public NameChangedEventArgs(string oldName, string newName)
    {
        OldName = oldName;
        NewName = newName;
    }
}