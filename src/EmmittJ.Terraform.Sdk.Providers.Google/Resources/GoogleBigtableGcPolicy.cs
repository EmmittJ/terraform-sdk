using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for max_age in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableGcPolicyMaxAgeBlock : TerraformBlock
{
    /// <summary>
    /// Number of days before applying GC policy.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<double>? Days
    {
        get => GetProperty<TerraformProperty<double>>("days");
        set => WithProperty("days", value);
    }

    /// <summary>
    /// Duration before applying GC policy
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => WithProperty("duration", value);
    }

}

/// <summary>
/// Block type for max_version in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableGcPolicyMaxVersionBlock : TerraformBlock
{
    /// <summary>
    /// Number of version before applying the GC policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Number is required")]
    public required TerraformProperty<double> Number
    {
        get => GetProperty<TerraformProperty<double>>("number");
        set => WithProperty("number", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableGcPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_bigtable_gc_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableGcPolicy : TerraformResource
{
    public GoogleBigtableGcPolicy(string name) : base("google_bigtable_gc_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnFamily is required")]
    public required TerraformProperty<string> ColumnFamily
    {
        get => GetProperty<TerraformProperty<string>>("column_family");
        set => this.WithProperty("column_family", value);
    }

    /// <summary>
    /// The deletion policy for the GC policy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted
    /// 				in a replicated instance. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// Serialized JSON string for garbage collection policy. Conflicts with &amp;quot;mode&amp;quot;, &amp;quot;max_age&amp;quot; and &amp;quot;max_version&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? GcRules
    {
        get => GetProperty<TerraformProperty<string>>("gc_rules");
        set => this.WithProperty("gc_rules", value);
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
    /// Allows ignoring warnings when updating the GC policy. This can be used
    /// 				to increase the gc policy on replicated clusters. Doing this may make clusters be
    /// 				inconsistent for a longer period of time, before using this make sure you understand
    /// 				the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing
    /// </summary>
    public TerraformProperty<bool>? IgnoreWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_warnings");
        set => this.WithProperty("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetProperty<TerraformProperty<string>>("instance_name");
        set => this.WithProperty("instance_name", value);
    }

    /// <summary>
    /// NOTE: &#39;gc_rules&#39; is more flexible, and should be preferred over this field for new resources. This field may be deprecated in the future. If multiple policies are set, you should choose between UNION OR INTERSECTION.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<string> Table
    {
        get => GetProperty<TerraformProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// Block for max_age.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxAge block(s) allowed")]
    public List<GoogleBigtableGcPolicyMaxAgeBlock>? MaxAge
    {
        get => GetProperty<List<GoogleBigtableGcPolicyMaxAgeBlock>>("max_age");
        set => this.WithProperty("max_age", value);
    }

    /// <summary>
    /// Block for max_version.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigtableGcPolicyMaxVersionBlock>? MaxVersion
    {
        get => GetProperty<List<GoogleBigtableGcPolicyMaxVersionBlock>>("max_version");
        set => this.WithProperty("max_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableGcPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigtableGcPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
