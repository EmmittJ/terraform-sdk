using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for retention_policy in AzurermNetworkWatcherFlowLog.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkWatcherFlowLogRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public required TerraformValue<double> Days
    {
        get => GetRequiredArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkWatcherFlowLog.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkWatcherFlowLogTimeoutsBlock : TerraformBlock
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
/// Block type for traffic_analytics in AzurermNetworkWatcherFlowLog.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkWatcherFlowLogTrafficAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_analytics";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The interval_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInMinutes
    {
        get => GetArgument<TerraformValue<double>>("interval_in_minutes");
        set => SetArgument("interval_in_minutes", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The workspace_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceRegion is required")]
    public required TerraformValue<string> WorkspaceRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_region");
        set => SetArgument("workspace_region", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceResourceId is required")]
    public required TerraformValue<string> WorkspaceResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_resource_id");
        set => SetArgument("workspace_resource_id", value);
    }

}


/// <summary>
/// Represents a azurerm_network_watcher_flow_log Terraform resource.
/// Manages a azurerm_network_watcher_flow_log resource.
/// </summary>
public partial class AzurermNetworkWatcherFlowLog(string name) : TerraformResource("azurerm_network_watcher_flow_log", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

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
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? AsReference("location");
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
    /// The network_security_group_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NetworkSecurityGroupId
    {
        get => GetArgument<TerraformValue<string>>("network_security_group_id") ?? AsReference("network_security_group_id");
        set => SetArgument("network_security_group_id", value);
    }

    /// <summary>
    /// The network_watcher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherName is required")]
    public required TerraformValue<string> NetworkWatcherName
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_watcher_name");
        set => SetArgument("network_watcher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformValue<string> TargetResourceId
    {
        get => GetArgument<TerraformValue<string>>("target_resource_id") ?? AsReference("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double>? Version
    {
        get => GetArgument<TerraformValue<double>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public required TerraformList<AzurermNetworkWatcherFlowLogRetentionPolicyBlock> RetentionPolicy
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkWatcherFlowLogRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkWatcherFlowLogTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkWatcherFlowLogTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrafficAnalytics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficAnalytics block(s) allowed")]
    public TerraformList<AzurermNetworkWatcherFlowLogTrafficAnalyticsBlock>? TrafficAnalytics
    {
        get => GetArgument<TerraformList<AzurermNetworkWatcherFlowLogTrafficAnalyticsBlock>>("traffic_analytics");
        set => SetArgument("traffic_analytics", value);
    }

}
