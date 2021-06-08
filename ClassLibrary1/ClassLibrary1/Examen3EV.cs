namespace Examen3EV_NS
{
    using System.Collections.Generic;

    //Examen realizado por MAGS2021
    /// <summary>
    /// La clase <see cref="estNot" />nos calcula las estadísticas de un conjunto de notas.
    /// </summary>
    public class estNot    
    {
        /// <summary>
        /// Campo que cuenta los suspensos del alumno
        /// </summary>
        private int suspenso;

        /// <summary>
        /// Campo que cuenta los aprobados del alumno
        /// </summary>
        private int aprobado;

        /// <summary>
        /// Campo que cuenta los notables del alumno
        /// </summary>
        private int notable;

        /// <summary>
        /// Campo que cuenta los sobresalientes del alumno
        /// </summary>
        private int sobresaliente;

        /// <summary>
        /// Guarda la nota media del alumno
        /// </summary>
        public double media;

        /// <summary>
        /// Propiedad Suspenso
        /// </summary>
        public int Suspenso
        {
            get { return suspenso; }
            set { suspenso = value; }
        }

        /// <summary>
        /// Propiedad Aprobado.
        /// </summary>
        public int Aprobado
        {
            get { return aprobado; }
            set { aprobado = value; }
        }

        /// <summary>
        /// Propiedad Notable.
        /// </summary>
        public int Notable
        {
            get { return notable; }
            set { notable = value; }
        }

        /// <summary>
        /// Propiedad Sobresaliente.
        /// </summary>
        public int Sobresaliente
        {
            get { return sobresaliente; }
            set { sobresaliente = value; }
        }

        /// <summary>
        /// Excepcion que se produce cuando no existen notas en la lista de notas del alumno
        /// </summary>
        public const string ExcepcionNoHayNotas = "No existen notas en el alumno";

        /// <summary>
        /// Excepcion que se produce cuando las notas introducidas no se encuentran entre 0 y 10.
        /// </summary>
        public const string ExcepcionNotasFueraRango = "Las notas estan fuera del rango de 0 a 10";

        // 
        /// <summary>
        /// Constructor vacío de la clase <see cref="estNot"/> que inicializa las propiedades a 0.
        /// </summary>
        public estNot()
        {
            Suspenso = 0;
            Aprobado = 0;
            Notable = 0;
            Sobresaliente = 0;  
            media = 0.0;
        }

        // 
        //MAGS2021
        /// <summary>
        /// Constructor a partir de un array, calcula las estadísticas al crear el objeto de la clase <see cref="estNot"/>.
        /// </summary>
        /// <param name="listaNotas">Lista de tipo<see cref="List{int}"/> que almacena las notas del alumno.</param>
        public estNot(List<int> listaNotas)
        {
            media = CalcularEstadisticas(listaNotas);
        }

        /// <summary>
        /// Metodo que comprueba la nota para cada posicion de la lista y va sumando al contador de los campos de la clase.
        /// </summary>
        /// <param name="listaNotas">La lista <see cref="List{int}"/> de notas del alumno</param>
        /// <param name="i">El parametro i<see cref="int"/> comproeba la posicion dentro de la listaNotas.</param>
        private void AnadirNota(List<int> listaNotas, int i)
        {
            if (listaNotas[i] < 5)
            {
                Suspenso++;
            }            // Por debajo de 5 suspenso
            else if (listaNotas[i] > 5 && listaNotas[i] < 7)
            {
                Aprobado++;// Nota para aprobar: 5
            }
            else if (listaNotas[i] > 7 && listaNotas[i] < 9)
            {
                Notable++; // Nota para notable: 7
            }
            else if (listaNotas[i] > 9)
            {
                Sobresaliente++;         // Nota para sobresaliente: 9
            }
        }


        // 
        //MAGS2021
        /// <summary>
        /// Para un conjunto de listaNotas, calculamos las estadísticas
        /// </summary>
        /// <para>calcula la media y el número de suspensos/aprobados/notables/sobresalientes</para>
        /// <para>El método devuelve -1 si ha habido algún problema, la media en caso contrario</para>
        /// <param name="listaNotas">Al metodo se le pasa la lista <see cref="List{int}"/>.</param>
        /// <returns>Devuelve la nota media del alumno como <see cref="double"/>.</returns>
        public double CalcularEstadisticas(List<int> listaNotas)
        {
            media = 0.0;
            double total = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listaNotas.Count <= 0)
            {  // Si la lista no contiene elementos, devolvemos un error
                throw new System.Exception(ExcepcionNoHayNotas);
            }

            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 0 || listaNotas[i] > 10)
                {     // comprobamos que las notas están entre 0 y 10 (mínimo y máximo), si no, error
                    throw new System.Exception(ExcepcionNotasFueraRango);
                }
            }

            for (int i = 0; i < listaNotas.Count; i++)
            {
                AnadirNota(listaNotas, i);

                total = total + listaNotas[i];
            }

            media = total / listaNotas.Count;

            return media;
        }
    }
}
