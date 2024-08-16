using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_PA
{
    internal class Clientes
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }

        public Clientes(string nombre, string correo, string telefono, string tipo)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Tipo = tipo;
        }
        public void AgregarClientes(List<Clientes> clientesList) 
        {
                Console.Write("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el correo del cliente: ");
                string correo = Console.ReadLine();
                Console.Write("Ingrese el teléfono del cliente: ");
                string telefono = Console.ReadLine();
                Console.WriteLine("--- Tipo de Cliente ---");
            Console.WriteLine("1. Cliente VIP");
            Console.WriteLine("2. Cliente Regular");
            Console.Write("Ingrese una opción: ");
            int clientes = int.Parse(Console.ReadLine());
            string tipo = "";
            switch (clientes)
            {
                case 1:
                    tipo = "VIP";
                    break;
                case 2:
                    tipo = "Regular";
                    break;
                default:
                    Console.Write("Ingese una opción válida: ");
                        break;
            }

                clientesList.Add(new Clientes(nombre, correo, telefono, tipo));
                Console.WriteLine("Cliente registrado exitosamente.");            
        }
        public void Reserva(List<Reserva> ReservaList)
        {

        }
    }
}
