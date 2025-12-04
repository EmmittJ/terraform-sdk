using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappSnapshotPolicyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetappSnapshotPolicyDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_netapp_snapshot_policy Terraform data source.
/// Retrieves information about a azurerm_netapp_snapshot_policy.
/// </summary>
public partial class AzurermNetappSnapshotPolicyDataSource(string name) : TerraformDataSource("azurerm_netapp_snapshot_policy", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DailySchedule
        => AsReference("daily_schedule");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The hourly_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HourlySchedule
        => AsReference("hourly_schedule");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MonthlySchedule
        => AsReference("monthly_schedule");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WeeklySchedule
        => AsReference("weekly_schedule");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappSnapshotPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappSnapshotPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
