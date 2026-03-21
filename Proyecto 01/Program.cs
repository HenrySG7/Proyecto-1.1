class Program
{
    static void Main()
    {
        int opcion;

        // Estadisticas para ir guardando la info
        int total = 0, publicados = 0, rechazados = 0, revision = 0;

        do
        {
            Console.WriteLine("----- MENU GENERAL -----");
            Console.WriteLine("1. Evaluar nuevo contenido");
            Console.WriteLine("2. Mostrar reglas");
            Console.WriteLine("3. Mostrar estadisticas");
            Console.WriteLine("4. Reiniciar estadisticas");
            Console.WriteLine("5. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // VARIABLES
                    string contenido;
                    int duracion;
                    string clasificacion;
                    int hora;
                    string produccion;

                    Console.WriteLine("Tipo (pelicula, serie, documental, evento): ");
                    contenido = Console.ReadLine().ToLower();

                    Console.WriteLine("Duracion: ");
                    duracion = int.Parse(Console.ReadLine());

                    Console.WriteLine("Clasificacion (todo, +13, +18): ");
                    clasificacion = Console.ReadLine().ToLower();

                    Console.WriteLine("Hora (0-23): ");
                    hora = int.Parse(Console.ReadLine());

                    Console.WriteLine("Produccion (bajo, medio, alto): ");
                    produccion = Console.ReadLine().ToLower();

                    total++;

                    // VALIDACION
                    bool valido = true;

                    // CLASIFICACION Y HORA 
                    if (clasificacion == "+13")
                    {
                        if (hora < 6 || hora > 22)
                            valido = false;
                    }
                    else if (clasificacion == "+18")
                    {
                        if (!(hora >= 22 || hora <= 5))
                            valido = false;
                    }

                    // DURACION
                    if (valido)
                    {
                        if (contenido == "pelicula" && (duracion < 60 || duracion > 180))
                            valido = false;
                        else if (contenido == "serie" && (duracion < 20 || duracion > 90))
                            valido = false;
                        else if (contenido == "documental" && (duracion < 30 || duracion > 120))
                            valido = false;
                        else if (contenido == "evento" && (duracion < 30 || duracion > 240))
                            valido = false;
                    }

                    // PRODUCCION
                    if (valido)
                    {
                        if (produccion == "bajo" && clasificacion == "+18")
                            valido = false;
                    }

                    if (!valido)
                    {
                        Console.WriteLine("RECHAZADO");
                        rechazados++;
                        break;
                    }

                    // IMPACTO
                    string impacto;

                    if (produccion == "alto" || duracion > 120 || (hora >= 20 && hora <= 23))
                        impacto = "alto";
                    else if (produccion == "medio" || (duracion >= 60 && duracion <= 120))
                        impacto = "medio";
                    else
                        impacto = "bajo";

                    // DECISION FINAL
                    if (impacto == "alto")
                    {
                        Console.WriteLine("En revision");
                        revision++;
                    }
                    else
                    {
                        Console.WriteLine("Publicado");
                        publicados++;
                    }

                    break;
            }
    