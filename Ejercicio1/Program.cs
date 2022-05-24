Console.WriteLine("1) Programa trabajando con la calculadora: \n");
int seguirUsandoCalculadora = 1, numOperacion = 0;
double operando = 0;

Calculadora CalcUsuario = new Calculadora(0);

do
{
    Console.WriteLine("Ingrese la operación a realizar: ");

    do
    {
        Console.WriteLine("1) Sumar \n2) Restar \n3) Multiplicar \n4) Dividir \n5) Limpiar calculadora");
        numOperacion = Convert.ToInt32(Console.ReadLine());

    } while (numOperacion < 1 || numOperacion > 5);

    if(numOperacion < 5){

        do
        {
            Console.WriteLine("Ingrese el número con el cual se operará: ");
        } while (!double.TryParse(Console.ReadLine(), out operando));

    }

    switch (numOperacion)
    {
        case 1:
            CalcUsuario.Sumar(operando);
            break;
        case 2:
            CalcUsuario.Restar(operando);
            break;
        case 3:
            CalcUsuario.Multiplicar(operando);
            break;
        case 4:
            CalcUsuario.Dividir(operando);
            break;
        case 5:
            CalcUsuario.Limpiar();
            break;
    }

    Console.WriteLine("El resultado es: " + CalcUsuario.resultado);
    
    do
    {
        Console.WriteLine("¿Desea seguir realizando operaciones?");
        seguirUsandoCalculadora = Convert.ToInt32(Console.ReadLine());

    } while (seguirUsandoCalculadora < 0 || seguirUsandoCalculadora > 1);

} while (seguirUsandoCalculadora == 1);


Calculadora Calculadora1 = new Calculadora(10);
Console.WriteLine("Se inicializa resultado en Calculadora1 con 10: " + Calculadora1.resultado);

Calculadora1.Sumar(20);
Console.WriteLine("Se suma 20: " + Calculadora1.resultado);

Calculadora1.Dividir(3);
Console.WriteLine("Se divide en 3: " + Calculadora1.resultado);

