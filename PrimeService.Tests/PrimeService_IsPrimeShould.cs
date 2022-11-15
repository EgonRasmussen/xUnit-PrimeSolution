using Xunit;

namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    [Fact]
    public void Isrime()
    {
        // Arrange
        PrimeServiceLib.PrimeService _primeService = new PrimeServiceLib.PrimeService();
        // Act
        var result = _primeService.IsPrime(1);
        // Assert
        Assert.False(result, $"{1} should not be prime");
    }


    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
        // Arrange
        PrimeServiceLib.PrimeService _primeService = new PrimeServiceLib.PrimeService();
        // Act
        var result = _primeService.IsPrime(value);
        // Assert
        Assert.False(result, $"{value} should not be prime");
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
    {
        // Arrange
        PrimeServiceLib.PrimeService _primeService = new PrimeServiceLib.PrimeService();
        // Act
        var result = _primeService.IsPrime(value);
        // Assert
        Assert.True(result, $"{value} should be prime");
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
    {
        // Arrange
        PrimeServiceLib.PrimeService _primeService = new PrimeServiceLib.PrimeService();
        // Act
        var result = _primeService.IsPrime(value);
        // Assert
        Assert.False(result, $"{value} should not be prime");
    }
}