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
    public string? CpuOvercommitType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cpu_overcommit_type")?.Value;
        set => this.WithProperty("cpu_overcommit_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Name of the resource.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels to use for node affinity, which will be used in
    /// instance scheduling.
    /// </summary>
    public Dictionary<string, string>? NodeAffinityLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("node_affinity_labels")?.Value;
        set => this.WithProperty("node_affinity_labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Node type to use for nodes group that are created from this template.
    /// Only one of nodeTypeFlexibility and nodeType can be specified.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where nodes using the node template will be created.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
