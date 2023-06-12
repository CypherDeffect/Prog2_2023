using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;
        public ClientView()
        {
            Init();
        }

        public void Init()
        {
        
            Console.WriteLine("*****************************");
            Console.WriteLine("VOCÊ ESTÁ EM CLIENTE");
            Console.WriteLine("********************************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Exportar Clientes");
            Console.WriteLine("4 - Importar Clientes");
            Console.WriteLine("");
            int option = 0;
            switch (option)
            {
                case 1 :
                    // aqui vai umas sentença
                    Insert();
                break;

                default:

                break;
            }
        }

        private void Insert()
        {
            Client client = new Client();
            client.Id = DataSet.clients.Count + 1;

            Console.WriteLine("Informe o primeiro nome:");
            client.FirtName = Console.ReadLine();

            Console.WriteLine("Informe o sobrenome:");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            client.CPF = Console.ReadLine();

            Console.WriteLine("Informe o e-mail:");
            client.Email = Console.ReadLine();

            
        }
    }
}