namespace POOClase_WinForms.Exceptions
{
    public class NotParsedException : Exception
    {
        public NotParsedException() : base("No se pudo parsear el valor") { }
        public NotParsedException(string message) : base(message) { }
    }
}
