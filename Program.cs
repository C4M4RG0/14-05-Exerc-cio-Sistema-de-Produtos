using System;

namespace Catálogo_de_produtos
{
    class Program
    {
        static int array = 10;
        static string[] nome = new string[array];
        static float[] preco = new float[array];
        static bool[] desconto = new bool[array];
        static int cont = 0;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            int menu;
            do
            {
                Console.Write(@"
______________________________
||                          ||
||   O que deseja fazer?    ||
||__________________________||
||                          ||
||  1 - Cadastrar produtos  ||
||   2 - Listar produtos    ||
||         0 - Sair         ||
||__________________________||
Digite:  ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 0:
                        Console.WriteLine(@"Volte sempre!");
                        break;
                }

            } while (menu != 0);

        }
        static void CadastrarProduto()
        {

            int novoProduto;

                        do
                        {
                            Console.Write(@"
______________________________
||                          ||
||       Qual o nome        ||
||        do produto        ||
||__________________________||
Digite: ");
                            nome[cont] = Console.ReadLine();

                            Console.Write(@"
______________________________
||                          ||
||       Qual o preço       ||
||        do produto        ||
||__________________________||
Digite: ");
                            preco[cont] = float.Parse(Console.ReadLine());

                            Console.Write(@"
______________________________
||                          ||
||     O produto está       ||
||      em promoção?        ||
||__________________________||
||                          ||
||         1 - Sim          ||
||         0 - Não          ||
||__________________________||
Digite: ");
                            string resposta = Console.ReadLine();
                            if(resposta == "1"){
                            desconto[cont] = true;
                            }else{
                            desconto[cont] = false;
                            }
                            cont++;

                            Console.Write(@"
______________________________
||                          ||
||     Deseja cadastrar     ||
||       outro produto      ||
||__________________________||
||                          ||
||         1 - Sim          ||
||         0 - Não          ||
||__________________________||
Digite: ");
                            novoProduto = int.Parse(Console.ReadLine());
                        } while (novoProduto == 1);
        }
        static void ListarProdutos(){

            string promocao;

                        for (var i = 0; i < cont; i++)
                        {
                            if (desconto[i] == true)
                            {
                                promocao = "Sim";
                            }
                            else
                            {
                                promocao = "Não";
                            }
                            if (nome[i] != null)
                            {

                                Console.Write($@"
______________________________
||                          ||
||        Produto {i + 1}         || 
||__________________________||
||
||      Nome: {nome[i]}
||      Preço: {preco[i]:C2}
||      Em Promoção: {promocao}
||____________________________ ");
                            }
                        }
        }
    }
}
