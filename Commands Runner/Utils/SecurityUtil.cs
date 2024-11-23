using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Utils
{
	public static class SecurityUtil
	{
		private static readonly byte[] Key = Encoding.UTF8.GetBytes("X<HPe9Gv@,(;CMj!"); // 16 bytes (128 bits)
		private static readonly byte[] IV = Encoding.UTF8.GetBytes("j4df,2}Z!P^uheBw"); // 16 bytes (128 bits)

		public static string Encrypt(string plainText)
		{
			if (string.IsNullOrEmpty(plainText))
				return null;

			using (var aes = Aes.Create())
			{
				aes.Key = Key;
				aes.IV = IV;
				ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
					{
						using (var sw = new StreamWriter(cs))
						{
							sw.Write(plainText);
						}
					}

					return Convert.ToBase64String(ms.ToArray());
				}
			}
		}

		public static string Decrypt(string encryptedText)
		{
			if (string.IsNullOrEmpty(encryptedText))
				return null;

			using (Aes aes = Aes.Create())
			{
				aes.Key = Key;
				aes.IV = IV;
				ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

				using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(encryptedText)))
				using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
				using (StreamReader sr = new StreamReader(cs))
				{
					return sr.ReadToEnd();
				}
			}
		}
	}
}
