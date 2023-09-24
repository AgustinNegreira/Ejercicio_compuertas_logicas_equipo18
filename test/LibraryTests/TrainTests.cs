using System;
using Gates;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    [Test] 
    public void TestAND()  // Testeamos la puerta lógica AND
    {
        Assert.That(ANDGates.Evaluar(true, true), Is.EqualTo(true));
        Assert.That(ANDGates.Evaluar(true, false), Is.EqualTo(false));
        Assert.That(ANDGates.Evaluar(false, true), Is.EqualTo(false));
        Assert.That(ANDGates.Evaluar(false, false), Is.EqualTo(false));

    }

    [Test]
    public void TestOR()// Testeamos la puerta lógica OR
    {
        Assert.That(ORGates.Evaluar(true, true), Is.EqualTo(true));
        Assert.That(ORGates.Evaluar(true, false), Is.EqualTo(true));
        Assert.That(ORGates.Evaluar(false, true), Is.EqualTo(true));
        Assert.That(ORGates.Evaluar(false, false), Is.EqualTo(false));
    }
    [Test]

    public void TestNOT()// Testeamos la puerta lógica NOT
    {
        Assert.That(NOTGates.Evaluar(true), Is.EqualTo(false));
        Assert.That(NOTGates.Evaluar(false), Is.EqualTo(true));
    }

}

