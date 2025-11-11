using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for disk_consistency_group_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock
{
    /// <summary>
    /// Enable disk consistency on the resource policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for group_placement_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyGroupPlacementPolicyBlock
{
    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    [TerraformPropertyName("availability_domain_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AvailabilityDomainCount { get; set; }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify &#39;COLLOCATED&#39; to enable collocation. Can only be specified with &#39;vm_count&#39;. If compute instances are created
    /// with a COLLOCATED policy, then exactly &#39;vm_count&#39; instances must be created at the same time with the resource policy
    /// attached. Possible values: [&amp;quot;COLLOCATED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("collocation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Collocation { get; set; }

    /// <summary>
    /// Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.
    /// </summary>
    [TerraformPropertyName("gpu_topology")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GpuTopology { get; set; }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    [TerraformPropertyName("vm_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VmCount { get; set; }

}

/// <summary>
/// Block type for instance_schedule_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyInstanceSchedulePolicyBlock
{
    /// <summary>
    /// The expiration time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpirationTime { get; set; }

    /// <summary>
    /// The start time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformPropertyName("time_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeZone { get; set; }

}

/// <summary>
/// Block type for snapshot_schedule_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeResourcePolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for workload_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyWorkloadPolicyBlock
{
    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    [TerraformPropertyName("accelerator_topology")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcceleratorTopology { get; set; }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set. Possible values: [&amp;quot;BLOCK&amp;quot;, &amp;quot;CLUSTER&amp;quot;, &amp;quot;SUBBLOCK&amp;quot;]
    /// </summary>
    [TerraformPropertyName("max_topology_distance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxTopologyDistance { get; set; }

    /// <summary>
    /// The type of workload policy. Possible values: [&amp;quot;HIGH_AVAILABILITY&amp;quot;, &amp;quot;HIGH_THROUGHPUT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a google_compute_resource_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeResourcePolicy : TerraformResource
{
    public GoogleComputeResourcePolicy(string name) : base("google_compute_resource_policy", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for disk_consistency_group_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConsistencyGroupPolicy block(s) allowed")]
    [TerraformPropertyName("disk_consistency_group_policy")]
    public TerraformList<TerraformBlock<GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock>>? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>
    /// Block for group_placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupPlacementPolicy block(s) allowed")]
    [TerraformPropertyName("group_placement_policy")]
    public TerraformList<TerraformBlock<GoogleComputeResourcePolicyGroupPlacementPolicyBlock>>? GroupPlacementPolicy { get; set; }

    /// <summary>
    /// Block for instance_schedule_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceSchedulePolicy block(s) allowed")]
    [TerraformPropertyName("instance_schedule_policy")]
    public TerraformList<TerraformBlock<GoogleComputeResourcePolicyInstanceSchedulePolicyBlock>>? InstanceSchedulePolicy { get; set; }

    /// <summary>
    /// Block for snapshot_schedule_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotSchedulePolicy block(s) allowed")]
    [TerraformPropertyName("snapshot_schedule_policy")]
    public TerraformList<TerraformBlock<GoogleComputeResourcePolicySnapshotSchedulePolicyBlock>>? SnapshotSchedulePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeResourcePolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for workload_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadPolicy block(s) allowed")]
    [TerraformPropertyName("workload_policy")]
    public TerraformList<TerraformBlock<GoogleComputeResourcePolicyWorkloadPolicyBlock>>? WorkloadPolicy { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

}
