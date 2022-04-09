using UnityEngine;

namespace Systems
{
    /// <summary>
    /// Prints a message to the console in different log types
    /// </summary>
    public class MessagePrinter
    {
        /// <summary>
        /// Prints a message with the specified log type.
        /// </summary>
        /// <param name="message">The message to print.</param>
        /// <param name="type">The type of log to use.</param>
        public void Print(string message = " ", LogType type = LogType.Log)
        {
            switch (type)
            {
                case LogType.Log:
                    Debug.Log(message);
                    break;
                case LogType.Warning:
                    Debug.LogWarning(message);
                    break;
                case LogType.Error:
                    Debug.LogError(message);
                    break;
                default:
                    Debug.LogError("No LogType found.");
                    break;
            }
        }
    }


    /// <summary>
    /// The type of log that would be used by the message
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// Uses Debug.Log(object).
        /// </summary>
        Log = 0,
        /// <summary>
        /// Uses Debug.LogWarning(object).
        /// </summary>
        Warning = 1,
        /// <summary>
        /// Uses Debug.LogError(object).
        /// </summary>
        Error = 2
    }
}