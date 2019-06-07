using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopciones
{
    class Menu
    {
        private List<Cliente> clienteAdopta = new List<Cliente>();
        private List<Mascota> mascotaAdoptada = new List<Mascota>();
        private List<Cliente> clienteLista = new List<Cliente>();
        private List<Mascota> mascotaLista = new List<Mascota>();
        public void iniciarMenu(){
 
            int opcion=0;
            do {
                Console.Clear();
                Console.WriteLine("---------------------------------------Menú------------------------------------");
                Console.WriteLine("1)Dar en adopción una mascota");
                Console.WriteLine("2)Registrar mascota");
                Console.WriteLine("3)Registrar usuario");
                Console.WriteLine("4)Mostrar mascotas registradas");
                Console.WriteLine("5)Mostrar personas registradas");
                Console.WriteLine("6)Mostrar historial de adopciones");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion) {
                    case 1:
                            Console.WriteLine("Escribe el identificador del cliente");
                            new Impresora().imprimirClientes(clienteLista);
                            int idCliente = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe el identificador de la mascota");
                            new Impresora().imprimirMascotas(mascotaLista); 
                            int idMascota=int.Parse(Console.ReadLine());
                            
                         
                            clienteAdopta.Add(clienteLista[idCliente]);
                            mascotaAdoptada.Add(mascotaLista[idMascota]);
                            clienteLista.Remove(clienteLista[idCliente]);
                            mascotaLista.Remove(mascotaLista[idMascota]);
                            Console.WriteLine("Adopcion realizada con exito");
                            Console.ReadLine();

                        break;
                    case 2:
                        formularioMascota();
                        break;
                    case 3:
                        formularioPersona();
                        break;
                    case 4:
                        new Impresora().imprimirMascotas(mascotaLista);
                        Console.ReadLine();
                        break;
                    case 5:
                        new Impresora().imprimirClientes(clienteLista);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        new Impresora().imprimirAdopciones(mascotaAdoptada,clienteAdopta);
                        Console.ReadLine();
                        break;
                }
            } while (opcion!=7);
        }
        private void registrarCliente(String nombre,String apellido,int edad,Boolean sexo) {
            clienteLista.Add(new Cliente(nombre,apellido,edad,sexo));
        }
        private void registrarMascota(String nombre, String raza, int edad, Boolean sexo)
        {
            mascotaLista.Add(new Mascota(nombre, raza, edad, sexo));
        }

        private void formularioMascota() {
            Console.Clear();
            Console.WriteLine("FORMULARIO MASCOTA");
            Console.WriteLine("Nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("raza:");
            String raza = Console.ReadLine();
            Console.WriteLine("edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("sexo(Macho/Hembra):");
            Boolean sexo;
            if (Console.ReadLine() == "Macho")
            {
                sexo = true;
            }
            else {
                sexo = false;
            }
            registrarMascota(nombre,raza,edad,sexo);
        }
        private void formularioPersona()
        {
            Console.Clear();
            Console.WriteLine("FORMULARIO MASCOTA");
            Console.WriteLine("Nombre:");
            String nombre = Console.ReadLine();
            Console.WriteLine("Apellido:");
            String raza = Console.ReadLine();
            Console.WriteLine("Edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("sexo(Hombre/Mujer):");
            Boolean sexo;
            if (Console.ReadLine() == "Macho")
            {
                sexo = true;
            }
            else
            {
                sexo = false;
            }
            registrarCliente(nombre, raza, edad, sexo);
        }
    }
}
