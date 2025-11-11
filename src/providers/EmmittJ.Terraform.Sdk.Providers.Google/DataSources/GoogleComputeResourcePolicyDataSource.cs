using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_resource_policy.
/// </summary>
public partial class GoogleComputeResourcePolicyDataSource : TerraformDataSource
{
    public GoogleComputeResourcePolicyDataSource(string name) : base("google_compute_resource_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// </summary>
    [TerraformProperty("disk_consistency_group_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DiskConsistencyGroupPolicy { get; }

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// </summary>
    [TerraformProperty("group_placement_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GroupPlacementPolicy { get; }

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// </summary>
    [TerraformProperty("instance_schedule_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InstanceSchedulePolicy { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// </summary>
    [TerraformProperty("snapshot_schedule_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SnapshotSchedulePolicy { get; }

    /// <summary>
    /// Represents the workload policy.
    /// </summary>
    [TerraformProperty("workload_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> WorkloadPolicy { get; }

}
