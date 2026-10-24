Console.Clear();

int resposta;

Console.WriteLine("-= Validador de entrada =-\n");

do {
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar): ");
    resposta = Convert.ToInt32(Console.ReadLine());
} while (resposta < 0 || resposta > 9);

if (resposta == 0) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nOperação cancelada.");
} else if (1 <= resposta && resposta <= 9) {
    Console.Write($"\nNúmero selecionado: ");

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(resposta);
}

Console.ResetColor();