using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fase5
{
    public class cajero
    {
        private int retiro;
        private int deposito;
        private int transferencia;        
        private int totalCuenta;
        private int Daviplata;
        //retirar
        public void retira()
        {
            Console.Clear();
            Console.WriteLine("ha escogido la opcion de retirar");
            Console.WriteLine("");
            Console.WriteLine("solo se retirar esos montos");
            Console.WriteLine("");
            Console.WriteLine("monto de $10 000");
            Console.WriteLine("monto de $20 000");
            Console.WriteLine("monto de $50 000");
            Console.WriteLine("monto de $100 000");
            Console.WriteLine("");
            Console.WriteLine("presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("digite la cantidad de cuanto desea retira");
            retiro = int.Parse(Console.ReadLine());
            
            if (retiro < totalCuenta||retiro==10000||retiro==20000||retiro==50000||retiro==100000)
            {
                Console.WriteLine("se retiro la plata");
                Console.ReadKey();

                totalCuenta = (totalCuenta - retiro);
            }
            else if( retiro>totalCuenta)
            {
                Console.WriteLine("la cantidad que desea retirar supera el monto guardado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("el valor que desea retirar no esta disponible");
            }
        }
        public void depositar()
        {
            deposito = 200000;
            Console.WriteLine("digite la cantidad de cuanto desea depositar");
            deposito = int.Parse(Console.ReadLine());
            totalCuenta = deposito;

        }
        public void transferir()
        {
            int cuenta1;
            string nombre1;
            Console.WriteLine("Ha escogido la opcion de transferencia");
            Console.WriteLine("");
            Console.WriteLine("digite el numero de cuenta que va a hacer la transferencia");
            cuenta1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el nombre del dueño de la cuenta");
            nombre1 = Console.ReadLine();
            Console.WriteLine("digite la cantidad que desea transferir");
        }
        public cajero()
        {
            totalCuenta = 200000;
            retiro = 0;
            deposito = 200000;
        }
        public void consultar()
        {
            Console.WriteLine("total depositado en el banco es {0}", totalCuenta);
        }

    }
    class fase5
    {
        static void Main(string[] args)
        {
            cajero funcion = new cajero();
            double contraseña;
            int cont;
            cont = 0;

            do
            {
                cont++;
                Console.WriteLine("estimado usuario por favor ingrese la contraseña");
                contraseña = double.Parse(Console.ReadLine());
                if (contraseña == 1234)
                {
                    Console.WriteLine("haz ingresado la contraseña correcta. BIENVENIDO A NUESTRO BANCO DAVIVIENDA");
                    Console.ReadKey();
                }
                if (contraseña!=1234)
                {                   
                    if (cont < 3)
                    {
                        
                        Console.WriteLine("contraseña incorrecta. intente nuevamente");
                        Console.ReadKey();
                    }             
                    
                }
            } while (contraseña == 1234&&cont==3);
            if(cont==3)
            {
                
                Console.WriteLine("contraseña incorrecta. intentalo en otra oportunidad");
                Console.ReadKey();
            }
                
            int opc1;
            opc1 = 0;
            while (contraseña == 1234)
            {
                while (opc1 != 4)
                {
                    Console.Clear();
                    Console.WriteLine(" >> > MENU DE OPCIONES < << \n\n");

                    Console.WriteLine("");
                    Console.WriteLine("Menu de Transacciones");
                    Console.WriteLine("");
                    Console.WriteLine("1. Desea retirar dinero.");
                    Console.WriteLine("2. Desea depositar dinero.");
                    Console.WriteLine("3. mostrar cantidad de depositado");
                    Console.WriteLine("4. Salir del programa");
                    opc1 = 0;
                    Console.Write(" digite la opcion seleccionada ");
                    opc1 = int.Parse(Console.ReadLine());


                    switch (opc1)
                    {
                        case 1:
                            funcion.retira();
                            funcion.consultar();
                            break;
                        case 2:
                            funcion.depositar();
                            break;
                        case 3:
                            funcion.consultar();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Gracias por usar nuestros servicios …. ");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("opcion no valida");
                            break;
                    }
                }
            
            }
        }
    }
}
