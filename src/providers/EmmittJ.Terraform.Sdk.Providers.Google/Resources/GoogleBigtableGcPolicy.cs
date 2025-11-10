using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for max_age in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableGcPolicyMaxAgeBlock : ITerraformBlock
{
    /// <summary>
    /// Number of days before applying GC policy.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Days { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "days");

    /// <summary>
    /// Duration before applying GC policy
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Duration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "duration");

}

/// <summary>
/// Block type for max_version in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableGcPolicyMaxVersionBlock : ITerraformBlock
{
    /// <summary>
    /// Number of version before applying the GC policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Number is required")]
    [TerraformPropertyName("number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Number { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableGcPolicyTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_bigtable_gc_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableGcPolicy : TerraformResource
{
    public GoogleBigtableGcPolicy(string name) : base("google_bigtable_gc_policy", name)
    {
    }

    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnFamily is required")]
    [TerraformPropertyName("column_family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ColumnFamily { get; set; }

    /// <summary>
    /// The deletion policy for the GC policy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted
    /// 				in a replicated instance. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// Serialized JSON string for garbage collection policy. Conflicts with &amp;quot;mode&amp;quot;, &amp;quot;max_age&amp;quot; and &amp;quot;max_version&amp;quot;.
    /// </summary>
    [TerraformPropertyName("gc_rules")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GcRules { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Allows ignoring warnings when updating the GC policy. This can be used
    /// 				to increase the gc policy on replicated clusters. Doing this may make clusters be
    /// 				inconsistent for a longer period of time, before using this make sure you understand
    /// 				the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing
    /// </summary>
    [TerraformPropertyName("ignore_warnings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreWarnings { get; set; }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformPropertyName("instance_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceName { get; set; }

    /// <summary>
    /// NOTE: &#39;gc_rules&#39; is more flexible, and should be preferred over this field for new resources. This field may be deprecated in the future. If multiple policies are set, you should choose between UNION OR INTERSECTION.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformPropertyName("table")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Table { get; set; }

    /// <summary>
    /// Block for max_age.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxAge block(s) allowed")]
    [TerraformPropertyName("max_age")]
    public TerraformList<TerraformBlock<GoogleBigtableGcPolicyMaxAgeBlock>>? MaxAge { get; set; } = new();

    /// <summary>
    /// Block for max_version.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("max_version")]
    public TerraformList<TerraformBlock<GoogleBigtableGcPolicyMaxVersionBlock>>? MaxVersion { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigtableGcPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

}
