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
    public TerraformLiteralProperty<string>? Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
    }

    /// <summary>
    /// The commissioning_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CommissioningEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("commissioning_enabled");
        set => this.WithProperty("commissioning_enabled", value);
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
    /// The internet_advertising_disabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InternetAdvertisingDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_advertising_disabled");
        set => this.WithProperty("internet_advertising_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The parent_custom_ip_prefix_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentCustomIpPrefixId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_custom_ip_prefix_id");
        set => this.WithProperty("parent_custom_ip_prefix_id", value);
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
    /// The roa_validity_end_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoaValidityEndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("roa_validity_end_date");
        set => this.WithProperty("roa_validity_end_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The wan_validation_signed_message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WanValidationSignedMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("wan_validation_signed_message");
        set => this.WithProperty("wan_validation_signed_message", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
