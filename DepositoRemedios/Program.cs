using System;
using System.Collections.Generic;

namespace DepositoRemedios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //LISTA 

            List<Medicine> list = new List<Medicine>(); 
            Medicine med1 = new Medicine();
            Medicine med2 = new Medicine();
            Medicine med3 = new Medicine();

            Medicine medData = new Medicine();

            MedicineController med = new MedicineController();


            //TESTE ENCAPSULAMENTO

          /*  //med1
            med1.Name = "Paracetamol";
            med1.Price = 12.50;
            med1.Quant = 20;
            list.Add(med1);
            //med2
            med2.Name = "Fluoxetina";
            med2.Price = 26.90;
            med2.Quant = 85;
            list.Add(med2);
            //med3
            med3.Name = "Buscopan";
            med3.Price = 8.00;
            med3.Quant = 150;
            list.Add(med3);*/

            int indic; //indice

            //input
            bool aux = true;
            while (aux == true)
            {
                DateTime tNow = DateTime.Now;
                Console.WriteLine(tNow);
              

                Console.WriteLine("LISTA DE REMÉDIOS:");

                Console.WriteLine("(1) - ADICIONAR REMÉDIO");
                Console.WriteLine("(2) - REMOVER REMÉDIO");
                Console.WriteLine("(3) - VER LISTA DE REMÉDIOS");
                Console.WriteLine("(4) - VER O PREÇO DOS REMÉDIOS");
                Console.WriteLine("(5) - VER A QUANTIDADE EM ESTOQUE");
                Console.WriteLine("(6) - ATUALIZAR O PREÇO DO REMEDIO");
                Console.WriteLine("(7) - ATUALIZAR A QUANTIDADE EM ESTOQUE");
                Console.WriteLine("(0) - CANCELAR");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 1:
                        
                        Console.WriteLine("Digite o nome do remédio: ");                      
                        medData.Name = Console.ReadLine();

                        Console.WriteLine("Digite o preço do remédio: ");  
                        medData.Price = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade para estoque: ");
                        medData.Quant = int.Parse(Console.ReadLine());
                       
                        list.Add(medData); 
                        break;

                    case 2:
                        Console.WriteLine("Digite o numero do indice do remédio que deseja remover");
                        indic = int.Parse(Console.ReadLine());
                        list.RemoveAt(indic);
                        indic = 0;
                        break;

                    case 3:
                        Console.WriteLine("NOME DO REMÉDIO");
                        foreach (Medicine medi in list)
                        {
                            Console.WriteLine(medi.Name);
                        }
                        break;


                    case 4:
                        Console.WriteLine("NOME DO REMÉDIO \t PREÇO DO REMÉDIO");
                        foreach (Medicine medi in list)
                        {
                            Console.WriteLine(medi.Name + "\t\t\t" + medi.Price);
                        }
                            break;

                    case 5:
                        Console.WriteLine("NOME DO REMÉDIO \t QUANTIDADE EM ESTOQUE");
                        foreach (Medicine medi in list)
                        {
                            Console.WriteLine(medi.Name + "\t\t\t" + medi.Quant);
                        }
                            break;

                    case 6:
                        Console.WriteLine("Digite o numero do remédio que deseja atualizar o preço: ");
                        indic = int.Parse(Console.ReadLine()); 
                        Console.WriteLine("Digite o novo preço: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        list[indic].Price = newPrice;

                        //med1.UpdatePrice(newPrice, indic);    //não utilizar metodos
                        Console.WriteLine($"Preço do remédio atualizado para {list[indic].Price}.");
                        indic = 0;
                        break;

                    case 7:
                        Console.WriteLine("Digite o numero do remédio que deseja atualizar a quantidade: ");
                        indic = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade atualizada: ");
                        int newQuant = int.Parse(Console.ReadLine());
                        list[indic].Quant = newQuant;
                        Console.WriteLine($"Quantidade do remédio atualizada para {list[indic].Quant}.");
                        indic = 0;
                        break;

                    case 0:
                        Console.Clear();
                        aux = false;
                        break;
                }


            }

        }
 
    }
}
