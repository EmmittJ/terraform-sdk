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
    public TerraformProperty<string>? CustomerManagedKeyId
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key_id");
        set => this.WithProperty("customer_managed_key_id", value);
    }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKeyIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key_identity_id");
        set => this.WithProperty("customer_managed_key_identity_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ManagedVirtualNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("managed_virtual_network_enabled");
        set => this.WithProperty("managed_virtual_network_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_enabled");
        set => this.WithProperty("public_network_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public TerraformProperty<string>? PurviewId
    {
        get => GetProperty<TerraformProperty<string>>("purview_id");
        set => this.WithProperty("purview_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
