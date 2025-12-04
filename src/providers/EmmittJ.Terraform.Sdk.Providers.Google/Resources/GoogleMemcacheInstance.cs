using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for maintenance_policy in GoogleMemcacheInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemcacheInstanceMaintenancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_policy";

    /// <summary>
    /// Output only. The time when the policy was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Optional. Description of what this policy is for.
    /// Create/Update methods return INVALID_ARGUMENT if the
    /// length is greater than 512.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Output only. The time when the policy was updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// WeeklyMaintenanceWindow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeeklyMaintenanceWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WeeklyMaintenanceWindow block(s) required")]
    public required TerraformList<GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock> WeeklyMaintenanceWindow
    {
        get => GetRequiredArgument<TerraformList<GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock>>("weekly_maintenance_window");
        set => SetArgument("weekly_maintenance_window", value);
    }

}

/// <summary>
/// Block type for weekly_maintenance_window in GoogleMemcacheInstanceMaintenancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_maintenance_window";

    /// <summary>
    /// Required. The day of week that maintenance updates occur.
    /// - DAY_OF_WEEK_UNSPECIFIED: The day of the week is unspecified.
    /// - MONDAY: Monday
    /// - TUESDAY: Tuesday
    /// - WEDNESDAY: Wednesday
    /// - THURSDAY: Thursday
    /// - FRIDAY: Friday
    /// - SATURDAY: Saturday
    /// - SUNDAY: Sunday Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => GetArgument<TerraformValue<string>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Required. The length of the maintenance window, ranging from 3 hours to 8 hours.
    /// A duration in seconds with up to nine fractional digits,
    /// terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMemcacheInstanceMaintenancePolicyBlockWeeklyMaintenanceWindowBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for memcache_parameters in GoogleMemcacheInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemcacheInstanceMemcacheParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memcache_parameters";

    /// <summary>
    /// This is a unique ID associated with this set of parameters.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// User-defined set of parameters to use in the memcache process.
    /// </summary>
    public TerraformMap<string>? ParamsAttribute
    {
        get => GetArgument<TerraformMap<string>>("params");
        set => SetArgument("params", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleMemcacheInstance.
/// Nesting mode: list
/// </summary>
public class GoogleMemcacheInstanceNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// Number of CPUs per node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCount is required")]
    public required TerraformValue<double> CpuCount
    {
        get => GetArgument<TerraformValue<double>>("cpu_count");
        set => SetArgument("cpu_count", value);
    }

    /// <summary>
    /// Memory size in Mebibytes for each memcache node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemorySizeMb is required")]
    public required TerraformValue<double> MemorySizeMb
    {
        get => GetArgument<TerraformValue<double>>("memory_size_mb");
        set => SetArgument("memory_size_mb", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMemcacheInstance.
/// Nesting mode: single
/// </summary>
public class GoogleMemcacheInstanceTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_memcache_instance Terraform resource.
/// Manages a google_memcache_instance resource.
/// </summary>
public partial class GoogleMemcacheInstance(string name) : TerraformResource("google_memcache_instance", name)
{
    /// <summary>
    /// The full name of the GCE network to connect the instance to.  If not provided,
    /// &#39;default&#39; will be used.
    /// </summary>
    public TerraformValue<string>? AuthorizedNetwork
    {
        get => GetArgument<TerraformValue<string>>("authorized_network");
        set => SetArgument("authorized_network", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance.
    /// When a &#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the instance,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the instance will fail.
    /// When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// A user-visible name for the instance.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The major version of Memcached software. If not provided, latest supported version will be used.
    /// Currently the latest supported major version is MEMCACHE_1_5. The minor version will be automatically
    /// determined by our system based on the latest supported minor version. Default value: &amp;quot;MEMCACHE_1_5&amp;quot; Possible values: [&amp;quot;MEMCACHE_1_5&amp;quot;, &amp;quot;MEMCACHE_1_6_15&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MemcacheVersion
    {
        get => GetArgument<TerraformValue<string>>("memcache_version");
        set => SetArgument("memcache_version", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Number of nodes in the memcache instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformValue<double> NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the Memcache instance. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Contains the name of allocated IP address ranges associated with
    /// the private service access connection for example, &amp;quot;test-default&amp;quot;
    /// associated with IP range 10.0.0.0/29.
    /// </summary>
    public TerraformList<string>? ReservedIpRangeId
    {
        get => GetArgument<TerraformList<string>>("reserved_ip_range_id");
        set => SetArgument("reserved_ip_range_id", value);
    }

    /// <summary>
    /// Zones where memcache nodes should be provisioned.  If not
    /// provided, all zones will be used.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Endpoint for Discovery API
    /// </summary>
    public TerraformValue<string> DiscoveryEndpoint
        => AsReference("discovery_endpoint");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Output only. Published maintenance schedule.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceSchedule
        => AsReference("maintenance_schedule");

    /// <summary>
    /// The full version of memcached server running on this instance.
    /// </summary>
    public TerraformValue<string> MemcacheFullVersion
        => AsReference("memcache_full_version");

    /// <summary>
    /// Additional information about the instance state, if available.
    /// </summary>
    public TerraformList<TerraformMap<object>> MemcacheNodes
        => AsReference("memcache_nodes");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// MaintenancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenancePolicy block(s) allowed")]
    public TerraformList<GoogleMemcacheInstanceMaintenancePolicyBlock>? MaintenancePolicy
    {
        get => GetArgument<TerraformList<GoogleMemcacheInstanceMaintenancePolicyBlock>>("maintenance_policy");
        set => SetArgument("maintenance_policy", value);
    }

    /// <summary>
    /// MemcacheParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemcacheParameters block(s) allowed")]
    public TerraformList<GoogleMemcacheInstanceMemcacheParametersBlock>? MemcacheParameters
    {
        get => GetArgument<TerraformList<GoogleMemcacheInstanceMemcacheParametersBlock>>("memcache_parameters");
        set => SetArgument("memcache_parameters", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public required TerraformList<GoogleMemcacheInstanceNodeConfigBlock> NodeConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleMemcacheInstanceNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMemcacheInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMemcacheInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
