
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n1. Registrar Cliente Regular");
    Console.WriteLine("2. Registrar Cliente VIP");
    Console.WriteLine("3. Registrar Reserva");
    Console.WriteLine("4. Mostrar Detalles de Clientes");
    Console.WriteLine("5. Mostrar Detalles de Reservas");
    Console.WriteLine("6. Buscar Cliente por Nombre");
    Console.WriteLine("7. Buscar Reserva por Número");
    Console.WriteLine("8. Salir");
    Console.Write("\nSeleccione una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
         
            break;
        case 2:
         
            break;
        case 3:
          
            break;
        case 4:
       
            break;
        case 5:
       
            break;
        case 6:
   
            break;
        case 7:
            
            break;
        case 8:
            Console.WriteLine("Saliendo...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}