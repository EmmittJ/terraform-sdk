using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_custom_ip_prefix resource.
/// </summary>
public class AzurermCustomIpPrefix : TerraformResource
{
    public AzurermCustomIpPrefix(string name) : base("azurerm_custom_ip_prefix", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
    }

    /// <summary>
    /// The commissioning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CommissioningEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("commissioning_enabled");
        set => this.WithProperty("commissioning_enabled", value);
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
    /// The internet_advertising_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetAdvertisingDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_advertising_disabled");
        set => this.WithProperty("internet_advertising_disabled", value);
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
    /// The parent_custom_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentCustomIpPrefixId
    {
        get => GetProperty<TerraformProperty<string>>("parent_custom_ip_prefix_id");
        set => this.WithProperty("parent_custom_ip_prefix_id", value);
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
    /// The roa_validity_end_date attribute.
    /// </summary>
    public TerraformProperty<string>? RoaValidityEndDate
    {
        get => GetProperty<TerraformProperty<string>>("roa_validity_end_date");
        set => this.WithProperty("roa_validity_end_date", value);
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
    /// The wan_validation_signed_message attribute.
    /// </summary>
    public TerraformProperty<string>? WanValidationSignedMessage
    {
        get => GetProperty<TerraformProperty<string>>("wan_validation_signed_message");
        set => this.WithProperty("wan_validation_signed_message", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
