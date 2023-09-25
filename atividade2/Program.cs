decimal numero1, numero2, numero3, numeroMaior=0, numeroMenor=0, numero=0;


Console.WriteLine("digite um numero ");
numero1 = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("digite um numero ");
numero2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("digite um numero ");
numero3 = Convert.ToDecimal(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    numeroMaior = numero1;

}
else
{
    if (numero1 < numero2 && numero2 > numero3)
    {
        numeroMaior = numero2;
    }
    if (numero3 > numero2 && numero3 > numero1)
    {
        numeroMaior = numero3;
    }
    if(numero1<numero2&&numero1<numero3)
    {
        numeroMenor= numero1;
    }
    if (numero1 > numero2 && numero2 < numero3)
    {
        numeroMenor = numero2;
    }
    if(numero1>numero3 && numero3 < numero2) {
        numeroMenor = numero3;
    }
    if(numero1 > numero2&& numero3>numero2)
    {
        numero = numero3;
    }
    if (numero2 < numero3 && numero1 > numero2)
    {
        numero = numero1;
    }
    if (numero3 > numero1 && numero2 > numero1)
    {
        numero = numero2;
    }
   
}

Console.WriteLine(+numeroMaior+ "," + numero +"," + numeroMenor);


