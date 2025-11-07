using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_node_group resource.
/// </summary>
public class GoogleComputeNodeGroup : TerraformResource
{
    public GoogleComputeNodeGroup(string name) : base("google_compute_node_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
        this.DeclareOutput("size");
    }

    /// <summary>
    /// An optional textual description of the resource.
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
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    public TerraformProperty<double>? InitialSize
    {
        get => GetProperty<TerraformProperty<double>>("initial_size");
        set => this.WithProperty("initial_size", value);
    }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    public TerraformProperty<string>? MaintenancePolicy
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_policy");
        set => this.WithProperty("maintenance_policy", value);
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    public TerraformProperty<string>? NodeTemplate
    {
        get => GetProperty<TerraformProperty<string>>("node_template");
        set => this.WithProperty("node_template", value);
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
    /// Zone where this node group is located
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The total number of nodes in the node group.
    /// </summary>
    public TerraformExpression Size => this["size"];

}
