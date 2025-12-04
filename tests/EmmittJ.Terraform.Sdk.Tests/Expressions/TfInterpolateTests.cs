using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Expressions;

/// <summary>
/// Tests for Tf.Interpolate() interpolated string handler.
/// Validates that C# string interpolation syntax produces correct Terraform string templates.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Expressions")]
public class TfInterpolateTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    [Fact]
    public Task TfInterpolate_WithLiteral()
    {
        var expr = Tf.Interpolate($"simple-string");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithVariable()
    {
        var variable = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2"
        };

        var expr = Tf.Interpolate($"prefix-{variable.AsReference()}-suffix");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithLocalsIndexer()
    {
        var locals = new TerraformLocals
        {
            ["name_prefix"] = "myapp"
        };

        var expr = Tf.Interpolate($"{locals.AsReference("name_prefix")}-web");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithResourceAttribute()
    {
        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16"
        };

        var expr = Tf.Interpolate($"vpc-{vpc.AsReference("id")}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithMultipleExpressions()
    {
        var region = new TerraformVariable("region")
        {
            Type = "string"
        };
        var environment = new TerraformVariable("environment")
        {
            Type = "string"
        };

        var expr = Tf.Interpolate($"{region.AsReference()}/{environment.AsReference()}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_ComplexInterpolation()
    {
        var locals = new TerraformLocals
        {
            ["environment"] = "prod",
            ["region"] = "us-west-2"
        };
        var vpc = new TerraformResource("aws_vpc", "main")
        {
            ["cidr_block"] = "10.0.0.0/16"
        };

        var expr = Tf.Interpolate($"{locals.AsReference("environment")}-{locals.AsReference("region")}-vpc-{vpc.AsReference("id")}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithPrimitives()
    {
        var count = 3;
        var enabled = true;

        var expr = Tf.Interpolate($"count-{count}-enabled-{enabled}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithJsonEncodeFormat()
    {
        var variable = new TerraformVariable("config")
        {
            Type = "map(string)",
            Default = new Dictionary<string, object>
            {
                ["key"] = "value"
            }
        };

        var expr = Tf.Interpolate($"encoded-{variable.AsReference():jsonencode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithSensitiveFormat()
    {
        var variable = new TerraformVariable("password")
        {
            Type = "string",
            Sensitive = true
        };

        var expr = Tf.Interpolate($"secret-{variable.AsReference():sensitive}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithBase64EncodeFormat()
    {
        var variable = new TerraformVariable("data")
        {
            Type = "string",
            Default = "hello world"
        };

        var expr = Tf.Interpolate($"encoded-{variable.AsReference():base64encode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithBase64DecodeFormat()
    {
        var variable = new TerraformVariable("encoded_data")
        {
            Type = "string",
            Default = "aGVsbG8gd29ybGQ="
        };

        var expr = Tf.Interpolate($"decoded-{variable.AsReference():base64decode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithUriFormat()
    {
        var variable = new TerraformVariable("url_part")
        {
            Type = "string",
            Default = "hello world"
        };

        var expr = Tf.Interpolate($"url-{variable.AsReference():uri}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithBraceEscaping()
    {
        var variable = new TerraformVariable("name")
        {
            Type = "string",
            Default = "example"
        };

        var expr = Tf.Interpolate($"{{\"name\": \"{variable.AsReference()}\", \"type\": \"value\"}}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithFormatOnResolvable()
    {
        // Test format specifier on ITerraformResolvable (via indexer)
        var locals = new TerraformLocals
        {
            ["config"] = new Dictionary<string, string> { ["key"] = "value" }
        };

        var expr = Tf.Interpolate($"config-{locals.AsReference("config"):jsonencode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithFormatOnPrimitive()
    {
        // Test format specifier on primitive value
        var value = "hello world";

        var expr = Tf.Interpolate($"encoded-{value:base64encode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithMultipleFormats()
    {
        // Test multiple format specifiers in same expression
        var locals = new TerraformLocals
        {
            ["data"] = "plain text",
            ["config"] = new Dictionary<string, string> { ["key"] = "value" }
        };

        var expr = Tf.Interpolate($"data-{locals.AsReference("data"):base64encode}-config-{locals.AsReference("config"):jsonencode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }

    [Fact]
    public Task TfInterpolate_WithMixedFormattedAndUnformatted()
    {
        // Test mixing formatted and unformatted expressions
        var locals = new TerraformLocals
        {
            ["name"] = "myapp",
            ["config"] = new Dictionary<string, string> { ["key"] = "value" }
        };

        var expr = Tf.Interpolate($"{locals.AsReference("name")}-{locals.AsReference("config"):jsonencode}");
        var hcl = expr.ToHcl(CreateContext());

        return Verify(hcl);
    }
}
