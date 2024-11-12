namespace POOClase_WinForms.Exceptions
{
    public class NotEmailException : Exception
    {
        public NotEmailException() : base("Ingrese un correo electrónico válido") { }
    }
}
