using System;
using Xunit;
using IIG.BinaryFlag;

namespace cse_lab3
{
  //Here we test variant where we can get 
  //UintConcreateBinaryFlag in constructor if len is from 2 to 32
  //ULongConcreateBinaryFlag in constructor if len is from 33 to 64
  //UintArrayConcreateBinaryFlag in constructor if len is from 65 to 17179868704
  public class ConstructorTests
  {

    [Fact]
    public void Length1Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, true);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length1Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, false);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length2Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, true);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length2Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, false);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, true);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, false);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, true);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, false);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, true);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, false);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, true);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, false);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length17179868705Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, true);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length17179868705Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, false);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

  }

  //Here we test variant where we can get 
  //UintConcreateBinaryFlag in constructor if len is from 2 to 32
  //ULongConcreateBinaryFlag in constructor if len is from 33 to 64
  //UintArrayConcreateBinaryFlag in constructor if len is from 65 to 17179868704
  public class getFlagTests
	{
    [Fact]
    public void Length1Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length1Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length2Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.True(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length2Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.False(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.True(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.False(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.True(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.False(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.True(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.False(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.True(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.NotNull(flag);
        Assert.False(flag);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length17179868705Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, true);
        bool? flag = binaryFlag.GetFlag();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length17179868705Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, false);
        bool? flag = binaryFlag.GetFlag();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }
  }

  //Here we test variant where we can get 
  //UintConcreateBinaryFlag in constructor if len is from 2 to 32
  //ULongConcreateBinaryFlag in constructor if len is from 33 to 64
  //UintArrayConcreateBinaryFlag in constructor if len is from 65 to 17179868704
  public class disposeTests
	{
    [Fact]
    public void Length1Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, true);
        binaryFlag.Dispose();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length1Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, false);
        binaryFlag.Dispose();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length2Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, true);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length2Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, false);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, true);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, false);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, true);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, false);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, true);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, false);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, true);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, false);
        binaryFlag.Dispose();
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length17179868705Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, true);
        binaryFlag.Dispose();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length17179868705Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, false);
        binaryFlag.Dispose();
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }
  }

  //Here we test variant where we can get 
  //UintConcreateBinaryFlag in constructor if len is from 2 to 32
  //ULongConcreateBinaryFlag in constructor if len is from 33 to 64
  //UintArrayConcreateBinaryFlag in constructor if len is from 65 to 17179868704
  public class setFlagText
	{
    [Fact]
    public void Length1Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, true);
        binaryFlag.SetFlag(0);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length1Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, false);
        binaryFlag.SetFlag(0);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length2Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, true);
        binaryFlag.SetFlag(0);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length2Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, false);
        binaryFlag.SetFlag(0);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, true);
        binaryFlag.SetFlag(21);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, false);
        binaryFlag.SetFlag(23);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, true);
        binaryFlag.SetFlag(10);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, false);
        binaryFlag.SetFlag(11);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, true);
        binaryFlag.SetFlag(11);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, false);
        binaryFlag.SetFlag(0);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, true);
        binaryFlag.SetFlag(58);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, false);
        binaryFlag.SetFlag(34);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length17179868705Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, true);
        binaryFlag.SetFlag(5811247364);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length17179868705Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, false);
        binaryFlag.SetFlag(16171325260);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }
  }

  //Here we test variant where we can get 
  //UintConcreateBinaryFlag in constructor if len is from 2 to 32
  //ULongConcreateBinaryFlag in constructor if len is from 33 to 64
  //UintArrayConcreateBinaryFlag in constructor if len is from 65 to 17179868704
  public class ResetFlagTests
	{
    [Fact]
    public void Length1Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, true);
        binaryFlag.ResetFlag(0);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length1Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(1, false);
        binaryFlag.ResetFlag(0);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length2Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, true);
        binaryFlag.ResetFlag(0);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length2Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(2, false);
        binaryFlag.ResetFlag(0);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, true);
        binaryFlag.ResetFlag(21);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length32Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(32, false);
        binaryFlag.ResetFlag(23);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, true);
        binaryFlag.ResetFlag(10);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length33Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(33, false);
        binaryFlag.ResetFlag(11);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, true);
        binaryFlag.ResetFlag(11);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length64Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(64, false);
        binaryFlag.ResetFlag(0);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, true);
        binaryFlag.ResetFlag(58);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length65Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(65, false);
        binaryFlag.ResetFlag(34);
        Assert.True(true);
      }
      catch (Exception e)
      {
        Assert.False(true);
      }
    }

    [Fact]
    public void Length17179868705Initialtrue()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, true);
        binaryFlag.ResetFlag(5811247364);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

    [Fact]
    public void Length17179868705Initialfalse()
    {
      try
      {
        var binaryFlag = new MultipleBinaryFlag(17179868705, false);
        binaryFlag.ResetFlag(16171325260);
        Assert.False(true);
      }
      catch (Exception e)
      {
        Assert.True(true);
      }
    }

  }
}
