using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory resource.
/// </summary>
public class AzurermDataFactory : TerraformResource
{
    public AzurermDataFactory(string name) : base("azurerm_data_factory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public string? CustomerManagedKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_managed_key_id")?.Value;
        set => this.WithProperty("customer_managed_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    public string? CustomerManagedKeyIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_managed_key_identity_id")?.Value;
        set => this.WithProperty("customer_managed_key_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public bool? ManagedVirtualNetworkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed_virtual_network_enabled")?.Value;
        set => this.WithProperty("managed_virtual_network_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The public_network_enabled attribute.
    /// </summary>
    public bool? PublicNetworkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_enabled")?.Value;
        set => this.WithProperty("public_network_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public string? PurviewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("purview_id")?.Value;
        set => this.WithProperty("purview_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
