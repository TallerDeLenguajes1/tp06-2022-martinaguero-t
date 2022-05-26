Console.WriteLine("2) Programa para el sistema de administracion: ");
Console.WriteLine("Información de los empleados de la empresa: ");
Console.WriteLine("=======================================");

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Pedro","Juarez",new DateTime(1988,5,24),'H',Empleado.ECivil.C,new DateTime(2007,5,24),65000,Empleado.Cargos.Especialista);

empleados[1] = new Empleado("Alicia","Paez",new DateTime(1995,8,05),'M',Empleado.ECivil.S,new DateTime(2018,6,20),50000,Empleado.Cargos.Administrativo);

empleados[2] = new Empleado("Marta","Perez",new DateTime(1977,4,15),'M',Empleado.ECivil.C,new DateTime(1996,5,24),80000,Empleado.Cargos.Ingeniero);

for (int i = 0; i < 3; i++)
{
    empleados[i].MostrarInfoEmpleado();
}

Console.WriteLine($"Para los tres empleados anteriores, se paga en total ${TotalSalarios(empleados)} en concepto de salarios. ");

Console.WriteLine("=======================================");

MostrarDatosEmpleadoMayorAntiguedad(empleados);

Console.Read();

// Métodos 

double TotalSalarios(Empleado[] arregloEmpleados){

    double totalSalarios = 0;

    foreach (Empleado empleado in arregloEmpleados)
    {
        totalSalarios+= empleado.Salario();
    }

    return totalSalarios;

}

void MostrarDatosEmpleadoMayorAntiguedad(Empleado[] arregloEmpleados){

    Empleado empleadoMayorAntiguedad = arregloEmpleados[0];

    foreach (Empleado empleado in arregloEmpleados)
    {
        if (empleadoMayorAntiguedad.Antiguedad() < empleado.Antiguedad())
        {
            empleadoMayorAntiguedad = empleado;
        }
    }

    Console.WriteLine("El/la empleado/a con mayor antiguedad es: ");

    empleadoMayorAntiguedad.MostrarInfoEmpleado();

    
}