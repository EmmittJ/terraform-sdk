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
        this.DeclareOutput("description");
        this.DeclareOutput("disk_consistency_group_policy");
        this.DeclareOutput("group_placement_policy");
        this.DeclareOutput("instance_schedule_policy");
        this.DeclareOutput("self_link");
        this.DeclareOutput("snapshot_schedule_policy");
        this.DeclareOutput("workload_policy");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
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
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where resource policy resides.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
