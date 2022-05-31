using LibreriaEvaluacion.DAL;
using LibreriaEvaluacion.DTO;

const string nombreAlumno = "Carlos Calcina";


while (Menu(nombreAlumno))
{
    Console.ReadKey(); // pausa, solicitar la entrada de una tecla
}


static bool Menu(string nombreAlumno)
{ 
    bool continuar = true;

    Console.Clear(); // Limpia la pantalla
    Console.Title = $"Evaluación II: {nombreAlumno}";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1) Listar préstamos");
    Console.WriteLine("2) Agregar préstamo");
    Console.WriteLine("3) Actualizar préstamo");
    Console.WriteLine("4) Eliminar préstamo");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");

    string opcion = Console.ReadLine().Trim(); // " 1 " => "1"

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Listado de préstamos registrados");
            // ToDo: Lógica GUI de listado
            OpcionListar();
            break;
        case "2":
            Console.WriteLine("Insertar un nuevo préstamo");
            // ToDo: Lógica GUI de inserción
            OpcionInsertar();
            break;
        case "3":
            Console.WriteLine("Actualizar un préstamo existente");
            // ToDo: Lógica GUI de actualización
            OpcionActualizar();
            break;
        case "4":
            Console.WriteLine("Eliminar un préstamo existente");
            // ToDo: Lógica GUI de eliminación
            OpcionEliminar();
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    return continuar;
}

// ToDo: lógica de GUI
static void OpcionListar()
{

}

static void OpcionInsertar()
{
    PrestamoDAL prestamoDal = new PrestamoDAL();

    try
    {
        Console.WriteLine("Ingrese ID:");
        int id = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Ingrese monto:");
        int monto = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Ingrese monto mas el interes:");
        int montomasinteres = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Ingrese monto mas atraso:");
        int montomasatraso = int.Parse(Console.ReadLine().Trim());

        PrestamoDTO nuevoPrestamo = new PrestamoDTO()
        {
            Id = id,
            Monto = monto
        };

        bool resultadoInsertar = prestamoDal.Insertar(nuevoPrestamo); 

        if (resultadoInsertar)
        {
            Console.WriteLine($"Se ha insertado el monto {nuevoPrestamo.Monto} exitosamente");
        }
        else
        {
            Console.WriteLine($"Hubo un error al insertar el monto {nuevoPrestamo.Monto}");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Por favor ingrese datos válidos para el nuevo monto");
    }

    Console.ReadKey();
}

static void OpcionActualizar()
{

}

static void OpcionEliminar()
{
    PrestamoDAL prestamoDAL = new PrestamoDAL();

    Console.WriteLine("Ingrese el id que desea eliminar:");
    int id = int.Parse(Console.ReadLine().Trim());
}