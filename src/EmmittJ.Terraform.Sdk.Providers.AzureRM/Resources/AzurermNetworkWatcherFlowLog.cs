using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkWatcherFlowLogRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public required TerraformProperty<double> Days
    {
        get => GetProperty<TerraformProperty<double>>("days");
        set => WithProperty("days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkWatcherFlowLogTimeoutsBlock : TerraformBlock
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
/// Block type for traffic_analytics in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkWatcherFlowLogTrafficAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The interval_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_minutes");
        set => WithProperty("interval_in_minutes", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The workspace_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceRegion is required")]
    public required TerraformProperty<string> WorkspaceRegion
    {
        get => GetProperty<TerraformProperty<string>>("workspace_region");
        set => WithProperty("workspace_region", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceResourceId is required")]
    public required TerraformProperty<string> WorkspaceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_resource_id");
        set => WithProperty("workspace_resource_id", value);
    }

}

/// <summary>
/// Manages a azurerm_network_watcher_flow_log resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetworkWatcherFlowLog : TerraformResource
{
    public AzurermNetworkWatcherFlowLog(string name) : base("azurerm_network_watcher_flow_log", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? NetworkSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_security_group_id");
        set => this.WithProperty("network_security_group_id", value);
    }

    /// <summary>
    /// The network_watcher_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkWatcherName is required")]
    public required TerraformProperty<string> NetworkWatcherName
    {
        get => GetProperty<TerraformProperty<string>>("network_watcher_name");
        set => this.WithProperty("network_watcher_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<double>? Version
    {
        get => GetProperty<TerraformProperty<double>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RetentionPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public List<AzurermNetworkWatcherFlowLogRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetProperty<List<AzurermNetworkWatcherFlowLogRetentionPolicyBlock>>("retention_policy");
        set => this.WithProperty("retention_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkWatcherFlowLogTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkWatcherFlowLogTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_analytics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficAnalytics block(s) allowed")]
    public List<AzurermNetworkWatcherFlowLogTrafficAnalyticsBlock>? TrafficAnalytics
    {
        get => GetProperty<List<AzurermNetworkWatcherFlowLogTrafficAnalyticsBlock>>("traffic_analytics");
        set => this.WithProperty("traffic_analytics", value);
    }

}
