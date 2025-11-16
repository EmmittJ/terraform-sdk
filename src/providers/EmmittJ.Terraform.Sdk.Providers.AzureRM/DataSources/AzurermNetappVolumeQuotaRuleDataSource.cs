using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformValue<string> VolumeId
    {
        get => new TerraformReference<string>(this, "volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    public TerraformValue<double> QuotaSizeInKib
    {
        get => new TerraformReference<double>(this, "quota_size_in_kib");
    }

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformValue<string> QuotaTarget
    {
        get => new TerraformReference<string>(this, "quota_target");
    }

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    public TerraformValue<string> QuotaType
    {
        get => new TerraformReference<string>(this, "quota_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeQuotaRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
