using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Parsers;
using EmmittJ.Terraform.Sdk.AppHost.Schema;

namespace EmmittJ.Terraform.Sdk.AppHost.Tests.CodeGen;

/// <summary>
/// Tests for SchemaParser to verify it correctly parses nested blocks from schema.
/// </summary>
public class SchemaParserTests
{
    [Fact]
    public void ParseBlockType_WithoutNestedBlocks_CreatesSimpleBlock()
    {
        // Arrange
        var parser = new SchemaParser();

        var blockType = new SchemaBlockType
        {
            NestingMode = "single",
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>
                {
                    ["timeout"] = new SchemaAttribute
                    {
                        Type = "string",
                        Optional = true,
                        Description = "Timeout value"
                    }
                },
                BlockTypes = new Dictionary<string, SchemaBlockType>()
            }
        };

        // Act
        var result = parser.ParseBlockType("timeouts", blockType, "TestResource");

        // Assert
        Assert.Equal("Timeouts", result.Name);
        Assert.Equal("timeouts", result.TerraformName);
        Assert.Equal("TestResourceTimeoutsBlock", result.ClassName);
        Assert.Equal("TestResource", result.ParentClassName);
        Assert.Equal("single", result.NestingMode);
        Assert.Single(result.Arguments);
        Assert.Empty(result.NestedBlocks);
    }

    [Fact]
    public void ParseBlockType_WithNestedBlocks_ParsesRecursively()
    {
        // Arrange
        var parser = new SchemaParser();

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            MaxItems = 1,
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>
                {
                    ["external_enabled"] = new SchemaAttribute
                    {
                        Type = "bool",
                        Optional = true
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
                                ["allow_credentials_enabled"] = new SchemaAttribute
                                {
                                    Type = "bool",
                                    Optional = true
                                },
                                ["allowed_origins"] = new SchemaAttribute
                                {
                                    Type = "list",
                                    Required = true
                                }
                            },
                            BlockTypes = new Dictionary<string, SchemaBlockType>()
                        }
                    },
                    ["ip_security_restriction"] = new SchemaBlockType
                    {
                        NestingMode = "list",
                        Block = new SchemaBlock
                        {
                            Attributes = new Dictionary<string, SchemaAttribute>
                            {
                                ["action"] = new SchemaAttribute
                                {
                                    Type = "string",
                                    Required = true
                                },
                                ["ip_address_range"] = new SchemaAttribute
                                {
                                    Type = "string",
                                    Required = true
                                }
                            },
                            BlockTypes = new Dictionary<string, SchemaBlockType>()
                        }
                    }
                }
            }
        };

        // Act
        var result = parser.ParseBlockType("ingress", blockType, "AzurermContainerApp");

        // Assert
        Assert.Equal("Ingress", result.Name);
        Assert.Equal("AzurermContainerAppIngressBlock", result.ClassName);
        Assert.Single(result.Arguments);
        Assert.Equal(2, result.NestedBlocks.Count);

        // Verify cors block
        var corsBlock = result.NestedBlocks.First(b => b.TerraformName == "cors");
        Assert.Equal("Cors", corsBlock.Name);
        Assert.Equal("AzurermContainerAppIngressBlockCorsBlock", corsBlock.ClassName);
        Assert.Equal("AzurermContainerAppIngressBlock", corsBlock.ParentClassName);
        Assert.Equal(2, corsBlock.Arguments.Count);
        Assert.Empty(corsBlock.NestedBlocks);

        // Verify ip_security_restriction block
        var ipBlock = result.NestedBlocks.First(b => b.TerraformName == "ip_security_restriction");
        Assert.Equal("IpSecurityRestriction", ipBlock.Name);
        Assert.Equal("AzurermContainerAppIngressBlockIpSecurityRestrictionBlock", ipBlock.ClassName);
        Assert.Equal(2, ipBlock.Arguments.Count);
        Assert.Empty(ipBlock.NestedBlocks);
    }

    [Fact]
    public void ParseBlockType_ThreeLevelsDeep_ParsesCompleteHierarchy()
    {
        // Arrange
        var parser = new SchemaParser();

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            MinItems = 1,
            MaxItems = 1,
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
                                ["cpu"] = new SchemaAttribute { Type = "number", Required = true },
                                ["memory"] = new SchemaAttribute { Type = "string", Required = true },
                                ["image"] = new SchemaAttribute { Type = "string", Required = true }
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
                                            ["name"] = new SchemaAttribute { Type = "string", Required = true },
                                            ["value"] = new SchemaAttribute { Type = "string", Optional = true },
                                            ["secret_name"] = new SchemaAttribute { Type = "string", Optional = true }
                                        },
                                        BlockTypes = new Dictionary<string, SchemaBlockType>()
                                    }
                                },
                                ["volume_mounts"] = new SchemaBlockType
                                {
                                    NestingMode = "list",
                                    Block = new SchemaBlock
                                    {
                                        Attributes = new Dictionary<string, SchemaAttribute>
                                        {
                                            ["name"] = new SchemaAttribute { Type = "string", Required = true },
                                            ["path"] = new SchemaAttribute { Type = "string", Required = true }
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
        var result = parser.ParseBlockType("template", blockType, "AzurermContainerApp");

        // Assert - Level 0: template
        Assert.Equal("Template", result.Name);
        Assert.Equal("AzurermContainerAppTemplateBlock", result.ClassName);
        Assert.True(result.IsRequired);
        Assert.Empty(result.Arguments);
        Assert.Single(result.NestedBlocks);

        // Assert - Level 1: container
        var containerBlock = result.NestedBlocks[0];
        Assert.Equal("Container", containerBlock.Name);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlock", containerBlock.ClassName);
        Assert.Equal("AzurermContainerAppTemplateBlock", containerBlock.ParentClassName);
        Assert.Equal(3, containerBlock.Arguments.Count);
        Assert.Equal(2, containerBlock.NestedBlocks.Count);

        // Assert - Level 2: env
        var envBlock = containerBlock.NestedBlocks.First(b => b.TerraformName == "env");
        Assert.Equal("Env", envBlock.Name);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlockEnvBlock", envBlock.ClassName);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlock", envBlock.ParentClassName);
        Assert.Equal(3, envBlock.Arguments.Count);
        Assert.Empty(envBlock.NestedBlocks);

        // Assert - Level 2: volume_mounts
        var volumeBlock = containerBlock.NestedBlocks.First(b => b.TerraformName == "volume_mounts");
        Assert.Equal("VolumeMounts", volumeBlock.Name);
        Assert.Equal("AzurermContainerAppTemplateBlockContainerBlockVolumeMountsBlock", volumeBlock.ClassName);
        Assert.Equal(2, volumeBlock.Arguments.Count);
        Assert.Empty(volumeBlock.NestedBlocks);
    }

    [Fact]
    public void ParseBlockType_NamingConversions_HandleEdgeCases()
    {
        // Arrange
        var parser = new SchemaParser();

        var blockType = new SchemaBlockType
        {
            NestingMode = "list",
            Block = new SchemaBlock
            {
                Attributes = new Dictionary<string, SchemaAttribute>(),
                BlockTypes = new Dictionary<string, SchemaBlockType>
                {
                    ["http_scale_rule"] = new SchemaBlockType
                    {
                        NestingMode = "list",
                        Block = new SchemaBlock
                        {
                            Attributes = new Dictionary<string, SchemaAttribute>(),
                            BlockTypes = new Dictionary<string, SchemaBlockType>()
                        }
                    },
                    ["azure_queue_scale_rule"] = new SchemaBlockType
                    {
                        NestingMode = "list",
                        Block = new SchemaBlock
                        {
                            Attributes = new Dictionary<string, SchemaAttribute>(),
                            BlockTypes = new Dictionary<string, SchemaBlockType>()
                        }
                    }
                }
            }
        };

        // Act
        var result = parser.ParseBlockType("template", blockType, "Resource");

        // Assert
        var httpRule = result.NestedBlocks.First(b => b.TerraformName == "http_scale_rule");
        Assert.Equal("HttpScaleRule", httpRule.Name);
        Assert.Equal("ResourceTemplateBlockHttpScaleRuleBlock", httpRule.ClassName);

        var azureRule = result.NestedBlocks.First(b => b.TerraformName == "azure_queue_scale_rule");
        Assert.Equal("AzureQueueScaleRule", azureRule.Name);
        Assert.Equal("ResourceTemplateBlockAzureQueueScaleRuleBlock", azureRule.ClassName);
    }
}
