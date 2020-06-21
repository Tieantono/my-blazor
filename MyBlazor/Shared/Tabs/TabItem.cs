namespace MyBlazor.Shared.Tabs
{
    /// <summary>
    /// Tab item model class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TabItem<T>
    {
        /// <summary>
        /// Gets or sets the tab title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the tab item based on the generic parameter <seealso cref="T"/> type.
        /// </summary>
        public T Item { get; set; }
    }
}
