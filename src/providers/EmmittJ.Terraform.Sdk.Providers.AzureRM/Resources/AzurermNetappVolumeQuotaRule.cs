using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeQuotaRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_netapp_volume_quota_rule resource.
/// </summary>
public class AzurermNetappVolumeQuotaRule : TerraformResource
{
    public AzurermNetappVolumeQuotaRule(string name) : base("azurerm_netapp_volume_quota_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("quota_size_in_kib");
        SetOutput("quota_target");
        SetOutput("quota_type");
        SetOutput("volume_id");
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
    /// The quota_size_in_kib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaSizeInKib is required")]
    public required TerraformProperty<double> QuotaSizeInKib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("quota_size_in_kib");
        set => SetProperty("quota_size_in_kib", value);
    }

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformProperty<string> QuotaTarget
    {
        get => GetRequiredOutput<TerraformProperty<string>>("quota_target");
        set => SetProperty("quota_target", value);
    }

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaType is required")]
    public required TerraformProperty<string> QuotaType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("quota_type");
        set => SetProperty("quota_type", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformProperty<string> VolumeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_id");
        set => SetProperty("volume_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappVolumeQuotaRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
