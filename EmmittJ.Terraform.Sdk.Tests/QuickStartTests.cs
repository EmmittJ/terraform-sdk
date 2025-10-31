namespace EmmittJ.Terraform.Sdk.Tests;

public class QuickStartTests
{
    [Fact]
    public Task AwsVpcExample_Generates_ValidHcl()
    {
        // Arrange & Act
        var config = QuickStartExample.CreateAwsVpcExample();
        var hcl = config.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task SimpleExample_Generates_ValidHcl()
    {
        // Arrange & Act
        var config = QuickStartExample.CreateSimpleExample();
        var hcl = config.ToHcl();

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task FunctionExample_Generates_ValidHcl()
    {
        // Arrange & Act
        var config = QuickStartExample.CreateFunctionExample();
        var hcl = config.ToHcl();

        // Assert
        return Verify(hcl);
    }
}
