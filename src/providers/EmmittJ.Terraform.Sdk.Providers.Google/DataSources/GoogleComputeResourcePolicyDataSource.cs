using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_resource_policy.
/// </summary>
public class GoogleComputeResourcePolicyDataSource : TerraformDataSource
{
    public GoogleComputeResourcePolicyDataSource(string name) : base("google_compute_resource_policy", name)
    {
    }

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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// </summary>
    [TerraformPropertyName("disk_consistency_group_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DiskConsistencyGroupPolicy => new TerraformReference(this, "disk_consistency_group_policy");

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// </summary>
    [TerraformPropertyName("group_placement_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GroupPlacementPolicy => new TerraformReference(this, "group_placement_policy");

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// </summary>
    [TerraformPropertyName("instance_schedule_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceSchedulePolicy => new TerraformReference(this, "instance_schedule_policy");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// </summary>
    [TerraformPropertyName("snapshot_schedule_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SnapshotSchedulePolicy => new TerraformReference(this, "snapshot_schedule_policy");

    /// <summary>
    /// Represents the workload policy.
    /// </summary>
    [TerraformPropertyName("workload_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkloadPolicy => new TerraformReference(this, "workload_policy");

}
