using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetPoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_target_pool resource.
/// </summary>
public class GoogleComputeTargetPool : TerraformResource
{
    public GoogleComputeTargetPool(string name) : base("google_compute_target_pool", name)
    {
    }

    /// <summary>
    /// URL to the backup target pool. Must also set failover_ratio.
    /// </summary>
    [TerraformPropertyName("backup_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackupPool { get; set; }

    /// <summary>
    /// Textual description field.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Ratio (0 to 1) of failed nodes before using the backup pool (which must also be set).
    /// </summary>
    [TerraformPropertyName("failover_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailoverRatio { get; set; }

    /// <summary>
    /// List of zero or one health check name or self_link. Only legacy google_compute_http_health_check is supported.
    /// </summary>
    [TerraformPropertyName("health_checks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? HealthChecks { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// List of instances in the pool. They can be given as URLs, or in the form of &amp;quot;zone/name&amp;quot;. Note that the instances need not exist at the time of target pool creation, so there is no need to use the Terraform interpolators to create a dependency on the instances from the target pool.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Instances { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "instances");

    /// <summary>
    /// A unique name for the resource, required by GCE. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Where the target pool resides. Defaults to project region.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// How to distribute load. Options are &amp;quot;NONE&amp;quot; (no affinity). &amp;quot;CLIENT_IP&amp;quot; (hash of the source/dest addresses / ports), and &amp;quot;CLIENT_IP_PROTO&amp;quot; also includes the protocol (default &amp;quot;NONE&amp;quot;).
    /// </summary>
    [TerraformPropertyName("session_affinity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SessionAffinity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeTargetPoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
