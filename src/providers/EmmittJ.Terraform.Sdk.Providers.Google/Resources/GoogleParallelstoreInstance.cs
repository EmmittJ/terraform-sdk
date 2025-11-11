using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleParallelstoreInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_parallelstore_instance resource.
/// </summary>
public partial class GoogleParallelstoreInstance : TerraformResource
{
    public GoogleParallelstoreInstance(string name) : base("google_parallelstore_instance", name)
    {
    }

    /// <summary>
    /// Required. Immutable. Storage capacity of Parallelstore instance in Gibibytes (GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    [TerraformProperty("capacity_gib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityGib { get; set; }

    /// <summary>
    /// Parallelstore Instance deployment type.
    ///   Possible values:
    ///   DEPLOYMENT_TYPE_UNSPECIFIED
    ///   SCRATCH
    ///   PERSISTENT
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentType { get; set; }

    /// <summary>
    /// The description of the instance. 2048 characters or less.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    [TerraformProperty("directory_stripe_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectoryStripeLevel { get; set; }

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
    [TerraformProperty("file_stripe_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileStripeLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The logical name of the Parallelstore instance in the user project with the following restrictions:
    ///   * Must contain only lowercase letters, numbers, and hyphens.
    ///   * Must start with a letter.
    ///   * Must be between 1-63 characters.
    ///   * Must end with a number or a letter.
    ///   * Must be unique within the customer project/ location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceId { get; set; }

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
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Immutable. The name of the Google Compute Engine [VPC network](https://cloud.google.com/vpc/docs/vpc)
    /// to which the instance is connected.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address range
    /// associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. If no range id is provided all ranges will
    /// be considered.
    /// </summary>
    [TerraformProperty("reserved_ip_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReservedIpRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleParallelstoreInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. List of access_points.
    /// Contains a list of IPv4 addresses used for client side configuration.
    /// </summary>
    [TerraformProperty("access_points")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AccessPoints { get; }

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The version of DAOS software running in the instance.
    /// </summary>
    [TerraformProperty("daos_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DaosVersion { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address
    /// range associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. This field is populated by the service
    /// and contains the value currently used by the service.
    /// </summary>
    [TerraformProperty("effective_reserved_ip_range")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveReservedIpRange { get; }

    /// <summary>
    /// Identifier. The resource name of the instance, in the format
    /// &#39;projects/{project}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

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
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
