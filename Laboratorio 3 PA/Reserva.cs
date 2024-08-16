using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3_PA
{
    internal class Reserva
    {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public string  Hora { get; set; }
        public List<Plato> Plato { get; set; }

        public Reserva(int iD, string fecha, string hora, List<Plato> plato)
        {
            ID = iD;
            Fecha = fecha;
            Hora = hora;
            Plato = plato;
        }
        public void RegistrarReserva(List<Clientes> clientesList, List<Plato> platoList)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            Clientes clienteFind = clientesList.Find(c => c.Nombre == nombreCliente);

            if (clienteFind == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                return;
            }
            else
            {

            AgregarPlato()


                reservas.Add(reserva);
                Console.WriteLine("Reserva registrada exitosamente.");
            }
        }
        public void AgregarPlato(List<Plato> platoList)
        {
            bool agregarPlatos = true;
            while (agregarPlatos)
            {
                Console.Write("Ingrese el nombre del plato: ");
                string nombrePlato = Console.ReadLine();
                Console.Write("Ingrese el precio del plato: ");
                double precioPlato = double.Parse(Console.ReadLine().ToLower());
                if (precioPlato <= 0)
                {
                    Console.WriteLine("Precio no válido.");
                }
                else
                {
                    platoList.Add(new Plato(nombrePlato, precioPlato));
                }
                Console.Write("¿Desea agregar otro plato? (s/n): ");
                agregarPlatos = Console.ReadLine().ToLower() == "s";
            }
        }


    }
}
