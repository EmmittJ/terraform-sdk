using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappVolumeQuotaRule.
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeQuotaRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_volume_quota_rule Terraform resource.
/// Manages a azurerm_netapp_volume_quota_rule resource.
/// </summary>
public partial class AzurermNetappVolumeQuotaRule(string name) : TerraformResource("azurerm_netapp_volume_quota_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The quota_size_in_kib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaSizeInKib is required")]
    public required TerraformValue<double> QuotaSizeInKib
    {
        get => GetRequiredArgument<TerraformValue<double>>("quota_size_in_kib");
        set => SetArgument("quota_size_in_kib", value);
    }

    /// <summary>
    /// The quota_target attribute.
    /// </summary>
    public TerraformValue<string>? QuotaTarget
    {
        get => GetArgument<TerraformValue<string>>("quota_target");
        set => SetArgument("quota_target", value);
    }

    /// <summary>
    /// The quota_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaType is required")]
    public required TerraformValue<string> QuotaType
    {
        get => GetRequiredArgument<TerraformValue<string>>("quota_type");
        set => SetArgument("quota_type", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformValue<string> VolumeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeQuotaRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeQuotaRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
