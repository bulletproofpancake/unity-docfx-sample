using TMPro;
using UnityEngine.UI;

namespace ExtensionMethods
{
    /// <summary>
    /// Extension methods for different types of UI. 
    /// </summary>
    public static class UIExtensions
    {
        /// <summary>
        /// Prints message to a <see cref="TextMeshProUGUI"/> element.
        /// </summary>
        /// <param name="description">The <see cref="TextMeshProUGUI"/> element.</param>
        /// <param name="message">The message to print.</param>
        /// <param name="setActive">Determines the active state of the gameObject.</param>
        public static void WriteToDescription(this TextMeshProUGUI description, string message, bool setActive = true)
        {
            description.text = message;
            description.gameObject.SetActive(setActive);
        }

        /// <summary>
        /// Sets the alpha of an image.
        /// </summary>
        /// <param name="image">The <see cref="Image"/> affected.</param>
        /// <param name="alphaValue">The opacity of the image ranging from 0 to 1.</param>
        /// <remarks>
        /// It helps to think of alphaValue as a scale from 0 to a 100 percent.
        /// </remarks>
        public static void SetAlpha(this Image image, float alphaValue)
        {
            var tempColor = image.color;
            tempColor.a = alphaValue;
            image.color = tempColor;
        }

        /// <summary>
        /// Clears the text of a <see cref="TextMeshProUGUI"/> element.
        /// </summary>
        /// <param name="text">The <see cref="TextMeshProUGUI"/> to clear.</param>
        public static void ClearText(this TextMeshProUGUI text)
        {
            text.text = string.Empty;
        }

        /// <summary>
        /// Clears the text of a <see cref="TMP_InputField"/> element.
        /// </summary>
        /// <param name="text">The <see cref="TMP_InputField"/> to clear.</param>
        public static void ClearText(this TMP_InputField text)
        {
            text.text = string.Empty;
        }
    }
}