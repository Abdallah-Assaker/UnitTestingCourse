using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit;

public class CalculatorTests(ITestOutputHelper output) : IAsyncLifetime
{
    private readonly Calculator _sut = new();

    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(-5, 5, 0)]
    [InlineData(-15, -5, -20)]
    public void Add_WhenAddingTwoNumbers_ShouldReturnTheSum(int a, int b, int expected)
    {
        output.WriteLine("Add_WhenAddingTwoNumbers_ShouldReturnTheSum...");
        
        // Arrange
        
        // Act
    
        var result = _sut.Add(a, b);
        
        // Assert
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(15, 5, 10)]
    [InlineData(-5, -5, 0)]
    [InlineData(-15, -5, -10)]
    [InlineData(5, 10, -5)]
    public void Subtract_WhenSubtractingTwoNumbers_ShouldReturnTheDifference(int a, int b, int expected)
    {
        output.WriteLine("Subtract_WhenSubtractingTwoNumbers_ShouldReturnTheDifference...");
        
        // Arrange
        
        // Act
    
        var result = _sut.Subtract(a, b);
        
        // Assert
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(50, 0, 0)]
    [InlineData(-5, 5, -25)]
    public void Multiply_WhenMultiplyingTwoNumbers_ShouldReturnTheProduct(int a, int b, int expected)
    {
        output.WriteLine("Multiply_WhenMultiplyingTwoNumbers_ShouldReturnTheProduct...");
        
        // Arrange
        
        // Act
    
        var result = _sut.Multiply(a, b);
        
        // Assert
        
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(5, 5, 1)]
    [InlineData(15, 5, 3)]
    public void Divide_WhenDividingTwoNumbers_ShouldReturnTheQuotient(float a, float b, float expected)
    {
        output.WriteLine("Divide_WhenDividingTwoNumbers_ShouldReturnTheQuotient...");
        
        // Arrange
        
        // Act
    
        var result = _sut.Divide(a, b);
        
        // Assert
        
        Assert.Equal(expected, result);
    }
    
    public Task InitializeAsync()
    {
        output.WriteLine("Initialize...");
        
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        output.WriteLine("Dispose...");
        
        return Task.CompletedTask;
    }
}