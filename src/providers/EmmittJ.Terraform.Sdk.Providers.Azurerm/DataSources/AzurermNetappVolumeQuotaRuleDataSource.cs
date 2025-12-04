using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappVolumeQuotaRuleDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_volume_quota_rule Terraform data source.
/// Retrieves information about a azurerm_netapp_volume_quota_rule.
/// </summary>
public partial class AzurermNetappVolumeQuotaRuleDataSource(string name) : TerraformDataSource("azurerm_netapp_volume_quota_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformValue<string> VolumeId
    {
        get => GetArgument<TerraformValue<string>>("volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    public TerraformValue<double> QuotaSizeInKib
        => AsReference("quota_size_in_kib");

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformValue<string> QuotaTarget
        => AsReference("quota_target");

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    public TerraformValue<string> QuotaType
        => AsReference("quota_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
