using System;
using System.ComponentModel;
using System.Text;

#pragma warning disable 1591

namespace Frends.Community.AesCtrCalculator
{
    public class AesCtrCalculatorTasks
    {
        /// <summary>
        /// Calculate AES CTR 128 with given inputs. Inputs are hex strings.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>object {string Data } </returns>
        public static Output CalculateAesCtr([PropertyTab] Input input)
        {
            if (string.IsNullOrWhiteSpace(input.Data) || input.Data.Length % 2 != 0)
            {
                throw new ArgumentException("Input.Data is invalid", "Input.Data");
            }

            if (string.IsNullOrWhiteSpace(input.Key) || input.Key.Length % 2 != 0)
            {
                throw new ArgumentException("Input.Key is invalid", "Input.Key");
            }
            if (string.IsNullOrWhiteSpace(input.Iv) || input.Iv.Length % 2 != 0)
            {
                throw new ArgumentException("Input.Iv is invalid", "Input.Iv");
            }

            var inputBytes = GetByteArray(input.Data);
            var keyBytes = GetByteArray(input.Key);
            var iv = GetByteArray(input.Iv);

            var result = new byte[inputBytes.Length];
            using (var am = new Aes128CounterMode(iv))
            using (var ict = am.CreateDecryptor(keyBytes, null))
            {
                ict.TransformBlock(inputBytes, 0, inputBytes.Length, result, 0);
            }
            
            return new Output{Data = GetHexString(result) };
        }

        private static byte[] GetByteArray(string test)
        {
            var plainText2 = new byte[test.Length/2];
            for (var i = 0; i < test.Length; i = i + 2)
            {
                plainText2[i/2] = (byte) Convert.ToInt32(test[i] + "" + test[i+1], 16);
            }

            return plainText2;
        }

        private static string GetHexString(byte[] test)
        {
            var hex = new StringBuilder(test.Length * 2);
            foreach (var b in test)
                hex.Append(b.ToString("X2"));
            return hex.ToString();
        }
    }
}
