using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_resource_policy.
/// </summary>
public class GoogleComputeResourcePolicyDataSource : TerraformDataSource
{
    public GoogleComputeResourcePolicyDataSource(string name) : base("google_compute_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("disk_consistency_group_policy");
        SetOutput("group_placement_policy");
        SetOutput("instance_schedule_policy");
        SetOutput("self_link");
        SetOutput("snapshot_schedule_policy");
        SetOutput("workload_policy");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Replication consistency group for asynchronous disk replication.
    /// </summary>
    public TerraformExpression DiskConsistencyGroupPolicy => this["disk_consistency_group_policy"];

    /// <summary>
    /// Resource policy for instances used for placement configuration.
    /// </summary>
    public TerraformExpression GroupPlacementPolicy => this["group_placement_policy"];

    /// <summary>
    /// Resource policy for scheduling instance operations.
    /// </summary>
    public TerraformExpression InstanceSchedulePolicy => this["instance_schedule_policy"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Policy for creating snapshots of persistent disks.
    /// </summary>
    public TerraformExpression SnapshotSchedulePolicy => this["snapshot_schedule_policy"];

    /// <summary>
    /// Represents the workload policy.
    /// </summary>
    public TerraformExpression WorkloadPolicy => this["workload_policy"];

}
