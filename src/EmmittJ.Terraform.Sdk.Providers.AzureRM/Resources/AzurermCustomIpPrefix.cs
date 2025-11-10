using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCustomIpPrefixTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformProperty<string> Cidr
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cidr");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCustomIpPrefixTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCustomIpPrefixTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
