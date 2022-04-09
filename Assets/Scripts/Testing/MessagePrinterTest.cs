using Systems;
using UnityEngine;

namespace Testing
{
    public class MessagePrinterTest : MonoBehaviour
    {
        private RandomStringGenerator _randomStringGenerator = new RandomStringGenerator();
        private MessagePrinter _messagePrinter = new MessagePrinter();

        private void Start()
        {
            _messagePrinter.Print();

            for (int i = 0; i < 3; i++)
            {
                _messagePrinter.Print(_randomStringGenerator.GenerateString(), (Systems.LogType)i);
            }
        }
    }
}
