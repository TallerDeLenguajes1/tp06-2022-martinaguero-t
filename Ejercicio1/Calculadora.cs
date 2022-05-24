public class Calculadora{

    public double resultado;

    // Constructor
    public Calculadora(double valorInicial){
        resultado = valorInicial;
    }

    // Métodos
    public void Sumar(double sumando){
        resultado += sumando;
    }

    public void Restar(double sustraendo){
        resultado -= sustraendo;
    }

    public void Multiplicar(double factor){
        resultado *= factor;
    }

    public void Dividir(double divisor){

        if(divisor != 0){
            resultado /= divisor;
        } else {
            Console.WriteLine("No se puede dividir en 0!");
        }

    }

    public void Limpiar(){
        resultado = 0;
    }

}