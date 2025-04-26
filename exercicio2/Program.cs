/*Tabuada Completa com Laço:
Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10),
utilizando um for*/

int num;
do{
    Console.Write("Digite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());
}while(num <= 0);

for(int i = 1; i <= 10; i++){
    Console.WriteLine(num  + " x " + i + " = " + num*i);
}