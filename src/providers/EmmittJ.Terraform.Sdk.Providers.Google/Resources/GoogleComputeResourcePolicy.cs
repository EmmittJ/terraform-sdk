using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for disk_consistency_group_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Enable disk consistency on the resource policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for group_placement_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyGroupPlacementPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The number of availability domains instances will be spread across. If two instances are in different
    /// availability domain, they will not be put in the same low latency network
    /// </summary>
    public TerraformProperty<double>? AvailabilityDomainCount
    {
        get => GetProperty<TerraformProperty<double>>("availability_domain_count");
        set => WithProperty("availability_domain_count", value);
    }

    /// <summary>
    /// Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network.
    /// Specify &#39;COLLOCATED&#39; to enable collocation. Can only be specified with &#39;vm_count&#39;. If compute instances are created
    /// with a COLLOCATED policy, then exactly &#39;vm_count&#39; instances must be created at the same time with the resource policy
    /// attached. Possible values: [&amp;quot;COLLOCATED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Collocation
    {
        get => GetProperty<TerraformProperty<string>>("collocation");
        set => WithProperty("collocation", value);
    }

    /// <summary>
    /// Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.
    /// </summary>
    public TerraformProperty<string>? GpuTopology
    {
        get => GetProperty<TerraformProperty<string>>("gpu_topology");
        set => WithProperty("gpu_topology", value);
    }

    /// <summary>
    /// Number of VMs in this placement group. Google does not recommend that you use this field
    /// unless you use a compact policy and you want your policy to work only if it contains this
    /// exact number of VMs.
    /// </summary>
    public TerraformProperty<double>? VmCount
    {
        get => GetProperty<TerraformProperty<double>>("vm_count");
        set => WithProperty("vm_count", value);
    }

}

/// <summary>
/// Block type for instance_schedule_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyInstanceSchedulePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The expiration time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    public TerraformProperty<string>? ExpirationTime
    {
        get => GetProperty<TerraformProperty<string>>("expiration_time");
        set => WithProperty("expiration_time", value);
    }

    /// <summary>
    /// The start time of the schedule. The timestamp is an RFC3339 string.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

    /// <summary>
    /// Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name
    /// from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for snapshot_schedule_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicySnapshotSchedulePolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeResourcePolicyTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for workload_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResourcePolicyWorkloadPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if max topology distance is set.
    /// </summary>
    public TerraformProperty<string>? AcceleratorTopology
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_topology");
        set => WithProperty("accelerator_topology", value);
    }

    /// <summary>
    /// The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT
    /// and cannot be set if accelerator topology is set. Possible values: [&amp;quot;BLOCK&amp;quot;, &amp;quot;CLUSTER&amp;quot;, &amp;quot;SUBBLOCK&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MaxTopologyDistance
    {
        get => GetProperty<TerraformProperty<string>>("max_topology_distance");
        set => WithProperty("max_topology_distance", value);
    }

    /// <summary>
    /// The type of workload policy. Possible values: [&amp;quot;HIGH_AVAILABILITY&amp;quot;, &amp;quot;HIGH_THROUGHPUT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a google_compute_resource_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeResourcePolicy : TerraformResource
{
    public GoogleComputeResourcePolicy(string name) : base("google_compute_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("self_link");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name of the resource, provided by the client when initially creating
    /// the resource. The resource name must be 1-63 characters long, and comply
    /// with RFC1035. Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])&#39;? which means the
    /// first character must be a lowercase letter, and all following characters
    /// must be a dash, lowercase letter, or digit, except the last character,
    /// which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for disk_consistency_group_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConsistencyGroupPolicy block(s) allowed")]
    public List<GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock>? DiskConsistencyGroupPolicy
    {
        get => GetProperty<List<GoogleComputeResourcePolicyDiskConsistencyGroupPolicyBlock>>("disk_consistency_group_policy");
        set => this.WithProperty("disk_consistency_group_policy", value);
    }

    /// <summary>
    /// Block for group_placement_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupPlacementPolicy block(s) allowed")]
    public List<GoogleComputeResourcePolicyGroupPlacementPolicyBlock>? GroupPlacementPolicy
    {
        get => GetProperty<List<GoogleComputeResourcePolicyGroupPlacementPolicyBlock>>("group_placement_policy");
        set => this.WithProperty("group_placement_policy", value);
    }

    /// <summary>
    /// Block for instance_schedule_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceSchedulePolicy block(s) allowed")]
    public List<GoogleComputeResourcePolicyInstanceSchedulePolicyBlock>? InstanceSchedulePolicy
    {
        get => GetProperty<List<GoogleComputeResourcePolicyInstanceSchedulePolicyBlock>>("instance_schedule_policy");
        set => this.WithProperty("instance_schedule_policy", value);
    }

    /// <summary>
    /// Block for snapshot_schedule_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotSchedulePolicy block(s) allowed")]
    public List<GoogleComputeResourcePolicySnapshotSchedulePolicyBlock>? SnapshotSchedulePolicy
    {
        get => GetProperty<List<GoogleComputeResourcePolicySnapshotSchedulePolicyBlock>>("snapshot_schedule_policy");
        set => this.WithProperty("snapshot_schedule_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeResourcePolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeResourcePolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workload_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadPolicy block(s) allowed")]
    public List<GoogleComputeResourcePolicyWorkloadPolicyBlock>? WorkloadPolicy
    {
        get => GetProperty<List<GoogleComputeResourcePolicyWorkloadPolicyBlock>>("workload_policy");
        set => this.WithProperty("workload_policy", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
