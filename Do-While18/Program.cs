Console.WriteLine("Menú repetitivo");
int opciones;
do
{
    Console.WriteLine("1. Saluddar");
    Console.WriteLine("2. Mostrar número aleatorio");
    Console.WriteLine("0. Salir");
    opciones = int.Parse(Console.ReadLine());

    switch (opciones)
    {
        case 1:
            Console.WriteLine("Hola!!");
            break;
        case 2:
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            Console.WriteLine($"Número aleatorio: {numeroAleatorio}");
            break;

        case 3:
            Console.WriteLine("Saliendo...");
            break;


    }
}
while (opciones != 0);