using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_resource_policy Terraform data source.
/// Retrieves information about a google_compute_resource_policy.
/// </summary>
public partial class GoogleComputeResourcePolicyDataSource(string name) : TerraformDataSource("google_compute_resource_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Region where resource policy resides.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskConsistencyGroupPolicy
        => AsReference("disk_consistency_group_policy");

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> GroupPlacementPolicy
        => AsReference("group_placement_policy");

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceSchedulePolicy
        => AsReference("instance_schedule_policy");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// </summary>
    public TerraformList<TerraformMap<object>> SnapshotSchedulePolicy
        => AsReference("snapshot_schedule_policy");

    /// <summary>
    /// Represents the workload policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadPolicy
        => AsReference("workload_policy");

}
