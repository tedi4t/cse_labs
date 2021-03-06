using System;
using IIG.BinaryFlag;
using IIG.PasswordHashingUtils;
using IIG.FileWorker;
using IIG.CoSFE.DatabaseUtils;
using Xunit;

namespace cse_lab4
{
	public class TestPasswordHashingFile
	{
		//Test GetHash in PasswordHasher and Write in BaseFileWorker functions
		[Theory]
		[InlineData("file1.txt", "password", "salt", 1)]
		[InlineData("file2.txt", "pass", "", 2)]
		[InlineData("file3.txt", "/!:&?,", "{}[]!&?*", 2)]
		[InlineData("file4.txt", "тутЯкийсьПароль", "salt", 1)]
		[InlineData("file5.txt", "✌✌✌✌✌✌✌✌✌✌✌✌✌✌✌✌", "", 1)]
		[InlineData("file6.txt", "你好!你好你好你好", "", 1)]
		[InlineData("file7.txt", "\n(\\w)(\\s+)", "(?i)(<title.*?>)", 1)]
		[InlineData("file8.txt", "pass", "", UInt32.MaxValue)]
		[InlineData("file8.txt", "pass", "", UInt32.MinValue)]
		public void GetHash_Write(String path, String password, String salt, UInt32 adlerMod)
		{
			String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
			var result = BaseFileWorker.Write(passwordHash, path);
			Assert.True(result);
			String dataInFile = BaseFileWorker.ReadAll(path);
			Assert.Equal(passwordHash, dataInFile);
		}

		//Test GetHash in PasswordHasher and TryWrite in BaseFileWorker functions
		[Theory]
		[InlineData("file1.txt", 1, "/!:&?,", "{}[]!&?*", 2)]
		[InlineData("file2.txt", 1, "тутЯкийсьПароль", "salt", 1)]
		[InlineData("file3.txt", 10, "✌✌✌✌✌✌✌✌✌✌✌✌✌✌✌✌", "", 1)]
		[InlineData("file4.txt", 10, "你好!你好你好你好", "", 1)]
		[InlineData("file5.txt", Int32.MaxValue, "\n(\\w)(\\s+)", "(?i)(<title.*?>)", 1)]
		public void GetHash_TryWrite(String path, Int32 attempts, String password, String salt, UInt32 adlerMod)
		{
			String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
			var result = BaseFileWorker.TryWrite(passwordHash, path, attempts);
			Assert.True(result);
			String dataInFile = BaseFileWorker.ReadAll(path);
			Assert.Equal(passwordHash, dataInFile);
		}

		//Test GetHash in PasswordHasher and TryWrite with less than one attempts in BaseFileWorker functions
		[Theory]
		[InlineData("file1.txt", 0, "/!:&?,", "{}[]!&?*", 2)]
		[InlineData("file2.txt", -1, "тутЯкийсьПароль", "salt", 1)]
		public void GetHash_TryWriteLessOne(String path, Int32 attempts, String password, String salt, UInt32 adlerMod)
		{
			try
			{
				String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
				var result = BaseFileWorker.TryWrite(passwordHash, path, attempts);
				Assert.False(result);
			}
			catch (Exception)
			{
				
			}
		}

		//Test GetHash in PasswordHasher and Write files of different formats in BaseFileWorker functions
		[Theory]
		[InlineData("file.txt")]
		[InlineData("file")]
		[InlineData("file.")]
		[InlineData("file.jpg")]
		[InlineData("file1.avi")]
		[InlineData("file1.wrongFormat")]
		public void GetHash_WriteFormats(String path)
		{
			String password = "password";
			String salt = "salt";
			uint? adlerMod = 1;
			String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
			var result = BaseFileWorker.Write(passwordHash, path);
			Assert.True(result);
			String dataInFile = BaseFileWorker.ReadAll(path);
			Assert.Equal(passwordHash, dataInFile);
		}

		//Test GetHash in PasswordHasher and ReadLines in BaseFileWorker functions
		[Theory]
		[InlineData("file1.txt", "password", "salt", 1)]
		[InlineData("file2.txt", "pass", "", 2)]
		[InlineData("file3.txt", "/!:&?,", "{}[]!&?*", 2)]
		[InlineData("file4.txt", "тутЯкийсьПароль", "salt", 1)]
		[InlineData("file5.txt", "✌✌✌✌✌✌✌✌✌✌✌✌✌✌✌✌", "", 1)]
		[InlineData("file6.txt", "你好!你好你好你好", "", 1)]
		[InlineData("file7.txt", "\n(\\w)(\\s+)", "(?i)(<title.*?>)", 1)]
		[InlineData("file8.txt", "pass", "", UInt32.MaxValue)]
		[InlineData("file8.txt", "pass", "", UInt32.MinValue)]
		public void GetHash_ReadLines(String path, String password, String salt, UInt32 adlerMod)
		{
			String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
			var result = BaseFileWorker.Write(passwordHash, path);
			Assert.True(result);
			String[] dataInFile = BaseFileWorker.ReadLines(path);
			String lastItem = dataInFile[dataInFile.Length - 1];
			Assert.Equal(passwordHash, lastItem);
		}

		//Test LongPasswordWrite functions
		[Fact]
		public void GetHash_LongPassword()
		{
			String password = new string('a', 1000000);
			String salt = "salt";
			uint? adlerMod = 1;
			String path = "file.txt";
			String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
			var result = BaseFileWorker.Write(passwordHash, path);
			Assert.True(result);
			String dataInFile = BaseFileWorker.ReadAll(path);
			Assert.Equal(passwordHash, dataInFile);
		}

		//Test LongPathWrite functions
		[Fact]
		public void GetHash_LongPath()
		{
			String password = "pass";
			String salt = "salt";
			uint? adlerMod = 1;
			String path = new string('a', 1000000) + ".txt";
			String passwordHash = PasswordHasher.GetHash(password, salt, adlerMod);
			var result = BaseFileWorker.Write(passwordHash, path);
			Assert.True(result);
			String dataInFile = BaseFileWorker.ReadAll(path);
			Assert.Equal(passwordHash, dataInFile);
		}
	}

	public class TestBinaryFlagDatabase
	{
		private const string Server = @"DESKTOP-4EQ44MU\SQLEXPRESS";
		private const string Database = @"IIG.CoSWE.FlagpoleDB";
		private const bool IsTrusted = false;
		private const string Login = @"sa";
		private const string Password = @"pass";
		private const int ConnectionTimeout = 30;
		FlagpoleDatabaseUtils flagpoleDatabase = new FlagpoleDatabaseUtils(
			Server, Database, IsTrusted, Login, Password, ConnectionTimeout
		);

		//Test MultipleBinaryFlag setFlag for database
		[Theory]
		[InlineData(32, true, 10)]
		[InlineData(32, false, 20)]
		public void TestSetFlag(ulong len, Boolean initialValue, ulong setValue)
		{
			MultipleBinaryFlag binaryFlag = new MultipleBinaryFlag(len, initialValue);
			binaryFlag.SetFlag(setValue);
			String flagStr = binaryFlag.ToString();
			var boolean = binaryFlag.GetFlag() ?? false;
			Boolean added = flagpoleDatabase.AddFlag(flagStr, boolean);
			Assert.True(added);
		}

		//Test MultipleBinaryFlag resetFlag for database
		[Theory]
		[InlineData(32, true, 10)]
		[InlineData(32, false, 20)]
		public void TestResetFlag(ulong len, Boolean initialValue, ulong setValue)
		{
			MultipleBinaryFlag binaryFlag = new MultipleBinaryFlag(len, initialValue);
			binaryFlag.ResetFlag(setValue);
			String flagStr = binaryFlag.ToString();
			var boolean = binaryFlag.GetFlag() ?? false;
			Boolean added = flagpoleDatabase.AddFlag(flagStr, boolean);
			Assert.True(added);
		}


		//Test MultipleBinaryFlag inizialization of values that are inside of range
		[Theory]
		[InlineData(2, true)]
		[InlineData(2, false)]
		[InlineData(32, true)]
		[InlineData(32, false)]
		[InlineData(33, true)]
		[InlineData(33, false)]
		[InlineData(64, true)]
		[InlineData(64, false)]
		[InlineData(65, true)]
		[InlineData(65, false)]
		public void TestInRangeValues(ulong len, Boolean initialValue)
		{
			MultipleBinaryFlag binaryFlag = new MultipleBinaryFlag(len, initialValue);
			String flagStr = binaryFlag.ToString();
			Boolean flagValue = binaryFlag.GetFlag() ?? false;
			var boolean = binaryFlag.GetFlag() ?? false;
			Boolean added = flagpoleDatabase.AddFlag(binaryFlag.ToString(), boolean);
			Assert.True(added);
			String resultFlagStr;
			bool? resultFlagValue;
			int? flagID = flagpoleDatabase.GetIntBySql("SELECT MAX(MultipleBinaryFlagID) FROM MultipleBinaryFlags");
			Boolean got = flagpoleDatabase.GetFlag((int)flagID, out resultFlagStr, out resultFlagValue);
			Assert.True(got);
			Assert.Equal(binaryFlag.ToString(), resultFlagStr);
			Assert.Equal(flagValue, resultFlagValue);
		}

		//Test MultipleBinaryFlag inizialization of values that are out of range
		[Theory]
		[InlineData(1, true)]
		[InlineData(1, false)]
		[InlineData(17179868705, true)]
		[InlineData(17179868705, false)]
		public void TestOutOfRangeValues(ulong len, Boolean initialValue)
		{
			try
			{
				MultipleBinaryFlag binaryFlag = new MultipleBinaryFlag(len, initialValue);
				Assert.False(true);
			}
			catch (Exception)
			{
				
			}
		}

		//Test MultipleBinaryFlag inizialization of values that are wrong, must return error
		[Fact]
		public void TestWrongData()
		{
			try
			{
				String flagStr = "Some string binary flag";
				var boolean = false;
				flagpoleDatabase.AddFlag(flagStr, boolean);
				Assert.False(true);
			} catch(Exception)
			{

			}
		}
	}
}
