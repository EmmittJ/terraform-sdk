using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for delete_after_duration in GoogleComputeReservation.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationDeleteAfterDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delete_after_duration";

    /// <summary>
    /// Number of nanoseconds for the auto-delete duration.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Number of seconds for the auto-delete duration.
    /// </summary>
    public TerraformValue<string>? Seconds
    {
        get => GetArgument<TerraformValue<string>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for reservation_sharing_policy in GoogleComputeReservation.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationReservationSharingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_sharing_policy";

    /// <summary>
    /// Sharing config for all Google Cloud services. Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;DISALLOW_ALL&amp;quot;]
    /// </summary>
    public TerraformValue<string> ServiceShareType
    {
        get => GetArgument<TerraformValue<string>>("service_share_type") ?? CreateReference("service_share_type");
        set => SetArgument("service_share_type", value);
    }

}


/// <summary>
/// Block type for share_settings in GoogleComputeReservation.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationShareSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_settings";

    /// <summary>
    /// Type of sharing for this shared-reservation Possible values: [&amp;quot;LOCAL&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;]
    /// </summary>
    public TerraformValue<string> ShareType
    {
        get => GetArgument<TerraformValue<string>>("share_type") ?? CreateReference("share_type");
        set => SetArgument("share_type", value);
    }

    /// <summary>
    /// ProjectMap block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeReservationShareSettingsBlockProjectMapBlock>? ProjectMap
    {
        get => GetArgument<TerraformSet<GoogleComputeReservationShareSettingsBlockProjectMapBlock>>("project_map");
        set => SetArgument("project_map", value);
    }

}

/// <summary>
/// Block type for project_map in GoogleComputeReservationShareSettingsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeReservationShareSettingsBlockProjectMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "project_map";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project id/number, should be same as the key of this project config in the project map.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for specific_reservation in GoogleComputeReservation.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationSpecificReservationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "specific_reservation";

    /// <summary>
    /// The number of resources that are allocated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// How many instances are in use.
    /// </summary>
    public TerraformValue<double> InUseCount
        => CreateReference("in_use_count");

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    public TerraformValue<string>? SourceInstanceTemplate
    {
        get => GetArgument<TerraformValue<string>>("source_instance_template");
        set => SetArgument("source_instance_template", value);
    }

    /// <summary>
    /// InstanceProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceProperties block(s) allowed")]
    public TerraformList<GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlock>? InstanceProperties
    {
        get => GetArgument<TerraformList<GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlock>>("instance_properties");
        set => SetArgument("instance_properties", value);
    }

}

/// <summary>
/// Block type for instance_properties in GoogleComputeReservationSpecificReservationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_properties";

    /// <summary>
    /// The name of the machine type to reserve.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => GetRequiredArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The minimum CPU platform for the reservation. For example,
    /// &#39;&amp;quot;Intel Skylake&amp;quot;&#39;. See
    /// the CPU platform availability reference](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform#availablezones)
    /// for information on available CPU platforms.
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// GuestAccelerators block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlockGuestAcceleratorsBlock>? GuestAccelerators
    {
        get => GetArgument<TerraformList<GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlockGuestAcceleratorsBlock>>("guest_accelerators");
        set => SetArgument("guest_accelerators", value);
    }

    /// <summary>
    /// LocalSsds block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlockLocalSsdsBlock>? LocalSsds
    {
        get => GetArgument<TerraformList<GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlockLocalSsdsBlock>>("local_ssds");
        set => SetArgument("local_ssds", value);
    }

}

/// <summary>
/// Block type for guest_accelerators in GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlockGuestAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guest_accelerators";

    /// <summary>
    /// The number of the guest accelerator cards exposed to
    /// this instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorCount is required")]
    public required TerraformValue<double> AcceleratorCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// The full or partial URL of the accelerator type to
    /// attach to this instance. For example:
    /// &#39;projects/my-project/zones/us-central1-c/acceleratorTypes/nvidia-tesla-p100&#39;
    /// 
    /// If you are creating an instance template, specify only the accelerator name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    public required TerraformValue<string> AcceleratorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for local_ssds in GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationSpecificReservationBlockInstancePropertiesBlockLocalSsdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_ssds";

    /// <summary>
    /// The size of the disk in base-2 GB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The disk interface to use for attaching this disk. Default value: &amp;quot;SCSI&amp;quot; Possible values: [&amp;quot;SCSI&amp;quot;, &amp;quot;NVME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? InterfaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("interface");
        set => SetArgument("interface", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeReservation.
/// Nesting mode: single
/// </summary>
public class GoogleComputeReservationTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_reservation Terraform resource.
/// Manages a google_compute_reservation resource.
/// </summary>
public partial class GoogleComputeReservation(string name) : TerraformResource("google_compute_reservation", name)
{
    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    public TerraformValue<string> DeleteAtTime
    {
        get => GetArgument<TerraformValue<string>>("delete_at_time") ?? CreateReference("delete_at_time");
        set => SetArgument("delete_at_time", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? SpecificReservationRequired
    {
        get => GetArgument<TerraformValue<bool>>("specific_reservation_required");
        set => SetArgument("specific_reservation_required", value);
    }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => GetRequiredArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Full or partial URL to a parent commitment. This field displays for
    /// reservations that are tied to a commitment.
    /// </summary>
    public TerraformValue<string> Commitment
        => CreateReference("commitment");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// DeleteAfterDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteAfterDuration block(s) allowed")]
    public TerraformList<GoogleComputeReservationDeleteAfterDurationBlock>? DeleteAfterDuration
    {
        get => GetArgument<TerraformList<GoogleComputeReservationDeleteAfterDurationBlock>>("delete_after_duration");
        set => SetArgument("delete_after_duration", value);
    }

    /// <summary>
    /// ReservationSharingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationSharingPolicy block(s) allowed")]
    public TerraformList<GoogleComputeReservationReservationSharingPolicyBlock>? ReservationSharingPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeReservationReservationSharingPolicyBlock>>("reservation_sharing_policy");
        set => SetArgument("reservation_sharing_policy", value);
    }

    /// <summary>
    /// ShareSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    public TerraformList<GoogleComputeReservationShareSettingsBlock>? ShareSettings
    {
        get => GetArgument<TerraformList<GoogleComputeReservationShareSettingsBlock>>("share_settings");
        set => SetArgument("share_settings", value);
    }

    /// <summary>
    /// SpecificReservation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpecificReservation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpecificReservation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    public required TerraformList<GoogleComputeReservationSpecificReservationBlock> SpecificReservation
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeReservationSpecificReservationBlock>>("specific_reservation");
        set => SetArgument("specific_reservation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeReservationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeReservationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
