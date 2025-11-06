using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_ipam_pool resource.
/// </summary>
public class AzurermNetworkManagerIpamPool : TerraformResource
{
    public AzurermNetworkManagerIpamPool(string name) : base("azurerm_network_manager_ipam_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public List<string>? AddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("address_prefixes")?.Value;
        set => this.WithProperty("address_prefixes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    public string? NetworkManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_manager_id")?.Value;
        set => this.WithProperty("network_manager_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_pool_name attribute.
    /// </summary>
    public string? ParentPoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_pool_name")?.Value;
        set => this.WithProperty("parent_pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
