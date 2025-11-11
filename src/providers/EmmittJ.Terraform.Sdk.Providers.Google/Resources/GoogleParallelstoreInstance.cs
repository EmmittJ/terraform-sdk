using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleParallelstoreInstanceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_parallelstore_instance resource.
/// </summary>
public class GoogleParallelstoreInstance : TerraformResource
{
    public GoogleParallelstoreInstance(string name) : base("google_parallelstore_instance", name)
    {
    }

    /// <summary>
    /// Required. Immutable. Storage capacity of Parallelstore instance in Gibibytes (GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    [TerraformPropertyName("capacity_gib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CapacityGib { get; set; }

    /// <summary>
    /// Parallelstore Instance deployment type.
    ///   Possible values:
    ///   DEPLOYMENT_TYPE_UNSPECIFIED
    ///   SCRATCH
    ///   PERSISTENT
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeploymentType { get; set; }

    /// <summary>
    /// The description of the instance. 2048 characters or less.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

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
    [TerraformPropertyName("directory_stripe_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DirectoryStripeLevel { get; set; }

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
    [TerraformPropertyName("file_stripe_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FileStripeLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The logical name of the Parallelstore instance in the user project with the following restrictions:
    ///   * Must contain only lowercase letters, numbers, and hyphens.
    ///   * Must start with a letter.
    ///   * Must be between 1-63 characters.
    ///   * Must end with a number or a letter.
    ///   * Must be unique within the customer project/ location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceId { get; set; }

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
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The name of the Google Compute Engine [VPC network](https://cloud.google.com/vpc/docs/vpc)
    /// to which the instance is connected.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address range
    /// associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. If no range id is provided all ranges will
    /// be considered.
    /// </summary>
    [TerraformPropertyName("reserved_ip_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReservedIpRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleParallelstoreInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. List of access_points.
    /// Contains a list of IPv4 addresses used for client side configuration.
    /// </summary>
    [TerraformPropertyName("access_points")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AccessPoints => new TerraformReference(this, "access_points");

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The version of DAOS software running in the instance.
    /// </summary>
    [TerraformPropertyName("daos_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DaosVersion => new TerraformReference(this, "daos_version");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address
    /// range associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. This field is populated by the service
    /// and contains the value currently used by the service.
    /// </summary>
    [TerraformPropertyName("effective_reserved_ip_range")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EffectiveReservedIpRange => new TerraformReference(this, "effective_reserved_ip_range");

    /// <summary>
    /// Identifier. The resource name of the instance, in the format
    /// &#39;projects/{project}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
