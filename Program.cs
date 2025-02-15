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
