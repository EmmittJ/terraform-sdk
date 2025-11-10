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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("cidr");
        SetOutput("commissioning_enabled");
        SetOutput("id");
        SetOutput("internet_advertising_disabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("parent_custom_ip_prefix_id");
        SetOutput("resource_group_name");
        SetOutput("roa_validity_end_date");
        SetOutput("tags");
        SetOutput("wan_validation_signed_message");
        SetOutput("zones");
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformProperty<string> Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr");
        set => SetProperty("cidr", value);
    }

    /// <summary>
    /// The commissioning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CommissioningEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("commissioning_enabled");
        set => SetProperty("commissioning_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The internet_advertising_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetAdvertisingDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_advertising_disabled");
        set => SetProperty("internet_advertising_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_custom_ip_prefix_id attribute.
    /// </summary>
    public TerraformProperty<string> ParentCustomIpPrefixId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_custom_ip_prefix_id");
        set => SetProperty("parent_custom_ip_prefix_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The roa_validity_end_date attribute.
    /// </summary>
    public TerraformProperty<string> RoaValidityEndDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("roa_validity_end_date");
        set => SetProperty("roa_validity_end_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The wan_validation_signed_message attribute.
    /// </summary>
    public TerraformProperty<string> WanValidationSignedMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("wan_validation_signed_message");
        set => SetProperty("wan_validation_signed_message", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCustomIpPrefixTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
