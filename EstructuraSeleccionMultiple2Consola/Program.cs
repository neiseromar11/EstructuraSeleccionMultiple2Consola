// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese que categoria desea: "
    +"\n1: Categoria 3 estrellas"
    +"\n2: Categoria 5 estrellas");
int categoria=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese los dias que desea la estadia: ");
float estadia=float.Parse(Console.ReadLine());

float costo = 0.0f;
switch (categoria) {
    case 1:
        if (estadia >= 11)
        {
            costo = 70;

        }
        else if (estadia <= 10 && estadia>=6)
        {
            costo = 85;
        }
        else {
            costo = 100;
        }

        
        break;
    case 2:
        if (estadia >= 11)
        {
            costo = 250;

        }
        else if (estadia <= 10 && estadia >= 6)
        {
            costo = 270;
        }
        else
        {
            costo = 300;
        }


        break;

    default:
        Console.WriteLine("Ingrese opciones validas");
        break;

}
float total = estadia * costo;
float desayuno = estadia * 7;
float totalneto = total + desayuno;
Console.WriteLine("El total por su estadia es: "+total
    +"\nAgregamos el desayuno "+desayuno
    +"\nTotal a pagar: "+totalneto);