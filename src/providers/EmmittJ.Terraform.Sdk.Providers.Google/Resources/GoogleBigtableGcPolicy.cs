using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for max_age in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableGcPolicyMaxAgeBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of days before applying GC policy.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("days")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Days { get; set; }

    /// <summary>
    /// Duration before applying GC policy
    /// </summary>
    [TerraformProperty("duration")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Duration { get; set; }

}

/// <summary>
/// Block type for max_version in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableGcPolicyMaxVersionBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of version before applying the GC policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Number is required")]
    [TerraformProperty("number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Number { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigtableGcPolicyTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_bigtable_gc_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigtableGcPolicy : TerraformResource
{
    public GoogleBigtableGcPolicy(string name) : base("google_bigtable_gc_policy", name)
    {
    }

    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnFamily is required")]
    [TerraformProperty("column_family")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ColumnFamily { get; set; }

    /// <summary>
    /// The deletion policy for the GC policy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted
    /// 				in a replicated instance. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// Serialized JSON string for garbage collection policy. Conflicts with &amp;quot;mode&amp;quot;, &amp;quot;max_age&amp;quot; and &amp;quot;max_version&amp;quot;.
    /// </summary>
    [TerraformProperty("gc_rules")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GcRules { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Allows ignoring warnings when updating the GC policy. This can be used
    /// 				to increase the gc policy on replicated clusters. Doing this may make clusters be
    /// 				inconsistent for a longer period of time, before using this make sure you understand
    /// 				the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing
    /// </summary>
    [TerraformProperty("ignore_warnings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreWarnings { get; set; }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformProperty("instance_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceName { get; set; }

    /// <summary>
    /// NOTE: &#39;gc_rules&#39; is more flexible, and should be preferred over this field for new resources. This field may be deprecated in the future. If multiple policies are set, you should choose between UNION OR INTERSECTION.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformProperty("table")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Table { get; set; }

    /// <summary>
    /// Block for max_age.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxAge block(s) allowed")]
    [TerraformProperty("max_age")]
    public TerraformList<TerraformBlock<GoogleBigtableGcPolicyMaxAgeBlock>>? MaxAge { get; set; }

    /// <summary>
    /// Block for max_version.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("max_version")]
    public TerraformList<TerraformBlock<GoogleBigtableGcPolicyMaxVersionBlock>>? MaxVersion { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBigtableGcPolicyTimeoutsBlock>? Timeouts { get; set; }

}
