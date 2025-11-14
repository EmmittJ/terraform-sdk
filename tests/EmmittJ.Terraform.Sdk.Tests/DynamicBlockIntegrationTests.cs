using VerifyXunit;

namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Integration tests for dynamic blocks with typed and untyped content.
/// Tests the complete workflow including .AsDynamic() and SetDynamicBlock() APIs.
/// </summary>
public class DynamicBlockIntegrationTests
{
    // Mock nested block for testing typed dynamic blocks
    private class TestNestedBlock : TerraformBlock
    {
        public override string BlockType => "test_block";

        public TestNestedBlock() : base() { }

        public TerraformValue<string>? Name
        {
            get => GetPropertyValue<TerraformValue<string>?>("name");
            set => SetPropertyValue("name", value);
        }

        public TerraformValue<int>? Port
        {
            get => GetPropertyValue<TerraformValue<int>?>("port");
            set => SetPropertyValue("port", value);
        }
    }

    // Mock resource for testing
    private class TestResource : TerraformBlock
    {
        public override string BlockType => "test_resource";

        public TestResource() : base() { }
    }

    [Fact]
    public void TypedDynamicBlock_WithAsDynamic_CreatesCorrectBlock()
    {
        // Arrange
        var variable = new TerraformVariable("test_items");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());
        var testBlock = new TestNestedBlock
        {
            Name = TerraformExpression.Identifier("item.value.name"),
            Port = TerraformExpression.Identifier("item.value.port")
        };

        // Act
        var dynamicBlock = testBlock.AsDynamic(variableRef, iterator: "item");

        // Assert
        Assert.NotNull(dynamicBlock);
        Assert.Equal("test_block", dynamicBlock.BlockTypeToGenerate);
        Assert.Equal("item", dynamicBlock.Iterator);
        Assert.Same(testBlock, dynamicBlock.Content);
    }

    [Fact]
    public void UntypedDynamicBlock_WithStringBlockType_CreatesCorrectBlock()
    {
        // Arrange
        var variable = new TerraformVariable("settings");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());

        // Act
        var dynamicBlock = new TerraformDynamicBlock("setting", variableRef);
        dynamicBlock.Content.SetPropertyValue("key", TerraformExpression.Identifier("setting.value.key"));
        dynamicBlock.Content.SetPropertyValue("value", TerraformExpression.Identifier("setting.value.value"));

        // Assert
        Assert.Equal("setting", dynamicBlock.BlockTypeToGenerate);
        Assert.NotNull(dynamicBlock.Content);
    }

    [Fact]
    public void SetDynamicBlock_WithTypedBlock_StoresInPropertySystem()
    {
        // Arrange
        var resource = new TestResource();
        var variable = new TerraformVariable("items");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());
        var testBlock = new TestNestedBlock
        {
            Name = TerraformExpression.Identifier("item.value.name")
        };
        var dynamicBlock = testBlock.AsDynamic(variableRef, iterator: "item");

        // Act
        resource.SetDynamicBlock(dynamicBlock);

        // Assert - The dynamic block should be stored in the resource's property system
        // We can verify this by checking if the property exists
        var storedValue = ((TerraformMap<object>)resource)["test_block"];
        Assert.NotNull(storedValue);
    }

    [Fact]
    public void DynamicBlock_Resolve_ReturnsDynamicBlockExpression()
    {
        // Arrange
        var variable = new TerraformVariable("rules");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());
        var testBlock = new TestNestedBlock
        {
            Port = TerraformExpression.Literal(80)
        };
        var dynamicBlock = testBlock.AsDynamic(variableRef);

        var context = TerraformContext.Temporary();

        // Act
        var expression = dynamicBlock.Resolve(context);

        // Assert
        Assert.IsType<TerraformDynamicBlockNode>(expression);
    }

    [Fact]
    public Task DynamicBlock_EndToEnd_RendersCorrectHcl()
    {
        // Arrange
        var variable = new TerraformVariable("patch_schedules");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());
        var patchSchedule = new TestNestedBlock
        {
            Name = TerraformExpression.Identifier("schedule.value.day"),
            Port = TerraformExpression.Identifier("schedule.value.hour")
        };

        var dynamicBlock = patchSchedule.AsDynamic(variableRef, iterator: "schedule");
        var context = TerraformContext.Temporary();

        // Act
        var expression = dynamicBlock.Resolve(context);
        var hcl = expression.ToHcl(context);

        // Assert
        return Verifier.Verify(hcl);
    }

    [Fact]
    public Task UntypedDynamicBlock_EndToEnd_RendersCorrectHcl()
    {
        // Arrange
        var variable = new TerraformVariable("settings");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());
        var dynamicBlock = new TerraformDynamicBlock("setting", variableRef);
        dynamicBlock.Content.SetPropertyValue("namespace", TerraformExpression.Identifier("setting.value.ns"));
        dynamicBlock.Content.SetPropertyValue("name", TerraformExpression.Identifier("setting.value.name"));
        dynamicBlock.Iterator = "setting";

        var context = TerraformContext.Temporary();

        // Act
        var expression = dynamicBlock.Resolve(context);
        var hcl = expression.ToHcl(context);

        // Assert
        return Verifier.Verify(hcl);
    }

    [Fact]
    public Task DynamicBlock_InMapExpression_RendersWithDynamicSyntax()
    {
        // Arrange
        var variable = new TerraformVariable("rules");
        var variableRef = TerraformValue.FromExpression<object>(variable.AsReference());
        var testBlock = new TestNestedBlock
        {
            Port = TerraformExpression.Literal(443)
        };
        var dynamicBlock = testBlock.AsDynamic(variableRef);

        // Create a map that would represent a resource's properties
        var resourceMap = new TerraformMapExpression();
        resourceMap["name"] = TerraformExpression.Literal("test");

        // Resolve the dynamic block and add it to the map
        var context = TerraformContext.Temporary();
        var dynamicExpr = dynamicBlock.Resolve(context);
        resourceMap["test_block"] = dynamicExpr;

        // Act
        var hcl = resourceMap.ToHcl(context);

        // Assert
        return Verifier.Verify(hcl);
    }
}
