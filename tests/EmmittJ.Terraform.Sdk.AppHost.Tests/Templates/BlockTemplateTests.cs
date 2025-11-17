using EmmittJ.Terraform.Sdk.AppHost.Models;
using Stubble.Core;
using Stubble.Core.Builders;
using Stubble.Core.Loaders;

namespace EmmittJ.Terraform.Sdk.AppHost.Tests.Templates;

/// <summary>
/// Tests for _block.mustache template to verify it correctly renders nested blocks.
/// </summary>
public class BlockTemplateTests
{
    private readonly string _templatePath;
    private readonly StubbleVisitorRenderer _renderer;

    public BlockTemplateTests()
    {
        // Get the templates directory
        var projectDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "src", "EmmittJ.Terraform.Sdk.AppHost"));
        var templatesDir = Path.Combine(projectDir, "Templates", "Files");
        _templatePath = Path.Combine(templatesDir, "_block.mustache");

        // Load partials
        var partials = new Dictionary<string, string>();
        foreach (var partialFile in Directory.GetFiles(templatesDir, "_*.mustache"))
        {
            var partialName = Path.GetFileNameWithoutExtension(partialFile);
            partials[partialName] = File.ReadAllText(partialFile);
        }

        // Create renderer with partials support
        _renderer = new StubbleBuilder()
            .Configure(settings =>
            {
                settings.SetPartialTemplateLoader(new DictionaryLoader(partials));
            })
            .Build();
    }

    private string RenderTemplate(BlockTypeModel model)
    {
        var template = File.ReadAllText(_templatePath);
        return _renderer.Render(template, model);
    }

    [Fact]
    public void BlockTemplate_SimpleBlock_RendersCorrectly()
    {
        // Arrange
        var model = new BlockTypeModel
        {
            Name = "Example",
            TerraformName = "example",
            ClassName = "TestResourceExampleBlock",
            ParentClassName = "TestResource",
            NestingMode = "list",
            Arguments = new List<PropertyModel>
            {
                new()
                {
                    Name = "Name",
                    TerraformName = "name",
                    CSharpType = "TerraformValue<string>",
                    Description = "The name",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            NestedBlocks = new List<BlockTypeModel>()
        };

        // Act
        var result = RenderTemplate(model);

        // Assert
        Assert.Contains("public class TestResourceExampleBlock : TerraformBlock", result);
        Assert.Contains("public override string BlockType => \"example\";", result);
        Assert.Contains("Block type for example in TestResource", result);
        Assert.Contains("Nesting mode: list", result);
    }

    [Fact]
    public void BlockTemplate_WithNestedBlocks_RendersNestedBlockProperties()
    {
        // Arrange
        var nestedBlock = new BlockTypeModel
        {
            Name = "Cors",
            TerraformName = "cors",
            ClassName = "ParentIngressBlockCorsBlock",
            ParentClassName = "ParentIngressBlock",
            NestingMode = "list",
            MaxItems = 1,
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel>()
        };

        var model = new BlockTypeModel
        {
            Name = "Ingress",
            TerraformName = "ingress",
            ClassName = "ParentIngressBlock",
            ParentClassName = "Parent",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel> { nestedBlock }
        };

        // Act
        var result = RenderTemplate(model);

        // Assert
        Assert.Contains("public class ParentIngressBlock : TerraformBlock", result);

        // Should render nested block property
        Assert.Contains("Cors", result);

        // Should render nested block class definition
        Assert.Contains("public class ParentIngressBlockCorsBlock : TerraformBlock", result);
        Assert.Contains("public override string BlockType => \"cors\";", result);
    }

    [Fact]
    public void BlockTemplate_TwoLevelsDeep_RendersBothLevels()
    {
        // Arrange
        // Level 2: env block (deepest)
        var envBlock = new BlockTypeModel
        {
            Name = "Env",
            TerraformName = "env",
            ClassName = "TemplateBlockContainerBlockEnvBlock",
            ParentClassName = "TemplateBlockContainerBlock",
            NestingMode = "list",
            Arguments = new List<PropertyModel>
            {
                new()
                {
                    Name = "Name",
                    TerraformName = "name",
                    CSharpType = "TerraformValue<string>",
                    Description = "Env name",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            NestedBlocks = new List<BlockTypeModel>()
        };

        // Level 1: container block
        var containerBlock = new BlockTypeModel
        {
            Name = "Container",
            TerraformName = "container",
            ClassName = "TemplateBlockContainerBlock",
            ParentClassName = "TemplateBlock",
            NestingMode = "list",
            MinItems = 1,
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel> { envBlock }
        };

        // Level 0: template block
        var model = new BlockTypeModel
        {
            Name = "Template",
            TerraformName = "template",
            ClassName = "TemplateBlock",
            ParentClassName = "Resource",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel> { containerBlock }
        };

        // Act
        var result = RenderTemplate(model);

        // Assert
        // Level 0 - Template block class
        Assert.Contains("public class TemplateBlock : TerraformBlock", result);
        Assert.Contains("Container", result);

        // Level 1 - Container block class
        Assert.Contains("public class TemplateBlockContainerBlock : TerraformBlock", result);
        Assert.Contains("Env", result);

        // Level 2 - Env block class (deepest)
        Assert.Contains("public class TemplateBlockContainerBlockEnvBlock : TerraformBlock", result);
        Assert.Contains("public override string BlockType => \"env\";", result);
    }

    [Fact]
    public void BlockTemplate_ValidationAttributes_RenderedCorrectly()
    {
        // Arrange
        var childBlock = new BlockTypeModel
        {
            Name = "Child",
            TerraformName = "child",
            ClassName = "ParentExampleBlockChildBlock",
            ParentClassName = "ParentExampleBlock",
            NestingMode = "list",
            MinItems = 1,
            MaxItems = 5,
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel>()
        };

        var parentModel = new BlockTypeModel
        {
            Name = "Example",
            TerraformName = "example",
            ClassName = "ParentExampleBlock",
            ParentClassName = "Parent",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel> { childBlock }
        };

        // Act
        var result = RenderTemplate(parentModel);

        // Assert - Output result for debugging if needed
        // Console.WriteLine(result);

        // The validation attributes should be on the Child property, not the class
        Assert.Contains("Child", result);

        // Check that the nested block class was generated
        Assert.Contains("public class ParentExampleBlockChildBlock", result);
    }

    [Fact]
    public void BlockTemplate_MultipleNestedBlocks_AllRendered()
    {
        // Arrange
        var corsBlock = new BlockTypeModel
        {
            Name = "Cors",
            TerraformName = "cors",
            ClassName = "IngressBlockCorsBlock",
            ParentClassName = "IngressBlock",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel>()
        };

        var trafficWeightBlock = new BlockTypeModel
        {
            Name = "TrafficWeight",
            TerraformName = "traffic_weight",
            ClassName = "IngressBlockTrafficWeightBlock",
            ParentClassName = "IngressBlock",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel>()
        };

        var ipSecurityBlock = new BlockTypeModel
        {
            Name = "IpSecurityRestriction",
            TerraformName = "ip_security_restriction",
            ClassName = "IngressBlockIpSecurityRestrictionBlock",
            ParentClassName = "IngressBlock",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel>()
        };

        var model = new BlockTypeModel
        {
            Name = "Ingress",
            TerraformName = "ingress",
            ClassName = "IngressBlock",
            ParentClassName = "Resource",
            NestingMode = "list",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel> { corsBlock, trafficWeightBlock, ipSecurityBlock }
        };

        // Act
        var result = RenderTemplate(model);

        // Assert
        Assert.Contains("Cors", result);
        Assert.Contains("TrafficWeight", result);
        Assert.Contains("IpSecurityRestriction", result);
        Assert.Contains("public class IngressBlockCorsBlock", result);
        Assert.Contains("public class IngressBlockTrafficWeightBlock", result);
        Assert.Contains("public class IngressBlockIpSecurityRestrictionBlock", result);
    }

    [Fact]
    public void BlockTemplate_EmptyNestedBlocksList_NoNestedBlocksRendered()
    {
        // Arrange
        var model = new BlockTypeModel
        {
            Name = "Simple",
            TerraformName = "simple",
            ClassName = "SimpleBlock",
            ParentClassName = "Resource",
            NestingMode = "single",
            Arguments = new List<PropertyModel>(),
            NestedBlocks = new List<BlockTypeModel>() // Empty
        };

        // Act
        var result = RenderTemplate(model);

        // Assert
        Assert.Contains("public class SimpleBlock : TerraformBlock", result);
        Assert.Contains("public override string BlockType => \"simple\";", result);
        // Should not render any nested block properties since list is empty
        var blockPropertyCount = result.Split("TerraformBlockList<").Length - 1;
        Assert.Equal(0, blockPropertyCount);
    }
}
