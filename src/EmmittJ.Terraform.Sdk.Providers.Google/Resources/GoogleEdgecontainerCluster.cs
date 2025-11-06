using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_edgecontainer_cluster resource.
/// </summary>
public class GoogleEdgecontainerCluster : TerraformResource
{
    public GoogleEdgecontainerCluster(string name) : base("google_edgecontainer_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_ca_certificate");
        this.DeclareOutput("control_plane_version");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("maintenance_events");
        this.DeclareOutput("node_version");
        this.DeclareOutput("port");
        this.DeclareOutput("status");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The default maximum number of pods per node used if a maximum value is not
    /// specified explicitly for a node pool in this cluster. If unspecified, the
    /// Kubernetes default value will be used.
    /// </summary>
    public double? DefaultMaxPodsPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_max_pods_per_node")?.Value;
        set => this.WithProperty("default_max_pods_per_node", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Address pools for cluster data plane external load balancing.
    /// </summary>
    public List<string>? ExternalLoadBalancerIpv4AddressPools
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("external_load_balancer_ipv4_address_pools")?.Value;
        set => this.WithProperty("external_load_balancer_ipv4_address_pools", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// User-defined labels for the edgecloud cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The GDCE cluster name.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The release channel a cluster is subscribed to. Possible values: [&amp;quot;RELEASE_CHANNEL_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;REGULAR&amp;quot;]
    /// </summary>
    public string? ReleaseChannel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_channel")?.Value;
        set => this.WithProperty("release_channel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target cluster version. For example: &amp;quot;1.5.0&amp;quot;.
    /// </summary>
    public string? TargetVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_version")?.Value;
        set => this.WithProperty("target_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The PEM-encoded public certificate of the cluster&#39;s CA.
    /// </summary>
    public TerraformExpression ClusterCaCertificate => this["cluster_ca_certificate"];

    /// <summary>
    /// The control plane release version.
    /// </summary>
    public TerraformExpression ControlPlaneVersion => this["control_plane_version"];

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The IP address of the Kubernetes API server.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// All the maintenance events scheduled for the cluster, including the ones
    /// ongoing, planned for the future and done in the past (up to 90 days).
    /// </summary>
    public TerraformExpression MaintenanceEvents => this["maintenance_events"];

    /// <summary>
    /// The lowest release version among all worker nodes. This field can be empty
    /// if the cluster does not have any worker nodes.
    /// </summary>
    public TerraformExpression NodeVersion => this["node_version"];

    /// <summary>
    /// The port number of the Kubernetes API server.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// Indicates the status of the cluster.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
