using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for disk_consistency_group_policy in GoogleComputeResourcePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_consistency_group_policy";

    /// <summary>
    /// Enable disk consistency on the resource policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for group_placement_policy in GoogleComputeResourcePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyGroupPlacementPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_placement_policy";

    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    public TerraformValue<double>? AvailabilityDomainCount
    {
        get => new TerraformReference<double>(this, "availability_domain_count");
        set => SetArgument("availability_domain_count", value);
    }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify &#39;COLLOCATED&#39; to enable collocation. Can only be specified with &#39;vm_count&#39;. If compute instances are created
    /// with a COLLOCATED policy, then exactly &#39;vm_count&#39; instances must be created at the same time with the resource policy
    /// attached. Possible values: [&amp;quot;COLLOCATED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Collocation
    {
        get => new TerraformReference<string>(this, "collocation");
        set => SetArgument("collocation", value);
    }

    /// <summary>
    /// Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.
    /// </summary>
    public TerraformValue<string>? GpuTopology
    {
        get => new TerraformReference<string>(this, "gpu_topology");
        set => SetArgument("gpu_topology", value);
    }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    public TerraformValue<double>? VmCount
    {
        get => new TerraformReference<double>(this, "vm_count");
        set => SetArgument("vm_count", value);
    }

}


/// <summary>
/// Block type for instance_schedule_policy in GoogleComputeResourcePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyInstanceSchedulePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_schedule_policy";

    /// <summary>
    /// The expiration time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    public TerraformValue<string>? ExpirationTime
    {
        get => new TerraformReference<string>(this, "expiration_time");
        set => SetArgument("expiration_time", value);
    }

    /// <summary>
    /// The start time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// VmStartSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmStartSchedule block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlockVmStartScheduleBlock>? VmStartSchedule
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlockVmStartScheduleBlock>>("vm_start_schedule");
        set => SetArgument("vm_start_schedule", value);
    }

    /// <summary>
    /// VmStopSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmStopSchedule block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlockVmStopScheduleBlock>? VmStopSchedule
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlockVmStopScheduleBlock>>("vm_stop_schedule");
        set => SetArgument("vm_stop_schedule", value);
    }

}

/// <summary>
/// Block type for vm_start_schedule in GoogleComputeResourcePolicyInstanceSchedulePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyInstanceSchedulePolicyBlockVmStartScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vm_start_schedule";

    /// <summary>
    /// Specifies the frequency for the operation, using the unix-cron format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for vm_stop_schedule in GoogleComputeResourcePolicyInstanceSchedulePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyInstanceSchedulePolicyBlockVmStopScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vm_stop_schedule";

    /// <summary>
    /// Specifies the frequency for the operation, using the unix-cron format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

}


/// <summary>
/// Block type for snapshot_schedule_policy in GoogleComputeResourcePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot_schedule_policy";

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// SnapshotProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotProperties block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockSnapshotPropertiesBlock>? SnapshotProperties
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockSnapshotPropertiesBlock>>("snapshot_properties");
        set => SetArgument("snapshot_properties", value);
    }

}

/// <summary>
/// Block type for retention_policy in GoogleComputeResourcePolicySnapshotSchedulePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// Maximum age of the snapshot that is allowed to be kept.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRetentionDays is required")]
    public required TerraformValue<double> MaxRetentionDays
    {
        get => new TerraformReference<double>(this, "max_retention_days");
        set => SetArgument("max_retention_days", value);
    }

    /// <summary>
    /// Specifies the behavior to apply to scheduled snapshots when
    /// the source disk is deleted. Default value: &amp;quot;KEEP_AUTO_SNAPSHOTS&amp;quot; Possible values: [&amp;quot;KEEP_AUTO_SNAPSHOTS&amp;quot;, &amp;quot;APPLY_RETENTION_POLICY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OnSourceDiskDelete
    {
        get => new TerraformReference<string>(this, "on_source_disk_delete");
        set => SetArgument("on_source_disk_delete", value);
    }

}

/// <summary>
/// Block type for schedule in GoogleComputeResourcePolicySnapshotSchedulePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// DailySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailySchedule block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockDailyScheduleBlock>? DailySchedule
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockDailyScheduleBlock>>("daily_schedule");
        set => SetArgument("daily_schedule", value);
    }

    /// <summary>
    /// HourlySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlySchedule block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockHourlyScheduleBlock>? HourlySchedule
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockHourlyScheduleBlock>>("hourly_schedule");
        set => SetArgument("hourly_schedule", value);
    }

    /// <summary>
    /// WeeklySchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklySchedule block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlock>? WeeklySchedule
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlock>>("weekly_schedule");
        set => SetArgument("weekly_schedule", value);
    }

}

/// <summary>
/// Block type for daily_schedule in GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockDailyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_schedule";

    /// <summary>
    /// Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysInCycle is required")]
    public required TerraformValue<double> DaysInCycle
    {
        get => new TerraformReference<double>(this, "days_in_cycle");
        set => SetArgument("days_in_cycle", value);
    }

    /// <summary>
    /// This must be in UTC format that resolves to one of
    /// 00:00, 04:00, 08:00, 12:00, 16:00, or 20:00. For example,
    /// both 13:00-5 and 08:00 are valid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for hourly_schedule in GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockHourlyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hourly_schedule";

    /// <summary>
    /// The number of hours between snapshots.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursInCycle is required")]
    public required TerraformValue<double> HoursInCycle
    {
        get => new TerraformReference<double>(this, "hours_in_cycle");
        set => SetArgument("hours_in_cycle", value);
    }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in an hourly format &amp;quot;HH:MM&amp;quot;,
    /// where HH : [00-23] and MM : [00] GMT. eg: 21:00
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for weekly_schedule in GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_schedule";

    /// <summary>
    /// DayOfWeeks block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeeks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DayOfWeeks block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(7, ErrorMessage = "Maximum 7 DayOfWeeks block(s) allowed")]
    public required TerraformSet<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlockDayOfWeeksBlock> DayOfWeeks
    {
        get => GetRequiredArgument<TerraformSet<GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlockDayOfWeeksBlock>>("day_of_weeks");
        set => SetArgument("day_of_weeks", value);
    }

}

/// <summary>
/// Block type for day_of_weeks in GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockScheduleBlockWeeklyScheduleBlockDayOfWeeksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "day_of_weeks";

    /// <summary>
    /// The day of the week to create the snapshot. e.g. MONDAY Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<string> Day
    {
        get => new TerraformReference<string>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Time within the window to start the operations.
    /// It must be in format &amp;quot;HH:MM&amp;quot;, where HH : [00-23] and MM : [00-00] GMT.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for snapshot_properties in GoogleComputeResourcePolicySnapshotSchedulePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlockSnapshotPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot_properties";

    /// <summary>
    /// Creates the new snapshot in the snapshot chain labeled with the
    /// specified name. The chain name must be 1-63 characters long and comply
    /// with RFC1035.
    /// </summary>
    public TerraformValue<string>? ChainName
    {
        get => new TerraformReference<string>(this, "chain_name");
        set => SetArgument("chain_name", value);
    }

    /// <summary>
    /// Whether to perform a &#39;guest aware&#39; snapshot.
    /// </summary>
    public TerraformValue<bool>? GuestFlush
    {
        get => new TerraformReference<bool>(this, "guest_flush");
        set => SetArgument("guest_flush", value);
    }

    /// <summary>
    /// A set of key-value pairs.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Cloud Storage bucket location to store the auto snapshot
    /// (regional or multi-regional)
    /// </summary>
    public TerraformSet<string>? StorageLocations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "storage_locations").ResolveNodes(ctx));
        set => SetArgument("storage_locations", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeResourcePolicy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeResourcePolicyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for workload_policy in GoogleComputeResourcePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyWorkloadPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_policy";

    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    public TerraformValue<string>? AcceleratorTopology
    {
        get => new TerraformReference<string>(this, "accelerator_topology");
        set => SetArgument("accelerator_topology", value);
    }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set. Possible values: [&amp;quot;BLOCK&amp;quot;, &amp;quot;CLUSTER&amp;quot;, &amp;quot;SUBBLOCK&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MaxTopologyDistance
    {
        get => new TerraformReference<string>(this, "max_topology_distance");
        set => SetArgument("max_topology_distance", value);
    }

    /// <summary>
    /// The type of workload policy. Possible values: [&amp;quot;HIGH_AVAILABILITY&amp;quot;, &amp;quot;HIGH_THROUGHPUT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a google_compute_resource_policy Terraform resource.
/// Manages a google_compute_resource_policy resource.
/// </summary>
public partial class GoogleComputeResourcePolicy(string name) : TerraformResource("google_compute_resource_policy", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the resource, provided by the client when initially creating
    /// the resource. The resource name must be 1-63 characters long, and comply
    /// with RFC1035. Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])&#39;? which means the
    /// first character must be a lowercase letter, and all following characters
    /// must be a dash, lowercase letter, or digit, except the last character,
    /// which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// DiskConsistencyGroupPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConsistencyGroupPolicy block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock>? DiskConsistencyGroupPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock>>("disk_consistency_group_policy");
        set => SetArgument("disk_consistency_group_policy", value);
    }

    /// <summary>
    /// GroupPlacementPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupPlacementPolicy block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicyGroupPlacementPolicyBlock>? GroupPlacementPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicyGroupPlacementPolicyBlock>>("group_placement_policy");
        set => SetArgument("group_placement_policy", value);
    }

    /// <summary>
    /// InstanceSchedulePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceSchedulePolicy block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlock>? InstanceSchedulePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlock>>("instance_schedule_policy");
        set => SetArgument("instance_schedule_policy", value);
    }

    /// <summary>
    /// SnapshotSchedulePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotSchedulePolicy block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlock>? SnapshotSchedulePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlock>>("snapshot_schedule_policy");
        set => SetArgument("snapshot_schedule_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeResourcePolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeResourcePolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkloadPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadPolicy block(s) allowed")]
    public TerraformList<GoogleComputeResourcePolicyWorkloadPolicyBlock>? WorkloadPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeResourcePolicyWorkloadPolicyBlock>>("workload_policy");
        set => SetArgument("workload_policy", value);
    }

}
