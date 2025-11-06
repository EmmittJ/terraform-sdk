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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The initial number of nodes in the node group. One of &#39;initial_size&#39; or &#39;autoscaling_policy&#39; must be configured on resource creation.
    /// </summary>
    public double? InitialSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("initial_size")?.Value;
        set => this.WithProperty("initial_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Specifies how to handle instances when a node in the group undergoes maintenance. Set to one of: DEFAULT, RESTART_IN_PLACE, or MIGRATE_WITHIN_NODE_GROUP. The default value is DEFAULT.
    /// </summary>
    public string? MaintenancePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_policy")?.Value;
        set => this.WithProperty("maintenance_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URL of the node template to which this node group belongs.
    /// </summary>
    public string? NodeTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_template")?.Value;
        set => this.WithProperty("node_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Zone where this node group is located
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
