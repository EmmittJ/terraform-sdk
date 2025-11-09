using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_edgecontainer_node_pool resource.
/// </summary>
public class GoogleEdgecontainerNodePool : TerraformResource
{
    public GoogleEdgecontainerNodePool(string name) : base("google_edgecontainer_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("node_version");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The name of the target Distributed Cloud Edge Cluster.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
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
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Only machines matching this filter will be allowed to join the node pool.
    /// The filtering language accepts strings like &amp;quot;name=&amp;lt;name&amp;gt;&amp;quot;, and is
    /// documented in more detail in [AIP-160](https://google.aip.dev/160).
    /// </summary>
    public TerraformProperty<string>? MachineFilter
    {
        get => GetProperty<TerraformProperty<string>>("machine_filter");
        set => this.WithProperty("machine_filter", value);
    }

    /// <summary>
    /// The resource name of the node pool.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The number of nodes in the pool.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// Name of the Google Distributed Cloud Edge zone where this node pool will be created. For example: &#39;us-central1-edge-customer-a&#39;.
    /// </summary>
    public TerraformProperty<string>? NodeLocation
    {
        get => GetProperty<TerraformProperty<string>>("node_location");
        set => this.WithProperty("node_location", value);
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
    /// The time when the node pool was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The lowest release version among all worker nodes.
    /// </summary>
    public TerraformExpression NodeVersion => this["node_version"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the node pool was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
