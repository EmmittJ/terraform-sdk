using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_parallelstore_instance resource.
/// </summary>
public class GoogleParallelstoreInstance : TerraformResource
{
    public GoogleParallelstoreInstance(string name) : base("google_parallelstore_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_points");
        this.DeclareOutput("create_time");
        this.DeclareOutput("daos_version");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("effective_reserved_ip_range");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Required. Immutable. Storage capacity of Parallelstore instance in Gibibytes (GiB).
    /// </summary>
    public string? CapacityGib
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_gib")?.Value;
        set => this.WithProperty("capacity_gib", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Parallelstore Instance deployment type.
    ///   Possible values:
    ///   DEPLOYMENT_TYPE_UNSPECIFIED
    ///   SCRATCH
    ///   PERSISTENT
    /// </summary>
    public string? DeploymentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_type")?.Value;
        set => this.WithProperty("deployment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the instance. 2048 characters or less.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Stripe level for directories.
    /// MIN when directory has a small number of files.
    /// MAX when directory has a large number of files.
    ///   Possible values:
    ///   DIRECTORY_STRIPE_LEVEL_UNSPECIFIED
    ///   DIRECTORY_STRIPE_LEVEL_MIN
    ///   DIRECTORY_STRIPE_LEVEL_BALANCED
    ///   DIRECTORY_STRIPE_LEVEL_MAX
    /// </summary>
    public string? DirectoryStripeLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_stripe_level")?.Value;
        set => this.WithProperty("directory_stripe_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Stripe level for files.
    /// MIN better suited for small size files.
    /// MAX higher throughput performance for larger files.
    ///   Possible values:
    ///   FILE_STRIPE_LEVEL_UNSPECIFIED
    ///   FILE_STRIPE_LEVEL_MIN
    ///   FILE_STRIPE_LEVEL_BALANCED
    ///   FILE_STRIPE_LEVEL_MAX
    /// </summary>
    public string? FileStripeLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_stripe_level")?.Value;
        set => this.WithProperty("file_stripe_level", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The logical name of the Parallelstore instance in the user project with the following restrictions:
    ///   * Must contain only lowercase letters, numbers, and hyphens.
    ///   * Must start with a letter.
    ///   * Must be between 1-63 characters.
    ///   * Must end with a number or a letter.
    ///   * Must be unique within the customer project/ location
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cloud Labels are a flexible and lightweight mechanism for
    /// organizing cloud resources into groups that reflect a customer&#39;s organizational
    /// needs and deployment strategies. Cloud Labels can be used to filter collections
    /// of resources. They can be used to control how resource metrics are aggregated.
    /// And they can be used as arguments to policy management rules (e.g. route, firewall,
    /// load balancing, etc.).
    /// 
    /// * Label keys must be between 1 and 63 characters long and must conform to
    ///  the following regular expression: &#39;a-z{0,62}&#39;.
    /// * Label values must be between 0 and 63 characters long and must conform
    ///  to the regular expression &#39;[a-z0-9_-]{0,63}&#39;.
    /// * No more than 64 labels can be associated with a given resource.
    /// 
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// 
    /// If you plan to use labels in your own code, please note that additional
    /// characters may be allowed in the future. Therefore, you are advised to use
    /// an internal label representation, such as JSON, which doesn&#39;t rely upon
    /// specific characters being disallowed.  For example, representing labels
    /// as the string:  &#39;name + &amp;quot;_&amp;quot; + value&#39; would prove problematic if we were to
    /// allow &#39;&amp;quot;_&amp;quot;&#39; in a future release. &amp;quot;
    /// 
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
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Immutable. The name of the Google Compute Engine [VPC network](https://cloud.google.com/vpc/docs/vpc)
    /// to which the instance is connected.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Immutable. Contains the id of the allocated IP address range
    /// associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. If no range id is provided all ranges will
    /// be considered.
    /// </summary>
    public string? ReservedIpRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reserved_ip_range")?.Value;
        set => this.WithProperty("reserved_ip_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. List of access_points.
    /// Contains a list of IPv4 addresses used for client side configuration.
    /// </summary>
    public TerraformExpression AccessPoints => this["access_points"];

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The version of DAOS software running in the instance.
    /// </summary>
    public TerraformExpression DaosVersion => this["daos_version"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address
    /// range associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. This field is populated by the service
    /// and contains the value currently used by the service.
    /// </summary>
    public TerraformExpression EffectiveReservedIpRange => this["effective_reserved_ip_range"];

    /// <summary>
    /// Identifier. The resource name of the instance, in the format
    /// &#39;projects/{project}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The instance state.
    ///   Possible values:
    ///   STATE_UNSPECIFIED
    ///   CREATING
    ///   ACTIVE
    ///   DELETING
    ///   FAILED
    ///   UPGRADING
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
