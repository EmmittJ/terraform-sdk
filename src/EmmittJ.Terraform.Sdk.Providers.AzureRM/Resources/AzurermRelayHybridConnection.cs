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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The relay_namespace_name attribute.
    /// </summary>
    public string? RelayNamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relay_namespace_name")?.Value;
        set => this.WithProperty("relay_namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The requires_client_authorization attribute.
    /// </summary>
    public bool? RequiresClientAuthorization
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_client_authorization")?.Value;
        set => this.WithProperty("requires_client_authorization", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_metadata attribute.
    /// </summary>
    public string? UserMetadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_metadata")?.Value;
        set => this.WithProperty("user_metadata", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
