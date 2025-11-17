using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Parsers;
using EmmittJ.Terraform.Sdk.AppHost.Schema;

namespace EmmittJ.Terraform.Sdk.AppHost.Tests.CodeGen;

/// <summary>
/// Tests for ModelBuilder to verify it correctly builds models with nested blocks.
/// </summary>
public class ModelBuilderTests
{
    [Fact]
    public void BuildBlockTypeModel_WithoutNestedBlocks_CreatesSimpleBlock()
    {
        // Arrange
        var typeMapper = new TypeMapper();
        var modelBuilder = new ModelBuilder(typeMapper);

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            MinItems = 0,
            MaxItems = 1,
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>
                {
                    ["name"] = new SchemaAttribute
                    {
                        Type = "string",
                        Required = true,
                        Description = "The name attribute"
                    },
                    ["enabled"] = new SchemaAttribute
                    {
                        Type = "bool",
                        Optional = true,
                        Description = "Whether enabled"
                    }
                },
                BlockTypes = new Dictionary<string, SchemaBlockType>(), // Empty - no nested blocks
                Deprecated = false
            }
        };

        // Act
        var result = modelBuilder.BuildBlockTypeModel(blockType, "example", "TestResource");

        // Assert
        Assert.Equal("Example", result.Name);
        Assert.Equal("example", result.TerraformName);
        Assert.Equal("TestResourceExampleBlock", result.ClassName);
        Assert.Equal("TestResource", result.ParentClassName);
        Assert.Equal("list", result.NestingMode);
        Assert.Equal(2, result.Arguments.Count);
        Assert.Empty(result.NestedBlocks);
    }

    [Fact]
    public void BuildBlockTypeModel_WithNestedBlocks_CreatesNestedStructure()
    {
        // Arrange
        var typeMapper = new TypeMapper();
        var modelBuilder = new ModelBuilder(typeMapper);

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>
                {
                    ["target_port"] = new SchemaAttribute
                    {
                        Type = "number",
                        Required = true,
                        Description = "The target port"
                    }
                },
                BlockTypes = new Dictionary<string, SchemaBlockType>
                {
                    ["cors"] = new SchemaBlockType
                    {
                        NestingMode = "list",
                        MaxItems = 1,
                        Block = new SchemaBlock
                        {
                            Attributes = new Dictionary<string, SchemaAttribute>
                            {
                                ["allowed_origins"] = new SchemaAttribute
                                {
                                    Type = "list",
                                    Required = true,
                                    Description = "Allowed origins"
                                }
                            },
                            BlockTypes = new Dictionary<string, SchemaBlockType>()
                        }
                    },
                    ["traffic_weight"] = new SchemaBlockType
                    {
                        NestingMode = "list",
                        MinItems = 1,
                        Block = new SchemaBlock
                        {
                            Attributes = new Dictionary<string, SchemaAttribute>
                            {
                                ["percentage"] = new SchemaAttribute
                                {
                                    Type = "number",
                                    Required = true,
                                    Description = "Percentage"
                                }
                            },
                            BlockTypes = new Dictionary<string, SchemaBlockType>()
                        }
                    }
                }
            }
        };

        // Act
        var result = modelBuilder.BuildBlockTypeModel(blockType, "ingress", "AzurermContainerApp");

        // Assert
        Assert.Equal("Ingress", result.Name);
        Assert.Equal("ingress", result.TerraformName);
        Assert.Equal("AzurermContainerAppIngressBlock", result.ClassName);
        Assert.Equal("AzurermContainerApp", result.ParentClassName);
        Assert.Single(result.Arguments);
        Assert.Equal(2, result.NestedBlocks.Count);

        // Verify first nested block (cors)
        var corsBlock = result.NestedBlocks.First(b => b.TerraformName == "cors");
        Assert.Equal("Cors", corsBlock.Name);
        Assert.Equal("AzurermContainerAppIngressBlockCorsBlock", corsBlock.ClassName);
        Assert.Equal("AzurermContainerAppIngressBlock", corsBlock.ParentClassName);
        Assert.Equal(1, corsBlock.MaxItems);
        Assert.Single(corsBlock.Arguments);
        Assert.Empty(corsBlock.NestedBlocks);

        // Verify second nested block (traffic_weight)
        var trafficBlock = result.NestedBlocks.First(b => b.TerraformName == "traffic_weight");
        Assert.Equal("TrafficWeight", trafficBlock.Name);
        Assert.Equal("AzurermContainerAppIngressBlockTrafficWeightBlock", trafficBlock.ClassName);
        Assert.Equal("AzurermContainerAppIngressBlock", trafficBlock.ParentClassName);
        Assert.Equal(1, trafficBlock.MinItems);
        Assert.Single(trafficBlock.Arguments);
    }

    [Fact]
    public void BuildBlockTypeModel_WithDeeplyNestedBlocks_CreatesCompleteHierarchy()
    {
        // Arrange
        var typeMapper = new TypeMapper();
        var modelBuilder = new ModelBuilder(typeMapper);

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>(),
                BlockTypes = new Dictionary<string, SchemaBlockType>
                {
                    ["container"] = new SchemaBlockType
                    {
                        NestingMode = "list",
                        MinItems = 1,
                        Block = new SchemaBlock
                        {
                            Attributes = new Dictionary<string, SchemaAttribute>
                            {
                                ["image"] = new SchemaAttribute
                                {
                                    Type = "string",
                                    Required = true
                                }
                            },
                            BlockTypes = new Dictionary<string, SchemaBlockType>
                            {
                                ["env"] = new SchemaBlockType
                                {
                                    NestingMode = "list",
                                    Block = new SchemaBlock
                                    {
                                        Attributes = new Dictionary<string, SchemaAttribute>
                                        {
                                            ["name"] = new SchemaAttribute
                                            {
                                                Type = "string",
                                                Required = true
                                            },
                                            ["value"] = new SchemaAttribute
                                            {
                                                Type = "string",
                                                Optional = true
                                            }
                                        },
                                        BlockTypes = new Dictionary<string, SchemaBlockType>()
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

        // Act
        var result = modelBuilder.BuildBlockTypeModel(blockType, "template", "AzurermContainerApp");

        // Assert - Top level
        Assert.Equal("Template", result.Name);
        Assert.Equal("AzurermContainerAppTemplateBlock", result.ClassName);
        Assert.Single(result.NestedBlocks);

        // Assert - Container block (level 1)
        var containerBlock = result.NestedBlocks[0];
        Assert.Equal("Container", containerBlock.Name);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlock", containerBlock.ClassName);
        Assert.Equal("AzurermContainerAppTemplateBlock", containerBlock.ParentClassName);
        Assert.Equal(1, containerBlock.MinItems);
        Assert.Single(containerBlock.Arguments);
        Assert.Single(containerBlock.NestedBlocks);

        // Assert - Env block (level 2)
        var envBlock = containerBlock.NestedBlocks[0];
        Assert.Equal("Env", envBlock.Name);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlockEnvBlock", envBlock.ClassName);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlock", envBlock.ParentClassName);
        Assert.Equal(2, envBlock.Arguments.Count);
        Assert.Empty(envBlock.NestedBlocks); // No deeper nesting
    }

    [Fact]
    public void BuildBlockTypeModel_ValidationAttributes_GeneratedCorrectly()
    {
        // Arrange
        var typeMapper = new TypeMapper();
        var modelBuilder = new ModelBuilder(typeMapper);

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            MinItems = 1,
            MaxItems = 3,
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>(),
                BlockTypes = new Dictionary<string, SchemaBlockType>()
            }
        };

        // Act
        var result = modelBuilder.BuildBlockTypeModel(blockType, "required_block", "TestResource");

        // Assert
        Assert.True(result.IsRequired);
        Assert.True(result.HasValidation);
        Assert.Equal(3, result.ValidationAttributes.Count);
        Assert.Contains(result.ValidationAttributes, a => a.Contains("Required"));
        Assert.Contains(result.ValidationAttributes, a => a.Contains("MinLength(1"));
        Assert.Contains(result.ValidationAttributes, a => a.Contains("MaxLength(3"));
    }
}
