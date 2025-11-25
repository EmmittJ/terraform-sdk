namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformExceptionTests
{
    [Fact]
    public void Constructor_Default_CreatesInstance()
    {
        var exception = new TerraformException();

        Assert.NotNull(exception);
        Assert.Null(exception.Block);
    }

    [Fact]
    public void Constructor_WithMessage_SetsMessage()
    {
        const string message = "Test error message";

        var exception = new TerraformException(message);

        Assert.Equal(message, exception.Message);
        Assert.Null(exception.Block);
    }

    [Fact]
    public void Constructor_WithMessageAndInnerException_SetsBoth()
    {
        const string message = "Test error message";
        var innerException = new InvalidOperationException("Inner exception");

        var exception = new TerraformException(message, innerException);

        Assert.Equal(message, exception.Message);
        Assert.Same(innerException, exception.InnerException);
        Assert.Null(exception.Block);
    }

    [Fact]
    public void Constructor_WithMessageAndBlock_SetsBoth()
    {
        const string message = "Test error message";
        var block = new TerraformResource("aws_instance", "test");

        var exception = new TerraformException(message, block);

        Assert.Equal(message, exception.Message);
        Assert.Same(block, exception.Block);
    }

    [Fact]
    public void Constructor_WithMessageBlockAndInnerException_SetsAll()
    {
        const string message = "Test error message";
        var block = new TerraformResource("aws_instance", "test");
        var innerException = new InvalidOperationException("Inner exception");

        var exception = new TerraformException(message, block, innerException);

        Assert.Equal(message, exception.Message);
        Assert.Same(block, exception.Block);
        Assert.Same(innerException, exception.InnerException);
    }
}
