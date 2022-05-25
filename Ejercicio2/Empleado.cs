public class Empleado {

    private string nombre;
    private string apellido;
    public DateTime fechaNacimiento;

    public char estadoCivil;

    public char genero;

    public DateTime fechaIngreso;

    public double sueldo;

    public cargos cargo;

    public string Nombre { get => nombre ; set => nombre = value; }

    public string Apellido { get => apellido; set => apellido = value; }

    public Empleado(string nombreEmpleado, string apellidoEmpleado, DateTime fechaNacimientoEmpleado, DateTime fechaIngresoEmpleado){

        if(!string.IsNullOrEmpty(nombreEmpleado)) nombre = nombreEmpleado; else nombre = "";

        if(!string.IsNullOrEmpty(apellidoEmpleado)) apellido = apellidoEmpleado; else apellido = "";

        fechaNacimiento = fechaNacimientoEmpleado;

        fechaIngreso = fechaIngresoEmpleado;
        
    }

    public enum cargos {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public int antiguedad(){

        int currentYear = DateTime.Today.Year;

        int antiguedad = currentYear - fechaIngreso.Year;

        // Completar calculo de la antiguedad

        return antiguedad;

    }

    public int edad(){

        // Completar calculo de la edad
        int edad = 0;
        
        return edad;

    }



}