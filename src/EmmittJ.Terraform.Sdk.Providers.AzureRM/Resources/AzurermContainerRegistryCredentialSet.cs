using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_credential_set resource.
/// </summary>
public class AzurermContainerRegistryCredentialSet : TerraformResource
{
    public AzurermContainerRegistryCredentialSet(string name) : base("azurerm_container_registry_credential_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public string? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id")?.Value;
        set => this.WithProperty("container_registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public string? LoginServer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login_server")?.Value;
        set => this.WithProperty("login_server", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the credential set.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
