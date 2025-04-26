/*Verificador de Palíndromos:
Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo
(lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos)*/

Console.Write("Digite uma palavra ou uma frase: ");
string? palavra = Console.ReadLine();
string palindromo = "";

if (string.IsNullOrEmpty(palavra)) {
    Console.WriteLine("Você não digitou nada.");
    return;
}

    string texto = palavra.ToLower().Replace(" ", "");
    for (int i = texto.Length - 1; i >= 0; i--){
        palindromo += texto[i];
    }


Console.Write("Palavra ou frase: " + palavra);
Console.Write("\nPalindromo: " + palindromo);

if(texto == palindromo){
    Console.WriteLine("\nA palavra e um palindromo.");
}
else{
    Console.WriteLine("\nA palavra nao e um palindromo.");
}