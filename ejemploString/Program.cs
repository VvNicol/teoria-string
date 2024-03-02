using System;

namespace ejemploString
{
    class Program
    {
        static public void Main(string[] args)
        {
            string texto = "El alumnado de CSI2 tiene prácticas, en marzo, " +
                "durante 2 meses.";

            //Concatenar
            string textoConEspacios = String.Concat(" ",texto," ");

            //Introducir los espacio
            /*string espaciosIzquierda = texto.PadLeft(texto.Length + 1);
            string espaciosDerecha = espaciosIzquierda.PadRight(espaciosIzquierda.Length + 1);*/
            Console.WriteLine("QUITAR ESPACIOS");

            string textoSinEspaciosIzquierda = textoConEspacios.TrimStart();
            Console.WriteLine(textoSinEspaciosIzquierda);
            string textoSinEscpaciosIzquierdaNiDerecha = textoConEspacios.TrimEnd();
            Console.WriteLine(textoSinEscpaciosIzquierdaNiDerecha);

            string textoSinEspacioALaVez = texto.Trim(); //Equivalente a usar los otros dos

            //Dividir un texto por un carácter
            Console.WriteLine("SPLIT");
            char caracterSeparacion = ',';
            string[] textoSeparado = texto.Split(caracterSeparacion);
            foreach(string trozo in textoSeparado)
            {
                Console.WriteLine(trozo);
            }

            //Secuencia de escape
            //Se utiliza para poder introducir caracteres especiales
            //o de control dentro de un texto
            Console.WriteLine("SECUENCIA DE ESCAPE");
            Console.WriteLine("Nombre \tApellidos \tEdad");
            Console.WriteLine("Marcos \r\nAlfonso \r\nMarta");
            /*
             * t: tabulación
             * r: retorno de carro
             * n: salto de línea
             */
            //¿Se verá bien?
            Console.WriteLine("C: \\Users\\Trabajo\\ed - workspace\\edu.ejemploLista\\bin\\controladores");
             
            //Cuando se escriben textos muy largos, 
            // utilizar el @ nos permite olvidarnos de los caracteres
            // de escape.
            string textoLargo = @"C:\Users\Trabajo\ed-workspace\edu.ejemploLista\bin\controladores";
            Console.WriteLine(textoLargo);

            //Literales sin formato a partir de C# 11
            //Seguramente tenéis instalado el 10
            //Comienza y acaba con triples comillas dobles
            //Se suele utilizar para introducir html
            /*string textoHtml = """
                <body style="normal">
                Hola
                </body>
                """;*/

        }
    }
}
