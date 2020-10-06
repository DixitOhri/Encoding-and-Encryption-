using System;
using ConverterApp.Models;
using System.Text;
using System.Linq;

namespace ConverterApp
{
    class Program
    {
        private static bool nameBase64;

        static void Main(string[] args)
        {
            var fullName = Console.ReadLine();

            string text = "Dixit Ohri";

            string binaryValue = Converter.StringToBinary(text);

            Console.WriteLine($"Text is : {text}\nText to Binary: {binaryValue}");

           

            var ascii = Console.ReadLine();
            string textFromBinary = Converter.BinaryToString(binaryValue);

            Console.WriteLine($"Binary value is: {binaryValue}\nBinary to Text: {textFromBinary}");

            string hexadecimalValue2 = Converter.StringToHex2(fullName);

            Console.WriteLine($"Text is: {fullName}\nText to HEX: {hexadecimalValue2}");

            string textFromHex = Converter.HexToString(hexadecimalValue2);

            Console.WriteLine($"HEX is: {hexadecimalValue2}\nHex to Text: {textFromHex}");

            //Output the Base64 encoded string
            string nameBase64Encoded =Converter.StringToBase64(fullName);
            Console.WriteLine($"Text is :{fullName} \nText to Base 64 : {nameBase64Encoded} ");

            //Output the decoded Base64 string
            string nameBase64Decoded =Converter.Base64ToString(nameBase64Encoded);
            Console.WriteLine($"Base64 is :{nameBase64Decoded}\nBase 64 to Text :{fullName}");

            byte[] FullNameBytes = Encoding.Unicode.GetBytes(fullName);
            for (int i = 0; i < FullNameBytes.Length; i++)
            {
                byte element = FullNameBytes[i];
                Console.WriteLine("{0}{1}",element, (char)element);
            }
            int[] cipher = new[] { 1, 1, 2, 3, 5, 8, 13 }; //Fibonacci Sequence
            string cipherasString = String.Join(",", cipher.Select(x => x.ToString())); //FOr display

            int encryptionDepth = 20;
            //Deep Encrytion
            string nameDeepEncryptWithCipher = Converter.DeepEncryptWithCipher(fullName, cipher, encryptionDepth);
            Console.WriteLine($"Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepEncryptWithCipher}");

            string nameDeepDecryptWithCipher = Converter.DeepDecryptWithCipher(nameDeepEncryptWithCipher, cipher, encryptionDepth);
            Console.WriteLine($"Deep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepDecryptWithCipher}");
        }
    }
}
