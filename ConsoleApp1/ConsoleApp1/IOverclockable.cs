namespace ConsoleApp1
{
    /// <summary>
    /// Компонент, который можно разогнать (повысить частоту работы).
    /// </summary>
    public interface IOverclockable
    {
        /// <summary>
        /// Выполнить разгон компонента.
        /// </summary>
        void Overclock();
    }
}