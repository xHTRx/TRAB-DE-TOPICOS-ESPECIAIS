/*Jogo da Adivinhação:
Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
tentativa, informe se o número é maior ou menor. Conte o número de tentativas.*/

Random rand = new Random();
int numero = rand.Next(1, 101);

int tentativa;
int soma = 1;

do{
    Console.Write("Digite um numero para adivinhar o sorteado: ");
    tentativa = Convert.ToInt32(Console.ReadLine());

    if(tentativa == numero){
        Console.WriteLine("Parabens!!!!Voce acertou na tentativa: " + soma + "!!!!\n");
    }
    else{
        if(tentativa > numero){
            Console.WriteLine("O numero e menor.");
        }
        else{
            Console.WriteLine("O numero e maior.");
        }

        Console.WriteLine("- Tentativa: " + soma + "\n");

        soma++;
    }

}while(tentativa != numero);
