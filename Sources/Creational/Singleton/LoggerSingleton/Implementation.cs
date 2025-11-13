namespace LoggerSingleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        // Lazy<T> for thread safety
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance => _lazyLogger.Value;

        protected Logger()
        {
        }

        /// <summary>
        /// Singleton operation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}