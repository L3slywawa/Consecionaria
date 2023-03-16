namespace Consecionaria;
class Menu
{
    Conse Consecionaria = new Conse(10);
    public bool ShowMenu()
    {

        Console.Clear();
        Console.WriteLine("\t selecione");
        Console.WriteLine("1--agregar auto");
        Console.WriteLine("2--eliminar");
        Console.WriteLine("3--buscar");
        Console.WriteLine("4--listar todos");
        Console.WriteLine("5--salir");

        switch (Console.ReadLine())
        {
            case "1":
                //Console.WriteLine("seleccionaste 1");
                agregarAutomovil();
                Console.ReadLine();
                return true;

            case "2":
                Console.WriteLine("seleccionaste 2");
               
                Console.ReadLine();
                return true;
            case "3":
                Console.WriteLine("seleccionaste 3");
                Console.ReadLine();
                return true;

            case "4":
                Console.WriteLine("seleccionaste ");
                Console.ReadLine();
                return true;

            case "5":
                return false;

            default:
                return true;

        }
    }
    public void agregarAutomovil()
    {
        Console.Clear();
        Console.WriteLine("creando nuevo auto..");
        Console.WriteLine("ID: ");
        string? id = Console.ReadLine();
        Console.Write("marca: ");
        string? marca = Console.ReadLine();

        Console.Write("modelo: ");
        string? modelo = Console.ReadLine();

        Console.Write("km: ");
        string? km = Console.ReadLine();

        Console.Write("precio: ");
        string? precio = Console.ReadLine();

        Automovil nuevo = new Automovil(
                id,
                marca,
                modelo,
                int.Parse(km),
                double.Parse(precio)
                );
        Consecionaria.AgregarAuto(nuevo);
        Console.WriteLine("automovil agregado correctamente");


    }
}