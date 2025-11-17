namespace EmmittJ.Terraform.Sdk.Tests.Blocks;

using EmmittJ.Terraform.Sdk.Tests.TestHelpers;

/// <summary>
/// Tests for TerraformDynamicBlock with for_each functionality.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Block")]
public class TerraformDynamicBlockTests
{
    [Fact]
    public Task DynamicBlock_SimpleForEach_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();

        // Create a resource with a dynamic block
        var resource = new TerraformResource("aws_security_group", "example");

        // Create a list to iterate over - must be ITerraformValue
        var ports = new TerraformList<int> { 80, 443, 8080 };

        // Create dynamic block content with the block type
        var ingressContent = new DynamicBlockContent("ingress");
        ingressContent["from_port"] = TerraformExpression.Identifier("ingress.value");
        ingressContent["to_port"] = TerraformExpression.Identifier("ingress.value");
        ingressContent["protocol"] = "tcp";

        // Create the dynamic block
        var dynamicBlock = new TerraformDynamicBlock<DynamicBlockContent>(ingressContent, ports)
        {
            Iterator = "ingress"
        };

        // Add to resource using SetArgument
        resource.SetArgument("ingress_dynamic", dynamicBlock);

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task DynamicBlock_WithMapForEach_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();

        var resource = new TerraformResource("aws_instance", "example");

        // Create a map to iterate over - must be ITerraformValue
        var tags = new TerraformMap<string>();
        tags["Environment"] = "Production";
        tags["Owner"] = "TeamA";

        // Create dynamic block content that uses key and value
        var tagContent = new DynamicBlockContent("tag");
        tagContent["key"] = TerraformExpression.Identifier("tag.key");
        tagContent["value"] = TerraformExpression.Identifier("tag.value");

        var dynamicBlock = new TerraformDynamicBlock<DynamicBlockContent>(tagContent, tags)
        {
            Iterator = "tag"
        };

        resource.SetArgument("tag_dynamic", dynamicBlock);

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task DynamicBlock_UsingAsDynamicExtension_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();

        var resource = new TerraformResource("aws_security_group", "web");

        // Create a TerraformValue from the variable reference expression (implicit conversion)
        TerraformValue<object> varPorts = TerraformExpression.Identifier("var.ingress_ports");

        // Create ingress block content
        var ingressContent = new DynamicBlockContent("ingress");
        ingressContent["from_port"] = TerraformExpression.Identifier("port.value");
        ingressContent["to_port"] = TerraformExpression.Identifier("port.value");
        ingressContent["protocol"] = "tcp";
        ingressContent["cidr_blocks"] = TerraformExpression.List(TerraformExpression.Literal("0.0.0.0/0"));

        // Use the AsDynamic extension method
        var dynamicBlock = ingressContent.AsDynamic(varPorts, iterator: "port");

        resource.SetArgument("ingress_dynamic", dynamicBlock);

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }
}
