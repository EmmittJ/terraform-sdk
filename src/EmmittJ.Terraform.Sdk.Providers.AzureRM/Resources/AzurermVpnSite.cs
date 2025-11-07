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
    public TerraformProperty<HashSet<string>>? AddressCidrs
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("address_cidrs");
        set => this.WithProperty("address_cidrs", value);
    }

    /// <summary>
    /// The device_model attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceModel
    {
        get => GetProperty<TerraformProperty<string>>("device_model");
        set => this.WithProperty("device_model", value);
    }

    /// <summary>
    /// The device_vendor attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceVendor
    {
        get => GetProperty<TerraformProperty<string>>("device_vendor");
        set => this.WithProperty("device_vendor", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualWanId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_wan_id");
        set => this.WithProperty("virtual_wan_id", value);
    }

}
