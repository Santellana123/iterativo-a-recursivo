int num;
Console.WriteLine("Ingrese un número para calcular su potencia:");
num = int.Parse(Console.ReadLine());


int resultadoRecursivo = ElevarRecursivo(num, num);
Console.WriteLine($"El resultado de elevar {num} a la potencia {num} (recursivo) es: {resultadoRecursivo}");


int resultadoIterativo = Elevarinterativo(num, num);
Console.WriteLine($"El resultado de elevar {num} a la potencia {num} (iterativo) es: {resultadoIterativo}");

Console.ReadKey();

static int Elevarinterativo(int num, int exponente)
{
    int resultado = 1;

    for (int i = 0; i < exponente; i++)
    {
        resultado *= num;
    }

    return resultado;
}
int ElevarRecursivo(int num,int exponente) 
{
    if (exponente == 0)
    {
        return 1;
    }
    else
    {
       
        return num * ElevarRecursivo(num, exponente - 1);
    }

}

