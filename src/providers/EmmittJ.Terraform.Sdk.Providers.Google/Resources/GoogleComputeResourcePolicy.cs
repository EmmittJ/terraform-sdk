using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for disk_consistency_group_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock() : TerraformBlock("disk_consistency_group_policy")
{
    /// <summary>
    /// Enable disk consistency on the resource policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for group_placement_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeResourcePolicyGroupPlacementPolicyBlock() : TerraformBlock("group_placement_policy")
{
    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    [TerraformProperty("availability_domain_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AvailabilityDomainCount { get; set; }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify &#39;COLLOCATED&#39; to enable collocation. Can only be specified with &#39;vm_count&#39;. If compute instances are created
    /// with a COLLOCATED policy, then exactly &#39;vm_count&#39; instances must be created at the same time with the resource policy
    /// attached. Possible values: [&amp;quot;COLLOCATED&amp;quot;]
    /// </summary>
    [TerraformProperty("collocation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Collocation { get; set; }

    /// <summary>
    /// Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.
    /// </summary>
    [TerraformProperty("gpu_topology")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GpuTopology { get; set; }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    [TerraformProperty("vm_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VmCount { get; set; }

}

/// <summary>
/// Block type for instance_schedule_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeResourcePolicyInstanceSchedulePolicyBlock() : TerraformBlock("instance_schedule_policy")
{
    /// <summary>
    /// The expiration time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationTime { get; set; }

    /// <summary>
    /// The start time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformProperty("time_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZone { get; set; }

}

/// <summary>
/// Block type for snapshot_schedule_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeResourcePolicySnapshotSchedulePolicyBlock() : TerraformBlock("snapshot_schedule_policy")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeResourcePolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for workload_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeResourcePolicyWorkloadPolicyBlock() : TerraformBlock("workload_policy")
{
    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    [TerraformProperty("accelerator_topology")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorTopology { get; set; }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set. Possible values: [&amp;quot;BLOCK&amp;quot;, &amp;quot;CLUSTER&amp;quot;, &amp;quot;SUBBLOCK&amp;quot;]
    /// </summary>
    [TerraformProperty("max_topology_distance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxTopologyDistance { get; set; }

    /// <summary>
    /// The type of workload policy. Possible values: [&amp;quot;HIGH_AVAILABILITY&amp;quot;, &amp;quot;HIGH_THROUGHPUT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a google_compute_resource_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeResourcePolicy : TerraformResource
{
    public GoogleComputeResourcePolicy(string name) : base("google_compute_resource_policy", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for disk_consistency_group_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConsistencyGroupPolicy block(s) allowed")]
    [TerraformProperty("disk_consistency_group_policy")]
    public TerraformList<GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock> DiskConsistencyGroupPolicy { get; set; } = new();

    /// <summary>
    /// Block for group_placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupPlacementPolicy block(s) allowed")]
    [TerraformProperty("group_placement_policy")]
    public TerraformList<GoogleComputeResourcePolicyGroupPlacementPolicyBlock> GroupPlacementPolicy { get; set; } = new();

    /// <summary>
    /// Block for instance_schedule_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceSchedulePolicy block(s) allowed")]
    [TerraformProperty("instance_schedule_policy")]
    public TerraformList<GoogleComputeResourcePolicyInstanceSchedulePolicyBlock> InstanceSchedulePolicy { get; set; } = new();

    /// <summary>
    /// Block for snapshot_schedule_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotSchedulePolicy block(s) allowed")]
    [TerraformProperty("snapshot_schedule_policy")]
    public TerraformList<GoogleComputeResourcePolicySnapshotSchedulePolicyBlock> SnapshotSchedulePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeResourcePolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workload_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadPolicy block(s) allowed")]
    [TerraformProperty("workload_policy")]
    public TerraformList<GoogleComputeResourcePolicyWorkloadPolicyBlock> WorkloadPolicy { get; set; } = new();

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
