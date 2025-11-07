using EmmittJ.Terraform.Sdk.Core;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformProviderMetaTests
{
    [Fact]
    public Task ProviderMeta_WithSingleProvider_GeneratesHcl()
    {
        var config = new TerraformStack
        {
            Name = "test",
            Terraform = new TerraformSettings
            {
                ProviderMetas =
                {
                    new TerraformProviderMetaConfig("my-provider")
                    {
                        Metadata =
                        {
                            ["hello"] = "world",
                            ["version"] = "1.0.0"
                        }
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ProviderMeta_WithMultipleProviders_GeneratesHcl()
    {
        var config = new TerraformStack
        {
            Name = "test",
            Terraform = new TerraformSettings
            {
                ProviderMetas =
                {
                    new TerraformProviderMetaConfig("provider-a")
                    {
                        Metadata =
                        {
                            ["module_name"] = "vpc",
                            ["module_version"] = "2.0.0"
                        }
                    },
                    new TerraformProviderMetaConfig("provider-b")
                    {
                        Metadata =
                        {
                            ["environment"] = "production",
                            ["team"] = "platform"
                        }
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ProviderMeta_WithVariousDataTypes_GeneratesHcl()
    {
        var config = new TerraformStack
        {
            Name = "test",
            Terraform = new TerraformSettings
            {
                ProviderMetas =
                {
                    new TerraformProviderMetaConfig("analytics")
                    {
                        Metadata =
                        {
                            ["enabled"] = true,
                            ["count"] = 42,
                            ["name"] = "test-module",
                            ["rate"] = 3.14
                        }
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ProviderMeta_WithFluentApi_GeneratesHcl()
    {
        var providerMeta = new TerraformProviderMetaConfig("tracking")
            .WithMetadata("module_id", "vpc-standard")
            .WithMetadata("version", "1.5.0")
            .WithMetadata("tracked", true);

        var config = new TerraformStack
        {
            Name = "test",
            Terraform = new TerraformSettings
            {
                ProviderMetas = { providerMeta }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ProviderMeta_WithCompleteConfiguration_GeneratesHcl()
    {
        var config = new TerraformStack
        {
            Name = "test",
            Terraform = new TerraformSettings
            {
                RequiredVersion = ">= 1.0",
                RequiredProviders =
                {
                    ["my-provider"] = new ProviderRequirement
                    {
                        Source = "example.com/org/my-provider",
                        Version = "~> 2.0"
                    }
                },
                ProviderMetas =
                {
                    new TerraformProviderMetaConfig("my-provider")
                    {
                        Metadata =
                        {
                            ["module_name"] = "example-module",
                            ["module_version"] = "1.0.0"
                        }
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }
}

