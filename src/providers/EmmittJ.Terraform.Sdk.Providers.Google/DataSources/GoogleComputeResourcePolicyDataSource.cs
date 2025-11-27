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
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskConsistencyGroupPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "disk_consistency_group_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> GroupPlacementPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "group_placement_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceSchedulePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_schedule_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// </summary>
    public TerraformList<TerraformMap<object>> SnapshotSchedulePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "snapshot_schedule_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Represents the workload policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workload_policy").ResolveNodes(ctx));
    }

}
