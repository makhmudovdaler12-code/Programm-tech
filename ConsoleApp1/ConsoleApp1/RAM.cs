namespace ConsoleApp1
{
    /// <summary>
    /// Оперативная память. Не разгоняется.
    /// </summary>
    public class RAM : Component
    {
        /// <summary>Объём памяти в гигабайтах.</summary>
        public int Capacity { get; set; }

        /// <summary>Большой ли объём памяти (32 ГБ и больше).</summary>
        public bool IsBig => Capacity >= 32;

        /// <summary>
        /// Полный конструктор: артикул, модель, цена, объём памяти.
        /// </summary>
        public RAM(string sku, string model, decimal price, int capacity)
            : base(sku, model, price)
        {
            Capacity = capacity;
        }

        /// <summary>
        /// Короткий конструктор: только модель и объём памяти.
        /// </summary>
        public RAM(string model, int capacity)
            : this("N/A", model, 0, capacity) { }

        /// <summary>Установить оперативную память.</summary>
        public override void Install()
        {
            Console.WriteLine($"{Model} installed.");
        }

        /// <summary>Строковое представление оперативной памяти.</summary>
        public override string ToString()
        {
            return $"[RAM] {Model}, {Price}, type: {Type}, capacity: {Capacity}";
        }
    }
}