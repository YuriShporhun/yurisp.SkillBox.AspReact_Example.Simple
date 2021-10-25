namespace API.Entities
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public int Id {  get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description {  get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public long Price { get; set; }

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// Бренд
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Количество на скаладе
        /// </summary>
        public int QuantityInStock { get; set; }

    }
}
