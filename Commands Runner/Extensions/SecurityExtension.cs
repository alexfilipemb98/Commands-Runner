using Commands_Runner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Extensions
{
	public static class SecurityExtension
	{
		public static string Encrypt(this string plainText) => SecurityUtil.Encrypt(plainText);
		public static string Decrypt(this string encryptedText) => SecurityUtil.Decrypt(encryptedText);
	}
}
