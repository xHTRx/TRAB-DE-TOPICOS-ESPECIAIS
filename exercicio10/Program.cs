/*Lista de Tarefas (To-Do List):
Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas
inseridas. Use List<string> e ofereça uma opção para marcar tarefas como concluídas.*/

using System;
using System.Collections.Generic;

List<string> tarefas = new List<string>();

int opcao;

do{
    Console.WriteLine("1- Adicionar tarefa.\n2- Marcar tarefa como concluida.\n3- Sair.");
    Console.Write("Digite a opcao desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao){
        case 1:
            Console.Write("Digite o nome da tarefa: ");
            tarefas.Add(Console.ReadLine());
            Console.WriteLine("-----Tarefa adicionada com sucesso-----\n");
        break;
        case 2:
            Console.Write("Digite o nome da tarefa que deseja marcar como concluida: ");
            string tarefa = Console.ReadLine();

            if(tarefas.Contains(tarefa)){
                tarefas.Remove(tarefa);
                Console.WriteLine("-----Tarefa concluída e removida da lista-----\n");
            }
            else{
                Console.WriteLine("\n-----" + tarefa + " nao exite na lista-----\n");
            }
        break;
        case 3:
            Console.WriteLine("\nTarefas restantes na lista:");
            foreach (var t in tarefas){
                Console.WriteLine("-" + t);
            }
            Console.WriteLine("\n-----Saindo-----");
        break;
        default:
            Console.WriteLine("\nOpção inválida.\n");
        break;
    }
}while(opcao != 3);
