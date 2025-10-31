using EmmittJ.Terraform.Sdk.Constructs;
using EmmittJ.Terraform.Sdk.Core;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformCheckBlockTests
{
    [Fact]
    public Task CheckBlock_SimpleAssert_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test");

        var check = new TerraformCheckBlock("health_check");
        check.AddAssert(new TerraformAssertBlock(
            condition: "var.enable_health_check == true",
            errorMessage: "Health check must be enabled"
        ));

        config.Add(check);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CheckBlock_WithDataSource_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test");

        var check = new TerraformCheckBlock("api_check");

        // Add a data source
        var httpCheck = new TerraformDataSource("http", "api_status")
            .WithProperty("url", "https://api.example.com/health");
        check.AddDataSource(httpCheck);

        // Add assertion
        check.AddAssert(new TerraformAssertBlock(
            condition: "data.http.api_status.status_code == 200",
            errorMessage: "API health check failed"
        ));

        config.Add(check);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CheckBlock_MultipleAsserts_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test");

        var check = new TerraformCheckBlock("resource_validation");

        check.AddAssert(new TerraformAssertBlock(
            condition: "length(aws_instance.web) > 0",
            errorMessage: "At least one web instance is required"
        ));

        check.AddAssert(new TerraformAssertBlock(
            condition: "aws_instance.web[0].instance_type != \"t2.micro\"",
            errorMessage: "Production instances must not use t2.micro"
        ));

        check.AddAssert(new TerraformAssertBlock(
            condition: "contains([\"us-east-1\", \"us-west-2\"], aws_instance.web[0].availability_zone)",
            errorMessage: "Instance must be in an approved availability zone"
        ));

        config.Add(check);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CheckBlock_WithDataSourceAndMultipleAsserts_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test");

        var check = new TerraformCheckBlock("external_validation");

        // Add data source to fetch external data
        var externalData = new TerraformDataSource("http", "external_config")
            .WithProperty("url", "https://config.example.com/settings.json");
        check.AddDataSource(externalData);

        // Multiple assertions
        check.AddAssert(new TerraformAssertBlock(
            condition: "data.http.external_config.status_code == 200",
            errorMessage: "Failed to fetch external configuration"
        ));

        check.AddAssert(new TerraformAssertBlock(
            condition: "jsondecode(data.http.external_config.response_body).enabled == true",
            errorMessage: "External configuration indicates feature is not enabled"
        ));

        config.Add(check);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CheckBlock_MultipleDataSources_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test");

        var check = new TerraformCheckBlock("multi_source_check");

        // Multiple data sources
        check.AddDataSource(new TerraformDataSource("http", "endpoint_a")
            .WithProperty("url", "https://a.example.com/health"));

        check.AddDataSource(new TerraformDataSource("http", "endpoint_b")
            .WithProperty("url", "https://b.example.com/health"));

        // Assertions using both data sources
        check.AddAssert(new TerraformAssertBlock(
            condition: "data.http.endpoint_a.status_code == 200",
            errorMessage: "Endpoint A health check failed"
        ));

        check.AddAssert(new TerraformAssertBlock(
            condition: "data.http.endpoint_b.status_code == 200",
            errorMessage: "Endpoint B health check failed"
        ));

        config.Add(check);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CheckBlock_ComplexConditions_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test");

        var check = new TerraformCheckBlock("complex_validation");

        check.AddAssert(new TerraformAssertBlock(
            condition: "alltrue([for instance in aws_instance.web : instance.monitoring == true])",
            errorMessage: "All instances must have monitoring enabled"
        ));

        check.AddAssert(new TerraformAssertBlock(
            condition: "can(regex(\"^prod-\", var.environment_name))",
            errorMessage: "Production environment name must start with 'prod-'"
        ));

        config.Add(check);

        return Verify(config.ToHcl());
    }

    [Fact]
    public void CheckBlock_NameIsNull_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformCheckBlock(null!)
        );

        Assert.Contains("name cannot be null or empty", exception.Message);
    }

    [Fact]
    public void CheckBlock_NameIsEmpty_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformCheckBlock("")
        );

        Assert.Contains("name cannot be null or empty", exception.Message);
    }

    [Fact]
    public void AssertBlock_ConditionIsNull_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformAssertBlock(null!, "error message")
        );

        Assert.Contains("condition cannot be null or empty", exception.Message);
    }

    [Fact]
    public void AssertBlock_ErrorMessageIsNull_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformAssertBlock("true", null!)
        );

        Assert.Contains("error message cannot be null or empty", exception.Message);
    }

    [Fact]
    public void CheckBlock_AsReference_ThrowsNotSupportedException()
    {
        var check = new TerraformCheckBlock("test_check");

        Assert.Throws<NotSupportedException>(() => check.AsReference());
    }

    [Fact]
    public void CheckBlock_FluentInterface_WorksCorrectly()
    {
        var check = new TerraformCheckBlock("fluent_test");

        // Test fluent chaining
        var result = check
            .AddAssert(new TerraformAssertBlock("true", "first"))
            .AddAssert(new TerraformAssertBlock("true", "second"));

        Assert.Same(check, result);
    }
}
