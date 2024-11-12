namespace POOClase_WinForms.Exceptions
{
    public class ValuesAreEqualException : Exception
    {
        public ValuesAreEqualException() : base("No pueden haber dos valores iguales") { }
        public ValuesAreEqualException(string? message) : base(message) { }
        public ValuesAreEqualException(string? message, string? field) : base(message + field) { }

    }
}
