using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gkeonprem_vmware_admin_cluster resource.
/// </summary>
public class GoogleGkeonpremVmwareAdminCluster : TerraformResource
{
    public GoogleGkeonpremVmwareAdminCluster(string name) : base("google_gkeonprem_vmware_admin_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("etag");
        this.DeclareOutput("fleet");
        this.DeclareOutput("local_name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Annotations on the VMware Admin Cluster.
    /// This field has the same restrictions as Kubernetes annotations.
    /// The total size of all keys and values combined is limited to 256k.
    /// Key can have 2 segments: prefix (optional) and name (required),
    /// separated by a slash (/).
    /// Prefix must be a DNS subdomain.
    /// Name must be 63 characters or less, begin and end with alphanumerics,
    /// with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Annotations
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The bootstrap cluster this VMware admin cluster belongs to.
    /// </summary>
    public TerraformProperty<string>? BootstrapClusterMembership
    {
        get => GetProperty<TerraformProperty<string>>("bootstrap_cluster_membership");
        set => this.WithProperty("bootstrap_cluster_membership", value);
    }

    /// <summary>
    /// A human readable description of this VMware admin cluster.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// If set, the advanced cluster feature is enabled.
    /// </summary>
    public TerraformProperty<bool>? EnableAdvancedCluster
    {
        get => GetProperty<TerraformProperty<bool>>("enable_advanced_cluster");
        set => this.WithProperty("enable_advanced_cluster", value);
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
    /// The OS image type for the VMware admin cluster.
    /// </summary>
    public TerraformProperty<string>? ImageType
    {
        get => GetProperty<TerraformProperty<string>>("image_type");
        set => this.WithProperty("image_type", value);
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
    /// The VMware admin cluster resource name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Anthos clusters on the VMware version for the admin cluster.
    /// </summary>
    public TerraformProperty<string>? OnPremVersion
    {
        get => GetProperty<TerraformProperty<string>>("on_prem_version");
        set => this.WithProperty("on_prem_version", value);
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
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// The DNS name of VMware admin cluster&#39;s API server.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Fleet configuration for the cluster.
    /// </summary>
    public TerraformExpression Fleet => this["fleet"];

    /// <summary>
    /// The object name of the VMwareAdminCluster custom resource on the
    /// associated admin cluster. This field is used to support conflicting
    /// names when enrolling existing clusters to the API. When used as a part of
    /// cluster enrollment, this field will differ from the ID in the resource
    /// name. For new clusters, this field will match the user provided cluster ID
    /// and be visible in the last component of the resource name. It is not
    /// modifiable.
    /// All users should use this name to access their cluster using gkectl or
    /// kubectl and should expect to see the local name when viewing admin
    /// cluster controller logs.
    /// </summary>
    public TerraformExpression LocalName => this["local_name"];

    /// <summary>
    /// If set, there are currently changes in flight to the VMware admin cluster.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The lifecycle state of the VMware admin cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// ResourceStatus representing detailed cluster state.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The unique identifier of the VMware Admin Cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
