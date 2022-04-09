using Systems;
using UnityEngine;

namespace Testing
{
    public class RandomStringGeneratorTest : MonoBehaviour
    {
        private RandomStringGenerator _randomStringGenerator = new RandomStringGenerator();

        private void Start()
        {
            print(_randomStringGenerator.GenerateString());
            print(_randomStringGenerator.GenerateString(4, StringFormat.UpperNumeric));
        }
    }
}
