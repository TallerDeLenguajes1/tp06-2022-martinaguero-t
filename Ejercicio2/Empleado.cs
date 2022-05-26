public class Empleado {

    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;

    private char estadoCivil;

    private char genero;

    private DateTime fechaIngreso;

    private double sueldo;

    private Cargos cargo;

    // Constructor
    public Empleado(string nombreEmpleado, string apellidoEmpleado, DateTime fechaNacimientoEmpleado, char generoE, ECivil estadoCivilEmpleado, DateTime fechaIngresoEmpleado, double sueldoBasicoEmpleado, Cargos cargoEmpleado){

        if(!string.IsNullOrEmpty(nombreEmpleado)) nombre = nombreEmpleado; else nombre = "";

        if(!string.IsNullOrEmpty(apellidoEmpleado)) apellido = apellidoEmpleado; else apellido = "";

        fechaNacimiento = fechaNacimientoEmpleado;

        fechaIngreso = fechaIngresoEmpleado;
        
        sueldo = sueldoBasicoEmpleado;

        genero = generoE;

        cargo = cargoEmpleado;

        estadoCivil = (char) estadoCivilEmpleado;
    }

    public enum ECivil {
        S = 'S',
        C = 'C',
        D = 'D',
        V = 'V'
    }

    public enum Cargos {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    // Métodos
    public int Antiguedad(){

        int antiguedad = DateTime.Now.Year - fechaIngreso.Year;

         if((DateTime.Now.Month == fechaIngreso.Month && DateTime.Now.Day < fechaIngreso.Day) || DateTime.Now.Month < fechaIngreso.Month) antiguedad--;

        return antiguedad;

    }

    public int Edad(){

        int edad = DateTime.Now.Year - fechaNacimiento.Year;

        if((DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day) || DateTime.Now.Month < fechaNacimiento.Month) edad--;
      
        return edad;

    }

    public double Salario(){

        double adicional = 0;

        if(Antiguedad() < 20){
            adicional = sueldo * (Antiguedad()*0.01);
        } else {
            adicional = sueldo * 0.25;
        }

        if(cargo == Cargos.Ingeniero || cargo == Cargos.Especialista){
            adicional += adicional*0.5;
        }

        if(estadoCivil == 'C'){
            adicional += 15000;
        }

        return sueldo + adicional;

    }

    public void MostrarInfoPersonalEmpleado(){
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento.ToString("dd-MM-yyyy") + $" (edad: {Edad()} años) ");
        Console.WriteLine("Genero: " + genero);
        Console.WriteLine("Estado Civil: " + estadoCivil);
    }

    public void MostrarInfoLaboralEmpleado(){
        Console.WriteLine("Fecha de ingreso: " + fechaIngreso.ToString("dd-MM-yyyy") + $" (antiguedad: {Antiguedad()} años) ");
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Sueldo básico: $" + sueldo);
        Console.WriteLine("Salario: $" + Salario());
    }

    public void MostrarInfoEmpleado(){

        Console.WriteLine("-> Información personal: ");
        MostrarInfoPersonalEmpleado();
        Console.Write("\n");
        Console.WriteLine("-> Información laboral: ");
        MostrarInfoLaboralEmpleado();
        Console.WriteLine("=======================================");
    }
   


}