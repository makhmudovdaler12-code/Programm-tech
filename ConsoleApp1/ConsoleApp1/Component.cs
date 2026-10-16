namespace ConsoleApp1
{
    /// <summary>
    /// Базовый класс для всех компьютерных комплектующих.
    /// </summary>
    public abstract class Component
    {
        // Приватное поле: артикул. Скрыт от внешнего доступа.
        private string _sku;

        /// <summary>Название модели, например "Intel i9".</summary>
        public string Model { get; set; }

        /// <summary>Цена без налога.</summary>
        public decimal Price { get; set; }

        /// <summary>Тип компонента. По умолчанию — CPU.</summary>
        public ComponentType Type { get; set; } = ComponentType.CPU;

        /// <summary>Цена с налогом 20%.</summary>
        public decimal PriceWithTax => Price * 1.2m;

        /// <summary>
        /// Полный конструктор: артикул, модель, цена.
        /// </summary>
        protected Component(string sku, string model, decimal price)
        {
            _sku = sku;
            Model = model;
            Price = price;
        }

        /// <summary>
        /// Короткий конструктор: только модель.
        /// Остальные значения подставляются по умолчанию.
        /// </summary>
        protected Component(string model) : this("N/A", model, 0) { }

        /// <summary>
        /// Установить компонент. Каждый наследник реализует по-своему.
        /// </summary>
        public abstract void Install();
    }
}