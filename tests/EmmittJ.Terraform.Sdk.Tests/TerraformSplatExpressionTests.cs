namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformSplatExpressionTests
{
    [Fact]
    public Task Splat_AllElements_GeneratesCorrectHcl()
    {
        var output = new TerraformOutput("all_ids")
        {
            Value = TerraformExpression.Splat(TerraformExpression.Identifier("var.instance_list"))
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_WithAttribute_GeneratesCorrectHcl()
    {
        var output = new TerraformOutput("instance_ids")
        {
            Value = TerraformExpression.Splat(
                TerraformExpression.Identifier("aws_instance.web"),
                "id")
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_ExtensionMethod_AllElements_GeneratesCorrectHcl()
    {
        var output = new TerraformOutput("all_items")
        {
            Value = TerraformExpression.Identifier("var.items").Splat()
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_ExtensionMethod_WithAttribute_GeneratesCorrectHcl()
    {
        var output = new TerraformOutput("public_ips")
        {
            Value = TerraformExpression.Identifier("aws_instance.servers").Splat("public_ip")
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_NestedAttribute_GeneratesCorrectHcl()
    {
        // This creates: aws_instance.web[*].network_interface
        var splatExpr = TerraformExpression.Identifier("aws_instance.web").Splat("network_interface");

        var output = new TerraformOutput("network_interfaces")
        {
            Value = splatExpr
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_InForExpression_GeneratesCorrectHcl()
    {
        // [for id in aws_instance.web[*].id : upper(id)]
        var splatIds = TerraformExpression.Identifier("aws_instance.web").Splat("id");
        var forExpr = TerraformExpression.ForList("id", splatIds,
            TerraformExpressionExtensions.Call("upper", TerraformExpression.Identifier("id")));

        var output = new TerraformOutput("uppercase_ids")
        {
            Value = forExpr
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_WithFunctionCall_GeneratesCorrectHcl()
    {
        // join(",", aws_instance.web[*].id)
        var splatIds = TerraformExpression.Identifier("aws_instance.web").Splat("id");
        var joinExpr = TerraformExpressionExtensions.Call("join",
            TerraformExpression.Literal(","),
            splatIds);

        var output = new TerraformOutput("joined_ids")
        {
            Value = joinExpr
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_DataSource_GeneratesCorrectHcl()
    {
        var output = new TerraformOutput("ami_ids")
        {
            Value = TerraformExpression.Identifier("data.aws_ami.ubuntu").Splat("image_id")
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Splat_InLocalValue_GeneratesCorrectHcl()
    {
        var local = new TerraformLocal()
            ["instance_private_ips"] = TerraformExpression.Identifier("aws_instance.app").Splat("private_ip"));

        return Verify(local.Resolve());
    }

    [Fact]
    public Task Splat_MultipleOutputs_GeneratesCorrectHcl()
    {
        var output1 = new TerraformOutput("web_ids")
        {
            Value = TerraformExpression.Identifier("aws_instance.web").Splat("id")
        };

        var output2 = new TerraformOutput("app_ips")
        {
            Value = TerraformExpression.Identifier("aws_instance.app").Splat("private_ip")
        };

        var output3 = new TerraformOutput("db_arns")
        {
            Value = TerraformExpression.Identifier("aws_db_instance.main").Splat("arn")
        };

        var combined = $"{output1.Resolve()}\n\n{output2.Resolve()}\n\n{output3.Resolve()}";
        return Verify(combined);
    }

    [Fact]
    public void Splat_NullSource_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            TerraformExpression.Splat(null!));
    }

    [Fact]
    public void Splat_NullSourceWithAttribute_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            TerraformExpression.Splat(null!, "id"));
    }

    [Fact]
    public void Splat_NullAttribute_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            TerraformExpression.Splat(TerraformExpression.Identifier("test"), null!));
    }
}
