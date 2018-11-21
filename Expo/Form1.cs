using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expo
{
    public partial class Expo : Form
    {
        public Expo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? enteronullable = null;
            if (enteronullable.HasValue)
            {
                Console.WriteLine("La caja está llena");
            }
            else
            {
                Console.WriteLine("La caja está vacía");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Lista de tipo generico
            List<int> ListGeneric = new List<int> { 5, 9, 1, 4 };
            //Lista de tipo no generico
            ArrayList ListNonGeneric = new ArrayList { 5, 9, 1, 4 };
            //Temporizador de sorteo generico
            Stopwatch s = Stopwatch.StartNew();
            ListGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Sorteo no generico: {ListGeneric}  \n Tiempo tomado: {s.Elapsed.TotalMilliseconds}ms");

            //Temporizador de sorteo no generico
            Stopwatch s2 = Stopwatch.StartNew();
            ListNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Sorteo no generico: {ListNonGeneric}  \n Tiempo tomado: {s2.Elapsed.TotalMilliseconds}ms");
            Console.ReadLine();
        }

        private void btncoleccionesgenericas_Click(object sender, EventArgs e)
        {
            string linea;
            List<string> _listadefrutas = new List<string>();
            _listadefrutas.Add("Manzana");
            _listadefrutas.Add("Naranja");
            _listadefrutas.Add("Pera");
            List<string> _listadeverduras = new List<string>(_listadefrutas);
            _listadeverduras.Add("Papa");
            _listadeverduras.Add("Yautia");
            Console.WriteLine("Lista Normal");
            Console.WriteLine("--------------------------------");
            foreach (string item in _listadeverduras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Buscar en una lista");
            Console.Write("Inserte el articulo a buscar: ");
            linea = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            if (_listadeverduras.Contains(linea))
            {
                Console.WriteLine(linea+" encontrada");
            }
            else
            {
                Console.WriteLine("No existe el articulo buscado");
            }
        }

        private void btnmanejodeexcepciones_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            string linea;
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            try
            {
                Console.Write("El resultado de la division es: ");
                resultado = num1 / num2;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No se puede dividir entre cero");
            }
        }

        private void btnlinq_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 526, 6, 22
            };
            var resultado = numeros.Where(x => x > 0).ToList();
            //Poner debug en console.read() y poner el mouse encima de resultado
            Console.Read();
        }

        private void btnxml_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("Libros");
            doc.AppendChild(raiz);

            XmlElement libro = doc.CreateElement("libro");
            raiz.AppendChild(libro);

            XmlElement titulo = doc.CreateElement("titulo");
            titulo.AppendChild(doc.CreateTextNode("El Hobbit"));
            libro.AppendChild(titulo);

            XmlElement precio = doc.CreateElement("precio");
            precio.AppendChild(doc.CreateTextNode("RD$ 100"));
            libro.AppendChild(precio);

            libro = doc.CreateElement("libro");
            raiz.AppendChild(libro);

            doc.Save(@"c:\libro.xml");
            //cambiar por el desktop
        }
    }
}
