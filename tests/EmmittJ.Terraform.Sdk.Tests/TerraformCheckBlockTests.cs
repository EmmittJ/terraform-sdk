namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformCheckBlockTests
{
    [Fact]
    public void BlockType_ReturnsCheck()
    {
        var checkBlock = new TerraformCheckBlock { Name = "health_check" };

        Assert.Equal("check", checkBlock.BlockType);
    }

    [Fact]
    public void BlockLabels_ReturnsNameInArray()
    {
        var checkBlock = new TerraformCheckBlock { Name = "health_check" };

        Assert.Equal(["health_check"], checkBlock.BlockLabels);
    }

    [Fact]
    public void AddDataSource_AddsToCollection()
    {
        var checkBlock = new TerraformCheckBlock { Name = "health_check" };
        var dataSource = new TerraformDataSource("http", "example")
        {
            ["url"] = "https://example.com"
        };

        var result = checkBlock.AddDataSource(dataSource);

        Assert.Same(checkBlock, result);
        Assert.Single(checkBlock.DataSources);
        Assert.Contains(dataSource, checkBlock.DataSources);
    }

    [Fact]
    public void AddDataSource_WithNull_ThrowsArgumentNullException()
    {
        var checkBlock = new TerraformCheckBlock { Name = "health_check" };

        Assert.Throws<ArgumentNullException>(() => checkBlock.AddDataSource(null!));
    }

    [Fact]
    public void AddAssert_WithNull_ThrowsArgumentNullException()
    {
        var checkBlock = new TerraformCheckBlock { Name = "health_check" };

        Assert.Throws<ArgumentNullException>(() => checkBlock.AddAssert(null!));
    }
}
