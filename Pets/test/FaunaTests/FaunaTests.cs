using System;
using NUnit.Framework;
using Pets;

public class AllAniamlsTests
{
    [Test]
    public void BearSound()
    {
        string expected = "Broar!";
        string actual = new Bear().MakeSound();

        Assert.AreEqual(expected, actual, "Bear sound!");
    }
    
    [Test]
    public void ElephantSound()
    {
        string expected = "Pawoooo!";
        string actual = new Elephant().MakeSound();

        Assert.AreEqual(expected, actual, "Elephant sound!");
    }

    [Test]
    public void TigerSound()
    {
        string expected = "Roar!";
        string actual = new Tiger().MakeSound();

        Assert.AreEqual(expected, actual, "Tiger sound!");
    }

    [Test]
    public void WolfSound()
    {
        string expected = "Groar!";
        string actual = new Wolf().MakeSound();

        Assert.AreEqual(expected, actual, "Wolf sound!");
    }
   



}
