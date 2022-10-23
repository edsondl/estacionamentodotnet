namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string placa, decimal precoInicial)
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string p1 = placa.Substring(0,3).ToUpper();   //separa a string desejada de 0 até o indice 3 pegando os valores antes do fim(0 1 e 2)
            string p2 = string.Format("{0,5}",placa.Substring(3)) ; //separa a string a partir do indice 3 inclusive e depois formata o restante em um espaço de 5 caracteres
            string plc = $"{p1}-{p2}"; //junta tudo em uma nova string permitindo um novo formato (XXX-xxxxx)

            //esta linha faz o mesmo procedimento das 3 linhas acima
            string plc1= placa.Insert(3,"-").ToUpper();

            carro.Add(new Carro(){Placa = plc1, PrecoInicial = precoInicial });
        
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                 if (carro.Count == 0)
            {
                Console.WriteLine("Não existe veículo cadastrado");
                Console.WriteLine("... menu");
                return;
            }

            Console.WriteLine("SAÍDA DE VEÍCULOS");
            Console.Write("\nDigite a placa => : ");
            string? busca = Console.ReadLine();
            string plc = busca!.Insert(3,"-").ToUpper();

            //pesquisa o item pelo atributo Placa e descobre o indice
            int item = carro.FindIndex(0,i => i.Placa == plc);

            //indice de lista sempre começa em 0. Se não existir o indice , é pq a busca falhou.
            //Nesse caso, cai na condição else
            if (item >= 0)
            {
               decimal vlrTaxaInicial = carro[item].PrecoInicial;   
               Console.Write("\nQuantos minutos permaneceu no local=> : ");
               int minutos = Convert.ToInt32(Console.ReadLine()); 

               Console.Write("\nQual o valor do estacionamento por MINUTO => R$ ");
               precoPorHora = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\n Sistema ") ;
               Console.WriteLine(@$"O valor devido para o veículo de placa {carro[item].Placa}
                        é de R$ {vlrTaxaInicial+(precoPorHora * minutos)} ");
               Console.WriteLine("\nDeseja dar saída no veículo ?");
               Console.Write("Responda 'sim' ou 'não' => : ");

               if (Console.ReadLine() == "sim")
               {
                carro.RemoveAt(item); //remove pelo Indice atribuido acima 
                Console.Clear();
                Console.WriteLine($"O Veículo de placa ''{plc}'' foi REMOVIDO.");
                Console.Write("Retornado ao MENU...\n");
                return;
               }
               else
               {
                Console.Clear();
                Console.WriteLine($"\nO Veículo da placa '{plc}' NÃO será removido.");
                Console.WriteLine("\nPara remover Veículo, digite a opção 2 ");
                Console.WriteLine("Após os procedimentos responda 'sim'");
                return;
               }
            }
            else 
            {
             
            Console.WriteLine($"Escolha a opção 3 e verifique se a placa '{busca}' existe.");
            return;
            }


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Esse veículo não está estacionado.");
            }
        }

        public void ListarVeiculos(string usuario)
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                 if (carro.Count >=1)
            {                
             Console.WriteLine("\n Veículos estacionados\n");
             carro.ForEach(carro=>Console.WriteLine
              ($" > Placa {carro.Placa} valor inicial R$ {carro.PrecoInicial}"));
            }
            else
            {
                Console.WriteLine("Não existe veículo cadastrado !!!");
                Console.WriteLine($"{usuario} escolha a opção 1 ");                
            }
            }
            else
            {
                Console.WriteLine("Não há veículo estacionado.");
            }
        }
    }
}
