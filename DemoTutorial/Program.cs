namespace DemoApp
{
    internal class Program
    {
        
        static void Main(string[] args)
            
        {

            //VARIABLES Y TIPO DE DATOS
            //string nombre = "Selene";
            //int num1 = 19;
            //uint num2 = 20;
            //float num3 = 19.1f;
            //double num4 = 45.50;
            //decimal num5 = 23456.23456m;
            //byte num6 = 255;

            //bool acceso = true;
            //DateTime fecha = DateTime.Today;

            //int num7 = 10;
            //int num8 = 11;
            //int num9 = 12;
            //int num10 = 13;
            //int num11 = 14;

            //imprime valor
            //Console.WriteLine(fecha.Year);
            //mensajeEnPantalla();
            //Console.WriteLine("mensaje desde el main");
            //Console.WriteLine(sumaDeNumeros(1,2));
            //Console.WriteLine("El resultado de la div es:" + divideNumeros(5,2));
            //Console.WriteLine("La suma es " + suma(10,10,11));

            //int    numVal1 = 1;
            //double numVal2 = 1.2;
            //double numVal3 = 1.3;

            //Console.WriteLine(suma(numVal1,numVal2));

            //ESTRUCTURA DE CONTROL - CONDICIONAL IF
            //Console.WriteLine("Ingresa edad: ");
            //int edad = Int32.Parse(Console.ReadLine());


            // if (edad >= 18)
            //{
            //    Console.WriteLine("Tienes licencia? ");
            //    string carnet = Console.ReadLine();

            //    Console.WriteLine("puedes conducir");
            // }else if(edad < 18)
            //    {
            //        Console.WriteLine("Debes ser mayor de 18");
            //        Console.WriteLine("no puedes conducir");
            //    }

            //SINTAXIS SWITCH
            //Console.WriteLine("Ingresa mes: ");
            //int nMes = Int32.Parse(Console.ReadLine());

            //switch (nMes)
            //{
            //    case 1:
            //        Console.WriteLine("Enero");
            //        break;
            //    default: 
            //        Console.WriteLine("Valor no valido");
            //        break;
            //}

            //SINTAXIS WHILE

            //int total = 0;
            //while (total <= 9)
            //{
            //    total++; 
            //    Console.WriteLine(total + "Hola");
            //}
            //Console.WriteLine("termina");

            //Random numero = new Random();
            //int numeroAleatorio = numero.Next(0, 10);
            //Console.WriteLine(numeroAleatorio);
            //Console.WriteLine("Ingresa un numero: ");
            //int numIntentos = 0;
            //int numUsuario = 11;

            //while (numUsuario != numeroAleatorio )
            //{
            //    numIntentos++;
            //    numUsuario = int.Parse(Console.ReadLine());

            //    if (numUsuario < numeroAleatorio) Console.WriteLine("El valor ingresado es menor al número random " + numeroAleatorio);
            //    if (numUsuario > numeroAleatorio) Console.WriteLine("El valor ingresado es mayor al número random" + numeroAleatorio);


            //}

            //    Console.WriteLine("Son iguales");
            //    Console.WriteLine("Tu numero: " + numUsuario);
            //    Console.WriteLine("Numero random: " + numeroAleatorio);
            //    Console.WriteLine("Numero de intentos:" + numIntentos);

            //SINTAXIS Do while && Try Catch
            //int numUsuario = 0;

            //do
            //{
            //    numIntentos++;
            //    try
            //    {

            //    numUsuario = int.Parse(Console.ReadLine());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Solo admite caracteres o el número está fuera de rango");

            //    }


            //    if (numUsuario < numeroAleatorio) Console.WriteLine("El valor ingresado es menor al número random " + numeroAleatorio);
            //    if (numUsuario > numeroAleatorio) Console.WriteLine("El valor ingresado es mayor al número random" + numeroAleatorio);


            //} while (numUsuario != numeroAleatorio);
            //    Console.WriteLine("Son iguales");
            //    Console.WriteLine("Numero de intentos:" + numIntentos);

            //DESBORDAMIENTO, excepción de tipo OverFlow
            //checked
            //{

            //int numDesb = int.MaxValue;
            //int res = numDesb + 20;
            //Console.WriteLine(res);
            //}

            //LANZAMIENTO DE EXCEPCIONES
            //Console.WriteLine("Ingresa número de mes: ");
            //int mes = int.Parse(Console.ReadLine());

            //try
            //{

            //    Console.WriteLine(NombreDelMes(mes));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Mensaje de excepcion: " + ex.Message);
            //}

            //Console.WriteLine("aqui continua programa");


            //MANEJO DE EXCEPCIONES - FINALLY -
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                string ruta = @"/Users/sel/Desktop/Example.txt";
                archivo = new System.IO.StreamReader(ruta);

                while ((linea = archivo.ReadLine()) != null )
                {
                    Console.WriteLine(linea);
                    contador++; 
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la lectura del archivos");
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexión con lectura de archivo, terminada");
            }


        }
        // PRIMER METODO VOID - no devuelve valor
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Metodo desde el mensaje en consolas");
        }

        // SEGUNDO MÉTODO RETURN - si devuelve valor
        static int sumaDeNumeros(int num1, int num2)
        {
            //Console.WriteLine("La suma de los numero es: " + (num1+num2));
            return num1 + num2;
        }

        //OPERADOR LAMDA - SIMPLIFICACIÓN DE MÉTODOS
        static double divideNumeros(double div1, int div2) => div1 / div2;

        //SOBRECARGA DE METODOS
        static int suma(int sum1, int sum2) => sum1 + sum2;
        static int suma(int sumOpe1, int sumOpe2, int sumOpe3) => sumOpe1 + sumOpe2 + sumOpe3;

        //SOBRECARGA DE METODOS CON PARAMETROS OPCIONALES
        private static double suma(int numVal1, double numVal2, double numVal3 = 0)
        {
            return numVal1 + numVal2 + numVal3;
        }

        //LANZAMIENTO DE EXEPCIONES
        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febreo";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Otubre";
                default:

                    throw new ArgumentOutOfRangeException();
                    //return "NA";
                    //Console.WriteLine("Debes ingresar un numero valido");
                    //break;
            }
        }

    }
}
    

