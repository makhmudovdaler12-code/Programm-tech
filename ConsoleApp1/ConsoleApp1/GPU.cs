namespace ConsoleApp1
{
    /// <summary>
    /// Видеокарта. Разгоняется.
    /// </summary>
    public class GPU : Component, IOverclockable
    {
        /// <summary>Объём видеопамяти в гигабайтах.</summary>
        public int Vram { get; set; }

        /// <summary>Топовая ли видеокарта (8 ГБ видеопамяти и больше).</summary>
        public bool IsHighEnd => Vram >= 8;

        /// <summary>
        /// Полный конструктор: артикул, модель, цена, объём видеопамяти.
        /// </summary>
        public GPU(string sku, string model, decimal price, int vram)
            : base(sku, model, price)
        {
            Vram = vram;
            Type = ComponentType.GPU;
        }

        /// <summary>
        /// Короткий конструктор: только модель и объём видеопамяти.
        /// </summary>
        public GPU(string model, int vram)
            : this("N/A", model, 0, vram) { }

        /// <summary>Установить видеокарту.</summary>
        public override void Install()
        {
            Console.WriteLine($"{Model} installed.");
        }

        /// <summary>Разогнать видеокарту.</summary>
        public void Overclock()
        {
            Console.WriteLine($"{Model} overclocked.");
        }

        /// <summary>Строковое представление видеокарты.</summary>
        public override string ToString()
        {
            return $"[GPU] {Model}, {Price}, type: {Type}, vram: {Vram}";
        }
    }
}