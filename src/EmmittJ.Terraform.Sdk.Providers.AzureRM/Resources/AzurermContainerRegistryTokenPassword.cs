using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_token_password resource.
/// </summary>
public class AzurermContainerRegistryTokenPassword : TerraformResource
{
    public AzurermContainerRegistryTokenPassword(string name) : base("azurerm_container_registry_token_password", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The container_registry_token_id attribute.
    /// </summary>
    public string? ContainerRegistryTokenId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_token_id")?.Value;
        set => this.WithProperty("container_registry_token_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
