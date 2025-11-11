using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeTargetPoolTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_target_pool resource.
/// </summary>
public partial class GoogleComputeTargetPool : TerraformResource
{
    public GoogleComputeTargetPool(string name) : base("google_compute_target_pool", name)
    {
    }

    /// <summary>
    /// URL to the backup target pool. Must also set failover_ratio.
    /// </summary>
    [TerraformProperty("backup_pool")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BackupPool { get; set; }

    /// <summary>
    /// Textual description field.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Ratio (0 to 1) of failed nodes before using the backup pool (which must also be set).
    /// </summary>
    [TerraformProperty("failover_ratio")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FailoverRatio { get; set; }

    /// <summary>
    /// List of zero or one health check name or self_link. Only legacy google_compute_http_health_check is supported.
    /// </summary>
    [TerraformProperty("health_checks")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? HealthChecks { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// List of instances in the pool. They can be given as URLs, or in the form of &amp;quot;zone/name&amp;quot;. Note that the instances need not exist at the time of target pool creation, so there is no need to use the Terraform interpolators to create a dependency on the instances from the target pool.
    /// </summary>
    [TerraformProperty("instances")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> Instances { get; set; }

    /// <summary>
    /// A unique name for the resource, required by GCE. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Where the target pool resides. Defaults to project region.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// How to distribute load. Options are &amp;quot;NONE&amp;quot; (no affinity). &amp;quot;CLIENT_IP&amp;quot; (hash of the source/dest addresses / ports), and &amp;quot;CLIENT_IP_PROTO&amp;quot; also includes the protocol (default &amp;quot;NONE&amp;quot;).
    /// </summary>
    [TerraformProperty("session_affinity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SessionAffinity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeTargetPoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
