using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_relay_hybrid_connection resource.
/// </summary>
public class AzurermRelayHybridConnection : TerraformResource
{
    public AzurermRelayHybridConnection(string name) : base("azurerm_relay_hybrid_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The relay_namespace_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RelayNamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relay_namespace_name");
        set => this.WithProperty("relay_namespace_name", value);
    }

    /// <summary>
    /// The requires_client_authorization attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequiresClientAuthorization
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_client_authorization");
        set => this.WithProperty("requires_client_authorization", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The user_metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserMetadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_metadata");
        set => this.WithProperty("user_metadata", value);
    }

}
