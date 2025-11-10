using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_quota_rule.
/// </summary>
public class AzurermNetappVolumeQuotaRuleDataSource : TerraformDataSource
{
    public AzurermNetappVolumeQuotaRuleDataSource(string name) : base("azurerm_netapp_volume_quota_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("location");
        this.WithOutput("quota_size_in_kib");
        this.WithOutput("quota_target");
        this.WithOutput("quota_type");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformProperty<string> VolumeId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("volume_id");
        set => this.WithProperty("volume_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    public TerraformExpression QuotaSizeInKib => this["quota_size_in_kib"];

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformExpression QuotaTarget => this["quota_target"];

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    public TerraformExpression QuotaType => this["quota_type"];

}
