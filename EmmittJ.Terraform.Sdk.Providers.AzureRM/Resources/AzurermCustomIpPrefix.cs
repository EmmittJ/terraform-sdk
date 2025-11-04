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
    public string? Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr")?.Value;
        set => this.WithProperty("cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The commissioning_enabled attribute.
    /// </summary>
    public bool? CommissioningEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("commissioning_enabled")?.Value;
        set => this.WithProperty("commissioning_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The internet_advertising_disabled attribute.
    /// </summary>
    public bool? InternetAdvertisingDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_advertising_disabled")?.Value;
        set => this.WithProperty("internet_advertising_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The parent_custom_ip_prefix_id attribute.
    /// </summary>
    public string? ParentCustomIpPrefixId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_custom_ip_prefix_id")?.Value;
        set => this.WithProperty("parent_custom_ip_prefix_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The roa_validity_end_date attribute.
    /// </summary>
    public string? RoaValidityEndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("roa_validity_end_date")?.Value;
        set => this.WithProperty("roa_validity_end_date", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The wan_validation_signed_message attribute.
    /// </summary>
    public string? WanValidationSignedMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("wan_validation_signed_message")?.Value;
        set => this.WithProperty("wan_validation_signed_message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
