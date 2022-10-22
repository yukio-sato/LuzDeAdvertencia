Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
string frase = "Simulador de Luz de Advertência\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.Yellow;
frase = @"Responda as seguintes perguntas com ""Ativado"" ou ""Desativado""";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
frase = "Sensor de temperatura está ativado ou desativado? ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
string temperatura = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Cyan;
frase = "Sensor de pressão está ativado ou desativado? ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
string pressão = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Blue;
frase = "Sensor de rotação está ativado ou desativado? ";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
string rotação = Console.ReadLine()!;
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
frase = "Calculando resultados. . .\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    if (i < 22)
    Thread.Sleep(55);
    else
    Thread.Sleep(175);
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
frase = $"Sensor de temperatura: [{temperatura}]\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.DarkRed;
frase = $"Sensor de pressão:     [{pressão}]\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
frase = $"Sensor de rotação:     [{rotação}]\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
if (temperatura.Substring(0,1).Contains("a") || temperatura.Substring(0,1).Contains("A"))
{
    if ((pressão.Substring(0,1).Contains("a") || pressão.Substring(0,1).Contains("A")) || (rotação.Substring(0,1).Contains("d") || rotação.Substring(0,1).Contains("D")))
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    frase = $"A luz de advertência está ativada.\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
     frase = $"A luz de advertência está desativada.\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
    }
}
    else if (temperatura.Substring(0,1).Contains("d") || temperatura.Substring(0,1).Contains("D"))

    {
        Console.ForegroundColor = ConsoleColor.Red;
     frase = $"Temperatura está desativada.\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
    }
        else if (!(temperatura.Substring(0,1).Contains("d") || temperatura.Substring(0,1).Contains("D")) || (temperatura.Substring(0,1).Contains("a") || temperatura.Substring(0,1).Contains("A")))

    {
        Console.ForegroundColor = ConsoleColor.Red;
     frase = $"Utilize Ativado ou Desativado.\n";
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(55);
}
    }
    Console.ResetColor();