
namespace InterfazQ32024
{

    /// <summary>
    /// Interfaz que contiene los métodos para calcular diferentes áreas matemáticas.
    /// </summary>
    public interface IArea
    {
        /// <summary>
        /// Implementa proceso de calcular el área de un cuadrado.
        /// </summary>
        /// <returns>El área de un cuadrado</returns>
        public double Cuadrado();

        /// <summary>
        /// Implementa proceso de calcular el área de un triángulo.
        /// </summary>
        /// <returns>El área de un triángulo</returns>
        public double Triangulo();

    }
}
