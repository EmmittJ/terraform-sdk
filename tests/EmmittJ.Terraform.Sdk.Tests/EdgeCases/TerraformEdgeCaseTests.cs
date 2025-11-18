using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;

namespace EmmittJ.Terraform.Sdk.Tests.EdgeCases;

/// <summary>
/// Tests for edge cases and error scenarios in the SDK.
/// These tests verify that the SDK handles unusual or extreme conditions gracefully.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "EdgeCases")]
public class TerraformEdgeCaseTests
{
    [Fact]
    public Task StringValue_WithSpecialCharacters_EscapesCorrectly()
    {
        var resource = new TerraformResource("test", "special")
        {
            ["description"] = "Line 1\nLine 2\tTabbed\r\nWindows Line",
            ["path"] = "C:\\Users\\Test\\file.txt",
            ["quoted"] = "He said \"hello\"",
            ["mixed"] = "Path: C:\\test\nQuote: \"test\"\tTab"
        };

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task EmptyCollections_RenderCorrectly()
    {
        var resource = new TerraformResource("test", "empty")
        {
            ["empty_list"] = new TerraformList<string>(),
            ["empty_map"] = new TerraformMap<string>(),
            ["empty_set"] = new TerraformSet<string>()
        };

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task DeeplyNestedCollections_RenderCorrectly()
    {
        var resource = new TerraformResource("test", "nested");

        // Create deeply nested structure with lists and maps
        var deepMap = new TerraformMap<object>
        {
            ["deep_value"] = "success",
            ["deep_number"] = 42
        };

        var level3List = new TerraformList<object>();
        level3List.Add((object)deepMap);

        resource["config"] = new TerraformMap<object>
        {
            ["level1"] = new TerraformMap<object>
            {
                ["level2"] = new TerraformMap<object>
                {
                    ["level3"] = level3List
                }
            }
        };

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task LargeList_RendersCorrectly()
    {
        var resource = new TerraformResource("test", "large_list");

        // Create a large list using LINQ
        var numbers = Enumerable.Range(0, 100).ToArray();
        var largeList = new TerraformList<int>(numbers);

        resource["numbers"] = largeList;

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task MixedTypeMap_WithComplexValues_RendersCorrectly()
    {
        var resource = new TerraformResource("test", "mixed");

        var complexMap = new TerraformMap<object>
        {
            ["string"] = "value",
            ["number"] = 42,
            ["boolean"] = true,
            ["nested_list"] = new TerraformList<string> { "a", "b", "c" },
            ["nested_map"] = new TerraformMap<object>
            {
                ["inner"] = "value",
                ["count"] = 10
            }
        };

        resource["config"] = complexMap;

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task ResourceWithNoProperties_RendersEmptyBlock()
    {
        var resource = new TerraformResource("test", "empty");

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task StackWithManyResources_RendersCorrectly()
    {
        var stack = new TerraformStack { Name = "many_resources" };

        for (int i = 0; i < 50; i++)
        {
            stack.Add(new TerraformResource("test_resource", $"resource_{i}")
            {
                ["index"] = i,
                ["name"] = $"Resource {i}"
            });
        }

        var hcl = stack.ToHcl();
        return Verify(hcl);
    }

    [Fact]
    public Task StringValue_WithUnicodeCharacters_RendersCorrectly()
    {
        var resource = new TerraformResource("test", "unicode")
        {
            ["description"] = "Hello 世界 🌍",
            ["emoji"] = "Test 🚀 Rocket",
            ["accents"] = "Café résumé naïve",
            ["symbols"] = "€ £ ¥ © ®"
        };

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task FunctionCallExpressions_RenderCorrectly()
    {
        var resource = new TerraformResource("test", "func");

        // Use raw HCL for function calls
        resource["joined"] = TerraformExpression.Raw("join(\",\", [\"one\", \"two\", \"three\", \"four\", \"five\"])");
        resource["upper_name"] = TerraformExpression.Raw("upper(var.name)");
        resource["formatted"] = TerraformExpression.Raw("format(\"%s-%s\", var.env, var.app)");

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task ComplexExpressionNesting_RendersCorrectly()
    {
        var resource = new TerraformResource("test", "complex_expr");

        // Nested ternary: condition ? true_val : (condition2 ? true2 : false2)
        var nestedTernary = TerraformExpression.Conditional(
            TerraformExpression.Raw("var.env == \"prod\""),
            TerraformExpression.Literal("production"),
            TerraformExpression.Conditional(
                TerraformExpression.Raw("var.env == \"staging\""),
                TerraformExpression.Literal("staging"),
                TerraformExpression.Literal("development")
            )
        );

        resource["environment_name"] = nestedTernary;

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task ComplexRawExpressions_RenderCorrectly()
    {
        var resource = new TerraformResource("test", "raw_expr");

        // Complex boolean expression as raw HCL
        resource["should_deploy"] = TerraformExpression.Raw("(var.enabled && var.ready) || (var.override && var.force)");

        // Complex list comprehension
        resource["subnet_ids"] = TerraformExpression.Raw("[for s in var.subnets : s.id if s.public]");

        // Complex map comprehension
        resource["tags_map"] = TerraformExpression.Raw("{for k, v in var.tags : k => upper(v)}");

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }

    [Fact]
    public Task NumericExpressions_WithMultipleOperations_RenderCorrectly()
    {
        var resource = new TerraformResource("test", "math");

        // (10 + 5) * 2 - 3
        var mathExpr = ((TerraformExpression.Literal(10) + TerraformExpression.Literal(5))
            * TerraformExpression.Literal(2))
            - TerraformExpression.Literal(3);

        resource["calculated"] = mathExpr;

        var hcl = TerraformTestHelpers.RenderBlock(resource);
        return Verify(hcl);
    }
}
