namespace EmmittJ.Terraform.Sdk.Tests;

public class TfTests
{
    [Fact]
    public Task CidrSubnet_WithExpressions_GeneratesHcl()
    {
        var vpcCidr = new TerraformVariable("vpc_cidr");
        var subnet = Tf.Functions.CidrSubnet(vpcCidr.GetReferenceExpression(), 8, TerraformExpression.Literal(0));

        return Verify(subnet.ToHcl());
    }

    [Fact]
    public Task CidrSubnet_WithLiterals_GeneratesHcl()
    {
        var subnet = Tf.Functions.CidrSubnet("10.0.0.0/16", 8, 0);

        return Verify(subnet.ToHcl());
    }

    [Fact]
    public Task Length_WithListExpression_GeneratesHcl()
    {
        var list = TerraformExpression.Raw("[\"a\", \"b\", \"c\"]");
        var length = Tf.Functions.Length(list);

        return Verify(length.ToHcl());
    }

    [Fact]
    public Task Element_WithExpressions_GeneratesHcl()
    {
        var list = TerraformExpression.Raw("[\"a\", \"b\", \"c\"]");
        var index = TerraformExpression.Literal(1);
        var element = Tf.Functions.Element(list, index);

        return Verify(element.ToHcl());
    }

    [Fact]
    public Task Element_WithLiteralIndex_GeneratesHcl()
    {
        var list = TerraformExpression.Raw("[\"a\", \"b\", \"c\"]");
        var element = Tf.Functions.Element(list, 1);

        return Verify(element.ToHcl());
    }

    [Fact]
    public Task Join_WithSeparatorAndList_GeneratesHcl()
    {
        var list = TerraformExpression.Raw("[\"foo\", \"bar\", \"baz\"]");
        var joined = Tf.Functions.Join(", ", list);

        return Verify(joined.ToHcl());
    }

    [Fact]
    public Task Format_WithMultipleArguments_GeneratesHcl()
    {
        var name = new TerraformVariable("name");
        var region = new TerraformVariable("region");
        var formatted = Tf.Functions.Format("%s-%s-bucket", name.GetReferenceExpression(), region.GetReferenceExpression());

        return Verify(formatted.ToHcl());
    }

    [Fact]
    public Task Lookup_WithTwoArguments_GeneratesHcl()
    {
        var map = TerraformExpression.Raw("{production = \"prod\", development = \"dev\"}");
        var key = TerraformExpression.Literal("production");
        var value = Tf.Functions.Lookup(map, key);

        return Verify(value.ToHcl());
    }

    [Fact]
    public Task Lookup_WithThreeArguments_GeneratesHcl()
    {
        var map = TerraformExpression.Raw("{production = \"prod\"}");
        var key = TerraformExpression.Literal("staging");
        var defaultValue = TerraformExpression.Literal("default");
        var value = Tf.Functions.Lookup(map, key, defaultValue);

        return Verify(value.ToHcl());
    }

    [Fact]
    public Task Lookup_WithStringKey_GeneratesHcl()
    {
        var map = TerraformExpression.Raw("{production = \"prod\"}");
        var value = Tf.Functions.Lookup(map, "production");

        return Verify(value.ToHcl());
    }

    [Fact]
    public Task Concat_WithMultipleLists_GeneratesHcl()
    {
        var list1 = TerraformExpression.Raw("[\"a\", \"b\"]");
        var list2 = TerraformExpression.Raw("[\"c\", \"d\"]");
        var list3 = TerraformExpression.Raw("[\"e\", \"f\"]");
        var concatenated = Tf.Functions.Concat(list1, list2, list3);

        return Verify(concatenated.ToHcl());
    }

    [Fact]
    public Task File_WithLiteralPath_GeneratesHcl()
    {
        var contents = Tf.Functions.File("./config.json");

        return Verify(contents.ToHcl());
    }

    [Fact]
    public Task File_WithExpression_GeneratesHcl()
    {
        var path = new TerraformVariable("config_path");
        var contents = Tf.Functions.File(path.GetReferenceExpression());

        return Verify(contents.ToHcl());
    }

    [Fact]
    public Task Range_WithMax_GeneratesHcl()
    {
        var range = Tf.Functions.Range(5);

        return Verify(range.ToHcl());
    }

    [Fact]
    public Task Range_WithStartAndLimit_GeneratesHcl()
    {
        var range = Tf.Functions.Range(1, 10);

        return Verify(range.ToHcl());
    }

    [Fact]
    public Task Range_WithStartLimitAndStep_GeneratesHcl()
    {
        var range = Tf.Functions.Range(0, 10, 2);

        return Verify(range.ToHcl());
    }

    [Fact]
    public Task ToString_WithValue_GeneratesHcl()
    {
        var number = TerraformExpression.Literal(42);
        var str = Tf.Functions.ToString(number);

        return Verify(str.ToHcl());
    }

    [Fact]
    public Task ToNumber_WithValue_GeneratesHcl()
    {
        var str = TerraformExpression.Literal("42");
        var number = Tf.Functions.ToNumber(str);

        return Verify(number.ToHcl());
    }

    [Fact]
    public Task ToBool_WithValue_GeneratesHcl()
    {
        var str = TerraformExpression.Literal("true");
        var boolean = Tf.Functions.ToBool(str);

        return Verify(boolean.ToHcl());
    }

    [Fact]
    public Task ToList_WithValue_GeneratesHcl()
    {
        var set = TerraformExpression.Raw("toset([\"a\", \"b\"])");
        var list = Tf.Functions.ToList(set);

        return Verify(list.ToHcl());
    }

    [Fact]
    public Task ToMap_WithValue_GeneratesHcl()
    {
        var obj = TerraformExpression.Raw("{a = 1, b = 2}");
        var map = Tf.Functions.ToMap(obj);

        return Verify(map.ToHcl());
    }

    [Fact]
    public Task ToSet_WithValue_GeneratesHcl()
    {
        var list = TerraformExpression.Raw("[\"a\", \"b\", \"a\"]");
        var set = Tf.Functions.ToSet(list);

        return Verify(set.ToHcl());
    }

    [Fact]
    public Task Merge_WithMultipleMaps_GeneratesHcl()
    {
        var map1 = TerraformExpression.Raw("{a = 1, b = 2}");
        var map2 = TerraformExpression.Raw("{c = 3, d = 4}");
        var map3 = TerraformExpression.Raw("{e = 5}");
        var merged = Tf.Functions.Merge(map1, map2, map3);

        return Verify(merged.ToHcl());
    }

    [Fact]
    public Task Function_WithCustomFunction_GeneratesHcl()
    {
        var arg1 = TerraformExpression.Literal("value1");
        var arg2 = TerraformExpression.Literal(42);
        var result = Tf.Functions.Function("custom_function", arg1, arg2);

        return Verify(result.ToHcl());
    }

    [Fact]
    public Task CidrSubnet_InResourceConfiguration_GeneratesHcl()
    {
        var vpcCidr = new TerraformVariable("vpc_cidr");
        var subnet = new TerraformResource("aws_subnet", "example")
            .Set("cidr_block", Tf.Functions.CidrSubnet(vpcCidr.GetReferenceExpression(), 8, TerraformExpression.Literal(1)));

        return Verify(subnet.ToHcl());
    }

    [Fact]
    public Task ComplexExpression_WithNestedFunctions_GeneratesHcl()
    {
        // format("subnet-%s", element(split("-", var.name), 0))
        var varName = new TerraformVariable("name");
        var split = Tf.Functions.Function("split", TerraformExpression.Literal("-"), varName.GetReferenceExpression());
        var element = Tf.Functions.Element(split, 0);
        var formatted = Tf.Functions.Format("subnet-%s", element);

        return Verify(formatted.ToHcl());
    }

    [Fact]
    public Task CidrSubnet_WithForLoop_GeneratesHcl()
    {
        // [for i in range(3) : cidrsubnet(var.vpc_cidr, 8, i)]
        var vpcCidr = new TerraformVariable("vpc_cidr");
        var local = new TerraformLocal()
            .Set("subnet_cidrs", TerraformExpression.Raw("[for i in range(3) : cidrsubnet(var.vpc_cidr, 8, i)]"));

        return Verify(local.ToHcl());
    }
}
