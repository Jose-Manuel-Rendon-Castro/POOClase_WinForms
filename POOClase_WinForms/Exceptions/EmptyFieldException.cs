namespace POOClase_WinForms.Exceptions
{
    public class EmptyFieldException : Exception
    {
        public EmptyFieldException() : base("Ingrese un valor en el campo para continuar") { }
    }
}
