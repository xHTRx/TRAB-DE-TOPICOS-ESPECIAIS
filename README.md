# Trabalho de Tópicos Especiais - Lista de Exercicios em C#

## NOME DOS INTEGRANTES: 
 - Bruna Mara Jung
 - Heitor Augusto Andrade
 - Jhanny Aparecida Rebeiko Pianovski


## Explicação breve sobre cada exercicio:

**1. Validador de Senhas Fortes:**
O programa solicita que o usuário digite uma senha e realiza uma validação completa, exigindo um comprimento mínimo de 8 caracteres, pelo menos uma letra maiúscula, um número e um caractere especial (como !, @, #, etc.). Se algum critério não for atendido, o sistema informa exatamente o que está faltando.

**2. Tabuada Completa com Laço:**
Neste exercício, o usuário fornece um número e em seguioda o programa imprime a tabuada
de 1 a 10 do numero, utilizando um laço *for*.

**3. Cálculo de Fatorial com while:**
O programa solicita um número inteiro positivo ao usuário e, utilizando um laço *while*, calcula o fatorial do número, multiplicando-o sucessivamente até chegar a 1.

**4. Conversor de Temperaturas com Menu:**
Aqui, o programa apresenta um menu com três opções: converter de Celsius para
Fahrenheit, de Fahrenheit para Celsius ou sair. Um *switch* é utilizado para lidar
com a escolha do usuário, e um *while* mantém o menu em execução até que o
usuário decida sair.

**5. Verificador de Palíndromos:**
O usuário digita uma palavra ou frase, e o programa verifica se ela é um
palíndromo, ou seja, se é lida da mesma forma de frente para trás e de trás para
frente, desconsiderando espaços, letras maiúsculas e acentos.

**6. Cadastro Simples de Produtos:**
Este exercício utiliza uma classe Produto, com propriedades como nome, preço e
quantidade. O usuário pode cadastrar 3 produtos, e o programa exibe uma lista
com o valor total de cada item em estoque (preço × quantidade).

**7. Soma de Números Pares de um Array:**
O usuário insere 10 números que são armazenados em um *array*. O programa
percorre esse *array* e calcula a soma apenas dos números pares.

**8. Cálculo de IMC com Classificação:**
O programa pede o peso (em kg) e a altura (em metros) do usuário, calcula o
Índice de Massa Corporal (IMC), que é definido pela divisão de peso por altura, e
classifica o resultado em: abaixo do peso, peso normal, sobrepeso ou obesidade.

**9. Jogo da Adivinhação:**
Um número aleatório entre 1 e 100 é gerado pelo programa. O usuário deve tentar
adivinhar esse número, recebendo dicas se ele deve chutar mais alto ou mais
baixo, até acertar. O número de tentativas é contado.

**10. Lista de Tarefas (To-Do List):**
Neste exercício, o usuário pode adicionar tarefas a uma lista, marcar tarefas como concluídas (removendo-as da lista) e visualizar todas as tarefas restantes ao encerrar o programa. Utiliza uma *List<string>* para armazenar os dados e um *switch* para as opções do menu.

#Descrições Detalhadas dos dois exercicios:


##Exercício 03 – Calculando fatorial

Contexto inicial: Este é um programa que calcula o fatorial de um número inteiro não negativo, que é a multiplicação desse número por todos os números inteiros positivos menores que ele, até chegar ao número 1 (Ex: O fatorial de 5 é: 5×4×3×2×1=120).

O código escrito em C#, possui uma estrutura simples e bem definida, dividida em blocos lógicos que trabalham juntos para atingir o objetivo de fazer o cálculo, utilizando while e do-while. Na primeira linha, o código declara uma variável inteira (int) chamada num, sendo essa a variável que será utilizada futuramente para armazenar o número que o usuário digitar. Logo em seguida, é utilizada uma estrutura do { ... } while (num <= 0), criando um loop que garante que o programa continue pedindo um número até que o usuário digite um valor positivo (maior que zero), se a condição for verdadeira (numero menor ou igual a zero), o loop volta ao início e pede para o usuário digitar outro número. Esse processo se repete até que um número positivo seja inserido. Neste bloco do-while possui uma linha de código “Console.Write("Digite um numero: ");”, essa linha exibe a mensagem na tela, solicitando que o usuário digite um número, que é lido pelo “num = Convert.ToInt32(Console.ReadLine());” (lê a entrada do usuário que no código é inicialmente um texto, e converte-a para um número inteiro (Convert.ToInt32(...)), armazenando o resultado na variável num citada anteriormente), sendo esta leitura do teclado que irá manter o ciclo de repetição.

Após o usuário digitar um número positivo (armazenado em num), essa linha declara e inicializa outra variável inteira chamada de “fato”. O valor inicial de “fato” é o número digitado menos 1. Essa variável desempenhará o papel de multiplicador no cálculo do fatorial. Por exemplo, se num for 5, fato começará com 4. Em seguida, a estrutura while(fato > 0) { ... } inicia um loop que continua enquanto o valor da variável “fato” for maior que zero. Dentro desse loop, o cálculo do fatorial é realizado. No bloco while, o comando “num *= fato”, é uma forma abreviada de escrever “num = num * fato” (conhecido como acumulador). Ela pega o valor atual de num e o multiplica pelo valor atual de fato, armazenando o resultado de volta em num. A cada iteração do while, num vai acumulando o produto dos números necessários para o fatorial. Em “fato--” após a multiplicação, essa linha decrementa o valor de “fato” em 1. Isso faz com que, na próxima iteração do loop, num seja multiplicado pelo próximo número menor. O loop continua, finalizando quando “fato” chegar a 0.

Após todo este processo, e a saída dos loops, é feita a exibição final do resultado do cálculo, o comando “Console.WriteLine("O fatorial do número e: " + num)”, nessa mensagem, possui uma concatenação (“texto informativo” + variável), é ela que irá mostrar o resultado final do cálculo do fatorial de forma organizada, lembrando que todo este processo acontece de forma sequencial, sendo ele linha a linha, então, enquanto não ocorrer a finalização devida e correta dos loop, a próxima linha de comando fora da repetição não será executada.



##Exercício 9 - Jogo de Adivinhação

Contexto inicial: O código foi escrito na linguagem de programação C#, com o objetivo de simular um jogo de adivinhação, no qual o computador sorteia um número entre 0 e 100 e o usuário tenta adivinhar esse número através de palpites, e a cada palpite o computador responde se o número digitado pelo usuário é maior ou menor do que o número sorteado pelo computador, a cada tentativa o computador marca o número de tentativas usadas pelo usuário até o acerto.

  Logo ao início o programa cria uma instância da classe Random com o comando Random rand = new Random(1, 101); permitindo a geração de números aleatórios. Em seguida, é utilizado o método rand.next(1, 101) para gerar um número aleatório entre 1 e 100, armazenando-o na variável inteira chamada número, que representa o número a ser adivinhado pelo jogador.
  
  Após essa inicialização, são declaradas duas outras variáveis inteiras: tentativa, que será utilizada para armazenar  valor digitado pelo usuário a cada palpite, e soma, que terá a função de contar o número de tentativas realizadas no jogo.

  O jogo então entra em um laço de repetição do-while, seguindo a seguinte estrutura do-while(tentativa != número). Esse laço de repetição garante que o programa continue pedindo novos palpites enquanto a variável tentativa for diferente do número sorteado. Dentro do do, primeiramente é exibida a mensagem Console.Write(“Digite um número:” ), solicitando que o usuário insira seu palpite.  Em seguida, a entrada é lida com o comando tentativa = Convert.ToInt32(Console.ReadLine()) que converte o valor digitado em string(texto) para um número inteiro e o armazena na variável tentativa.

  Após o usuário digitar um número, o programa faz uma comparação entre tentativa e número utilizando a estrutura if-else. Se a variável tentativa for igual ao número  sorteado, significa que o usuário acertou o número sorteado. Se a variável tentativa for menor que a variável número, o programa exibe a mensagem dizendo que o número sorteado é maior. Se a variável tentativa for  maior que o número sorteado, o programa exibe a mensagem dizendo que o número sorteado é menor.

  Após cada palpite errado, o contador de tentativas (variável soma) é incrementado com o comando soma ++. Esse processo de palpite, comparação e incremento continua até que o jogador acerte o número sorteado.
  Após o jogador acertar, o programa exibe uma mensagem de parabéns, seguida do número de tentativas usadas, utilizando o comando Console.WriteLine(“Parabéns! Você acertou na tentativa “ + soma”!!!”), onde ocorre uma concatenação entre texto e variável, organizado de maneira clara a resposta final ao jogador.
  Todo o processo acontece de maneira sequencial, linha por linha, sendo que a próxima linha fora do laço do-while somente será executada após o encerramento correto da repetição , o que garante a lógica e o fluxo natural do jogo.
