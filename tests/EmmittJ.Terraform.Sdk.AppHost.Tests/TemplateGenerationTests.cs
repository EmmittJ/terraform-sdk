using EmmittJ.Terraform.Sdk.AppHost.Models;
using EmmittJ.Terraform.Sdk.AppHost.Templates;

namespace EmmittJ.Terraform.Sdk.AppHost.Tests;

public class TemplateGenerationTests
{
    private readonly TerraformCodeGenOptions _options;

    public TemplateGenerationTests()
    {
        // Get the source directory for templates
        var projectDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "src", "EmmittJ.Terraform.Sdk.AppHost"));
        _options = new TerraformCodeGenOptions
        {
            TemplatesDirectory = Path.Combine(projectDir, "Templates", "Files")
        };
    }

    [Fact]
    public Task ResourceTemplate_GeneratesCorrectCode()
    {
        var template = new ResourceTemplate(_options);

        var model = new ResourceModel
        {
            Name = "azurerm_resource_group",
            TerraformType = "azurerm_resource_group",
            ClassName = "AzurermResourceGroup",
            Description = "Manages a Resource Group.",
            Arguments = new List<PropertyModel>
            {
                new()
                {
                    Name = "Name",
                    TerraformName = "name",
                    CSharpType = "TerraformString",
                    Description = "The name of the Resource Group.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                },
                new()
                {
                    Name = "Location",
                    TerraformName = "location",
                    CSharpType = "TerraformString",
                    Description = "The Azure Region where the Resource Group should exist.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                },
                new()
                {
                    Name = "Tags",
                    TerraformName = "tags",
                    CSharpType = "TerraformMap<TerraformString>",
                    Description = "A mapping of tags to assign to the resource.",
                    IsRequired = false,
                    IsOptional = true,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = true,
                    IsValueType = false
                }
            },
            OutputAttributes = new List<PropertyModel>
            {
                new()
                {
                    Name = "Id",
                    TerraformName = "id",
                    CSharpType = "TerraformString",
                    Description = "The ID of the Resource Group.",
                    IsRequired = false,
                    IsOptional = false,
                    IsComputed = true,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            BlockTypes = new List<BlockTypeModel>()
        };

        var result = template.Generate(model, "EmmittJ.Terraform.Sdk.Providers.Azurerm");
        return Verify(result);
    }

    [Fact]
    public Task ResourceTemplate_WithNestedBlocks_GeneratesCorrectCode()
    {
        var template = new ResourceTemplate(_options);

        var model = new ResourceModel
        {
            Name = "azurerm_virtual_network",
            TerraformType = "azurerm_virtual_network",
            ClassName = "AzurermVirtualNetwork",
            Description = "Manages a Virtual Network.",
            Arguments = new List<PropertyModel>
            {
                new PropertyModel
                {
                    Name = "Name",
                    TerraformName = "name",
                    CSharpType = "TerraformString",
                    Description = "The name of the virtual network.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            OutputAttributes = new List<PropertyModel>(),
            BlockTypes = new List<BlockTypeModel>
            {
                new BlockTypeModel
                {
                    Name = "Subnet",
                    TerraformName = "subnet",
                    ClassName = "AzurermVirtualNetworkSubnetBlock",
                    NestingMode = "list",
                    Arguments = new List<PropertyModel>
                    {
                        new PropertyModel
                        {
                            Name = "Name",
                            TerraformName = "name",
                            CSharpType = "TerraformString",
                            Description = "The name of the subnet.",
                            IsRequired = true,
                            IsOptional = false,
                            IsComputed = false,
                            IsSensitive = false,
                            IsDeprecated = false,
                            IsCollection = false,
                            IsValueType = false
                        },
                        new PropertyModel
                        {
                            Name = "AddressPrefix",
                            TerraformName = "address_prefix",
                            CSharpType = "TerraformString",
                            Description = "The address prefix to use for the subnet.",
                            IsRequired = true,
                            IsOptional = false,
                            IsComputed = false,
                            IsSensitive = false,
                            IsDeprecated = false,
                            IsCollection = false,
                            IsValueType = false
                        }
                    },
                    MinItems = null,
                    MaxItems = null,
                    IsDeprecated = false
                }
            }
        };

        var result = template.Generate(model, "EmmittJ.Terraform.Sdk.Providers.Azurerm");
        return Verify(result);
    }

    [Fact]
    public Task DataSourceTemplate_GeneratesCorrectCode()
    {
        var template = new DataSourceTemplate(_options);

        var model = new ResourceModel
        {
            Name = "azurerm_resource_group",
            TerraformType = "azurerm_resource_group",
            ClassName = "AzurermResourceGroup",
            Description = "Use this data source to access information about an existing Resource Group.",
            Arguments = new List<PropertyModel>
            {
                new PropertyModel
                {
                    Name = "Name",
                    TerraformName = "name",
                    CSharpType = "TerraformString",
                    Description = "The name of the Resource Group.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            OutputAttributes = new List<PropertyModel>
            {
                new PropertyModel
                {
                    Name = "Id",
                    TerraformName = "id",
                    CSharpType = "TerraformString",
                    Description = "The ID of the Resource Group.",
                    IsRequired = false,
                    IsOptional = false,
                    IsComputed = true,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                },
                new PropertyModel
                {
                    Name = "Location",
                    TerraformName = "location",
                    CSharpType = "TerraformString",
                    Description = "The Azure location where the Resource Group exists.",
                    IsRequired = false,
                    IsOptional = false,
                    IsComputed = true,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            BlockTypes = new List<BlockTypeModel>()
        };

        var result = template.Generate(model, "EmmittJ.Terraform.Sdk.Providers.Azurerm");
        return Verify(result);
    }

    [Fact]
    public Task ProviderTemplate_GeneratesCorrectCode()
    {
        var template = new ProviderTemplate(_options);

        var model = new ProviderConfig
        {
            Name = "azurerm",
            Namespace = "EmmittJ.Terraform.Sdk.Providers.Azurerm",
            FolderPath = "/output",
            Version = "4.0.0",
            Description = "The Azure Resource Manager provider.",
            ResourceCount = 1000,
            DataSourceCount = 500,
            Arguments = new List<PropertyModel>
            {
                new PropertyModel
                {
                    Name = "Features",
                    TerraformName = "features",
                    CSharpType = "AzurermProviderFeaturesBlock",
                    Description = "A features block as defined below.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                },
                new PropertyModel
                {
                    Name = "SubscriptionId",
                    TerraformName = "subscription_id",
                    CSharpType = "TerraformString",
                    Description = "The Subscription ID which should be used.",
                    IsRequired = false,
                    IsOptional = true,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            }
        };

        var result = template.Generate(model);
        return Verify(result);
    }

    [Fact]
    public Task EphemeralResourceTemplate_GeneratesCorrectCode()
    {
        var template = new EphemeralResourceTemplate(_options);

        var model = new ResourceModel
        {
            Name = "azurerm_key_vault_secret",
            TerraformType = "azurerm_key_vault_secret",
            ClassName = "AzurermKeyVaultSecret",
            Description = "Reads a secret from Azure Key Vault.",
            Arguments = new List<PropertyModel>
            {
                new PropertyModel
                {
                    Name = "KeyVaultId",
                    TerraformName = "key_vault_id",
                    CSharpType = "TerraformString",
                    Description = "The ID of the Key Vault.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                },
                new PropertyModel
                {
                    Name = "Name",
                    TerraformName = "name",
                    CSharpType = "TerraformString",
                    Description = "The name of the secret.",
                    IsRequired = true,
                    IsOptional = false,
                    IsComputed = false,
                    IsSensitive = false,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            OutputAttributes = new List<PropertyModel>
            {
                new PropertyModel
                {
                    Name = "Value",
                    TerraformName = "value",
                    CSharpType = "TerraformString",
                    Description = "The value of the secret.",
                    IsRequired = false,
                    IsOptional = false,
                    IsComputed = true,
                    IsSensitive = true,
                    IsDeprecated = false,
                    IsCollection = false,
                    IsValueType = false
                }
            },
            BlockTypes = new List<BlockTypeModel>()
        };

        var result = template.Generate(model, "EmmittJ.Terraform.Sdk.Providers.Azurerm");
        return Verify(result);
    }
}
