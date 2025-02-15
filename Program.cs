Enunciado 1
    string usuarioCorrecto = "Luis";
string contraseñaCorrecta = "1234";

Console.Write("Ingresa tu nombre de usuario: ");
string usuario = Console.ReadLine();

Console.Write("Ingresa tu contraseña: ");
string contraseña = Console.ReadLine();


if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
{
    Console.WriteLine("Acceso concedido");
}
else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Usuario no registrado");
}

Enuciado 2
            Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());


        string categoria;
        if (edad < 12)

        {categoria = "Niño";}
        else if (edad >= 12 && edad <= 17)

        {categoria = "Adolescente";}

        else if (edad >= 18 && edad <= 59)
        {categoria = "Adulto";}

        else
        {categoria = "Adulto mayor";}
        Console.WriteLine($"Tu categoría es: {categoria}");

enunciado 3
string usuarioCorrecto = "Luis";
string contraseñaCorrecta = "1234";

Console.Write("Ingresa tu nombre de usuario: ");
string usuario = Console.ReadLine();

Console.Write("Ingresa tu contraseña: ");
string contraseña = Console.ReadLine();


if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
{
    Console.WriteLine("Acceso concedido");
}
else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Usuario no registrado");
}

