using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for node_pool_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock() : TerraformBlock("node_pool_config")
{
    /// <summary>
    /// The map of Kubernetes labels (key/value pairs) to be applied to
    /// each node. These will added in addition to any default label(s)
    /// that Kubernetes may apply to the node. In case of conflict in
    /// label keys, the applied set may differ depending on the Kubernetes
    /// version -- it&#39;s best to assume the behavior is undefined and
    /// conflicts should be avoided. For more information, including usage
    /// and the valid values, see:
    ///   - http://kubernetes.io/v1.1/docs/user-guide/labels.html
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// For example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Labels { get; set; }

    /// <summary>
    /// Specifies the nodes operating system (default: LINUX).
    /// </summary>
    [TerraformProperty("operating_system")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OperatingSystem { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeonpremBareMetalNodePoolTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_gkeonprem_bare_metal_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeonpremBareMetalNodePool : TerraformResource
{
    public GoogleGkeonpremBareMetalNodePool(string name) : base("google_gkeonprem_bare_metal_node_pool", name)
    {
    }

    /// <summary>
    /// Annotations on the Bare Metal Node Pool.
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
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The cluster this node pool belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BareMetalCluster is required")]
    [TerraformProperty("bare_metal_cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BareMetalCluster { get; set; }

    /// <summary>
    /// The display name for the Bare Metal Node Pool.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The bare metal node pool name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for node_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodePoolConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NodePoolConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodePoolConfig block(s) allowed")]
    [TerraformProperty("node_pool_config")]
    public required TerraformList<GoogleGkeonpremBareMetalNodePoolNodePoolConfigBlock> NodePoolConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleGkeonpremBareMetalNodePoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time the cluster was created, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time the cluster was deleted, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// Allows clients to perform consistent read-modify-writes
    /// through optimistic concurrency control.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// If set, there are currently changes in flight to the Bare Metal User Cluster.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The current state of this cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Specifies detailed node pool status.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

    /// <summary>
    /// The unique identifier of the Bare Metal Node Pool.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time the cluster was last updated, in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
