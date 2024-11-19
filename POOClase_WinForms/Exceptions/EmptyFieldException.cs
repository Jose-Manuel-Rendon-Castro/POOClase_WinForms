namespace POOClase_WinForms.Exceptions
{
    public class EmptyFieldException : Exception
    {
        public EmptyFieldException() : base("Llene los campos obligatorios para continuar") { }
    }
}
