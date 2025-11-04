using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_vpn_site resource.
/// </summary>
public class AzurermVpnSite : TerraformResource
{
    public AzurermVpnSite(string name) : base("azurerm_vpn_site", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_cidrs attribute.
    /// </summary>
    public HashSet<string>? AddressCidrs
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("address_cidrs")?.Value;
        set => this.WithProperty("address_cidrs", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The device_model attribute.
    /// </summary>
    public string? DeviceModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_model")?.Value;
        set => this.WithProperty("device_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_vendor attribute.
    /// </summary>
    public string? DeviceVendor
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_vendor")?.Value;
        set => this.WithProperty("device_vendor", value == null ? null : new TerraformLiteralProperty<string>(value));
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

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public string? VirtualWanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_wan_id")?.Value;
        set => this.WithProperty("virtual_wan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
