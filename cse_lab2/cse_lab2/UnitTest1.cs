using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.PasswordHashingUtils;
using System;

namespace cse_lab2
{
	[TestClass]
	public class PasswordHasherTests
	{
		private uint adlerMod32 = 5;
		private string salt = "somesalt";

		// Check whether PasswordHasher with Init doesn't return null.

		[TestMethod]
		public void CheckInitWork()
		{
			string password = "pass";
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check whether PasswordHasher with empty Init doesn't return null.

		[TestMethod]
		public void EmptyInit()
		{
			string saltTest = "";
			uint adler = 0;
			string password = "pass";
			PasswordHasher.Init(saltTest, adler);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check whether PasswordHasher with same password returns same hash.

		[TestMethod]
		public void InitSameData()
		{
			string password = "pass";
			PasswordHasher.Init(salt, adlerMod32);
			string hash1 = PasswordHasher.GetHash(password);
			string hash2 = PasswordHasher.GetHash(password);
			Assert.AreEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with different salt returns different hash.

		[TestMethod]
		public void InitDifferentSalt()
		{
			string password = "pass";
			string salt1 = "salt1";
			string salt2 = "salt2";
			PasswordHasher.Init(salt1, adlerMod32);
			string hash1 = PasswordHasher.GetHash(password);
			PasswordHasher.Init(salt2, adlerMod32);
			string hash2 = PasswordHasher.GetHash(password);
			Assert.AreNotEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with different adler returns different hash.

		[TestMethod]
		public void InitDifferentAdler()
		{
			string password = "pass";
			uint adler1 = 1;
			uint adler2 = 2;
			PasswordHasher.Init(salt, adler1);
			string hash1 = PasswordHasher.GetHash(password);
			PasswordHasher.Init(salt, adler2);
			string hash2 = PasswordHasher.GetHash(password);
			Assert.AreNotEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with different password returns different hash.
		[TestMethod]
		public void InitDifferentPassword()
		{
			string password1 = "pass1";
			string password2 = "pass2";
			PasswordHasher.Init(salt, adlerMod32);
			string hash1 = PasswordHasher.GetHash(password1);
			string hash2 = PasswordHasher.GetHash(password2);
			Assert.AreNotEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with empty password returns not null hash.

		[TestMethod]
		public void InitEmptyPass()
		{
			string saltTest = "";
			uint adler = 0;
			string password = "";
			PasswordHasher.Init(saltTest, adler);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for max uint.

		[TestMethod]
		public void InitMaxUint()
		{
			uint adler = UInt32.MaxValue;
			string password = "pass";
			PasswordHasher.Init(salt, adler);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for min uint.

		[TestMethod]
		public void InitMinUint()
		{
			uint adler = UInt32.MinValue;
			string password = "pass";
			PasswordHasher.Init(salt, adler);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for null password.

		[TestMethod]
		public void InitNullPassword()
		{
			string password = null;
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNull(hash);
		}

		// Check PasswordHasher for cyryllic adler.

		[TestMethod]
		public void InitCyryllicAdler()
		{
			string saltTest = "якісьБукви";
			string password = "pass";
			PasswordHasher.Init(saltTest, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for cyryllic password.

		[TestMethod]
		public void InitCyryllicPassword()
		{
			string password = "тутПароль";
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for arabian adler.

		[TestMethod]
		public void InitArabianAdler()
		{
			string saltTest = "ذضظغ";
			string password = "pass";
			PasswordHasher.Init(saltTest, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for arabian password.

		[TestMethod]
		public void InitArabianPassword()
		{
			string password = "ذضظغ";
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for regexp adler.

		[TestMethod]
		public void InitRegExpAdler()
		{
			string saltTest = "(\\w)(\\s+)([\\.,])";
			string password = "pass";
			PasswordHasher.Init(saltTest, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for regexp password.

		[TestMethod]
		public void InitRegExpPassword()
		{
			string password = "(\\w)(\\s+)([\\.,])";
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for hyphenation adler.

		[TestMethod]
		public void InitHyphenationAdler()
		{
			string saltTest = "\n\n";
			string password = "pass";
			PasswordHasher.Init(saltTest, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for hyphenation password.

		[TestMethod]
		public void InitHyphenationPassword()
		{
			string password = "\n\n";
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for emodji adler.

		[TestMethod]
		public void InitEmodjiAdler()
		{
			string saltTest = "🙉🔫✔😉";
			string password = "pass";
			PasswordHasher.Init(saltTest, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for emodji password.

		[TestMethod]
		public void InitEmodjiPassword()
		{
			string password = "🙉🔫✔😉";
			PasswordHasher.Init(salt, adlerMod32);
			string hash = PasswordHasher.GetHash(password);
			Assert.IsNotNull(hash);
		}

		// Check whether PasswordHasher with same password returns same hash.

		[TestMethod]
		public void SameData()
		{
			string password = "pass";
			string hash1 = PasswordHasher.GetHash(password, salt, adlerMod32);
			string hash2 = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.AreEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with different salt returns different hash.

		[TestMethod]
		public void DifferentSalt()
		{
			string password = "pass";
			string salt1 = "salt1";
			string salt2 = "salt2";
			string hash1 = PasswordHasher.GetHash(password, salt1, adlerMod32);
			string hash2 = PasswordHasher.GetHash(password, salt2, adlerMod32);
			Assert.AreNotEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with different adler returns different hash.

		[TestMethod]
		public void DifferentAdler()
		{
			string password = "pass";
			uint adler1 = 1;
			uint adler2 = 2;
			string hash1 = PasswordHasher.GetHash(password, salt, adler1);
			string hash2 = PasswordHasher.GetHash(password, salt, adler2);
			Assert.AreNotEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with different password returns different hash.

		[TestMethod]
		public void DifferentPassword()
		{
			string password1 = "pass1";
			string password2 = "pass2";
			string hash1 = PasswordHasher.GetHash(password1, salt, adlerMod32);
			string hash2 = PasswordHasher.GetHash(password2, salt, adlerMod32);
			Assert.AreNotEqual(hash1, hash2);
		}

		// Check whether PasswordHasher with empty password returns not null hash.

		[TestMethod]
		public void EmptyPass()
		{
			string saltTest = "";
			uint adler = 0;
			string password = "";
			string hash = PasswordHasher.GetHash(password, saltTest, adler);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for max uint.

		[TestMethod]
		public void MaxUint()
		{
			uint adler = UInt32.MaxValue;
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, salt, adler);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for min uint.

		[TestMethod]
		public void MinUint()
		{
			uint adler = UInt32.MinValue;
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, salt, adler);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for null password.

		[TestMethod]
		public void NullPassword()
		{
			string password = null;
			string hash = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.IsNull(hash);
		}

		// Check PasswordHasher for cyryllic adler.

		[TestMethod]
		public void CyryllicAdler()
		{
			string saltTest = "якісьБукви";
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, saltTest, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for cyryllic password.

		[TestMethod]
		public void CyryllicPassword()
		{
			string password = "тутПароль";
			string hash = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for arabian adler.

		[TestMethod]
		public void ArabianAdler()
		{
			string saltTest = "ذضظغ";
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, saltTest, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for arabian password.

		[TestMethod]
		public void ArabianPassword()
		{
			string password = "ذضظغ";
			string hash = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.IsNotNull(hash);
		}

		[TestMethod]
		public void RegExpAdler()
		{
			string saltTest = "(\\w)(\\s+)([\\.,])";
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, saltTest, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for regexp adler.

		[TestMethod]
		public void RegExpPassword()
		{
			string password = "(\\w)(\\s+)([\\.,])";
			string hash = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for hyphenation adler.

		[TestMethod]
		public void HyphenationAdler()
		{
			string saltTest = "\n\n";
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, saltTest, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for hyphenation password.

		[TestMethod]
		public void HyphenationPassword()
		{
			string password = "\n\n";
			string hash = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for emodji adler.

		[TestMethod]
		public void EmodjiAdler()
		{
			string saltTest = "🙉🔫✔😉";
			string password = "pass";
			string hash = PasswordHasher.GetHash(password, saltTest, adlerMod32);
			Assert.IsNotNull(hash);
		}

		// Check PasswordHasher for emodji password.

		[TestMethod]
		public void EmodjiPassword()
		{
			string password = "🙉🔫✔😉";
			string hash = PasswordHasher.GetHash(password, salt, adlerMod32);
			Assert.IsNotNull(hash);
		}
	}
}
