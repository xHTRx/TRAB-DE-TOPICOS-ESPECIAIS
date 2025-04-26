/*Soma de Números Pares de um Array:
Peça ao usuário 10 números e armazene em um array. Depois, calcule a soma apenas
dos números pares.*/

int qtd = 10;
int[] numeros = new int[qtd];

for(int i = 0; i < qtd; i++){
    Console.Write("Digite um numero inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

int soma = 0;

foreach(int num in numeros){
    if(num % 2 == 0){
        soma += num;
    }
}

Console.WriteLine("A soma dos numeros pares digitados e: " + soma);

