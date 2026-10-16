namespace ConsoleApp1
{
    /// <summary>
    /// Процессор. Разгоняется.
    /// </summary>
    public class CPU : Component, IOverclockable
    {
        /// <summary>Количество ядер.</summary>
        public int Cores { get; set; }

        /// <summary>Многоядерный ли процессор (больше одного ядра).</summary>
        public bool IsMulticore => Cores > 1;

        /// <summary>
        /// Полный конструктор: артикул, модель, цена, число ядер.
        /// </summary>
        public CPU(string sku, string model, decimal price, int cores)
            : base(sku, model, price)
        {
            Cores = cores;
            Type = ComponentType.CPU;
        }

        /// <summary>
        /// Короткий конструктор: только модель и число ядер.
        /// </summary>
        public CPU(string model, int cores)
            : this("N/A", model, 0, cores) { }

        /// <summary>Установить процессор.</summary>
        public override void Install()
        {
            Console.WriteLine($"{Model} installed.");
        }

        /// <summary>Разогнать процессор.</summary>
        public void Overclock()
        {
            Console.WriteLine($"{Model} overclocked to 5 GHz.");
        }

        /// <summary>Строковое представление процессора.</summary>
        public override string ToString()
        {
            return $"[CPU] {Model}, {Price}, type: {Type}, cores: {Cores}";
        }
    }
}