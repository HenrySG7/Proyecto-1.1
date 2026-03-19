Console.WriteLine("-----MENU GENERAL-----");
Console.WriteLine("Opcion 1. Evaluar nuevo contenido.");
Console.WriteLine("Opcion 2. Mostrar reglas del sistema.");
Console.WriteLine("Opcion 3. Mostrar estadisticas de la evaluacion.");
Console.WriteLine("Opcion 4. Reiniciar estadisticas.");
Console.WriteLine("Opcion 5. Salir del sistema.");
int opcion = int.Parse(Console.ReadLine());

string contenido;
double duracion;
int clasificacion;
double hora;
string produccion;
do
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el tipo de contenido (pelicula, serie etc)");
            contenido = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion del contenido en minutos: ");
            duracion = double.Parse(Console.ReadLine());
            Console.WriteLine("Clasificacion del contenido (+13) (+18)");
            clasificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese hora de programacion: ");
            hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nivel de produccion (Bajo, Medio, Alto");
            produccion = Console.ReadLine();

    }
}
while (opcion != 5);