

namespace InterfazQ32024
{
    /// <summary>
    /// Interfaz que contiene los métodos para calcular las diferentes operaciones básicas.
    /// </summary>
    public interface IOperaciones
    {

        /// <summary>
        /// Implementa proceso una suma.
        /// </summary>
        /// <returns>Total de la suma</returns>
        public double Suma();

        /// <summary>
        /// Implementa proceso una resta.
        /// </summary>
        /// <returns>Total de la resta</returns>
        public double Resta();

        /// <summary>
        /// Implementa proceso una multiplicación.
        /// </summary>
        /// <returns>Total de la multiplicación</returns>
        public double Multiplicacion();

        /// <summary>
        /// Implementa proceso una división.
        /// </summary>
        /// <returns>Total de la división</returns>
        public double Division();

        
    }
}
