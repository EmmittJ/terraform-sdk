using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_node_template resource.
/// </summary>
public class GoogleComputeNodeTemplate : TerraformResource
{
    public GoogleComputeNodeTemplate(string name) : base("google_compute_node_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// CPU overcommit. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CpuOvercommitType
    {
        get => GetProperty<TerraformProperty<string>>("cpu_overcommit_type");
        set => this.WithProperty("cpu_overcommit_type", value);
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
    /// Name of the resource.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Labels to use for node affinity, which will be used in
    /// instance scheduling.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? NodeAffinityLabels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("node_affinity_labels");
        set => this.WithProperty("node_affinity_labels", value);
    }

    /// <summary>
    /// Node type to use for nodes group that are created from this template.
    /// Only one of nodeTypeFlexibility and nodeType can be specified.
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
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
    /// Region where nodes using the node template will be created.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
