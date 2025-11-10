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
        set => SetProperty("days", value);
    }

    /// <summary>
    /// Duration before applying GC policy
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        set => SetProperty("duration", value);
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
        set => SetProperty("number", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("column_family");
        SetOutput("deletion_policy");
        SetOutput("gc_rules");
        SetOutput("id");
        SetOutput("ignore_warnings");
        SetOutput("instance_name");
        SetOutput("mode");
        SetOutput("project");
        SetOutput("table");
    }

    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnFamily is required")]
    public required TerraformProperty<string> ColumnFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("column_family");
        set => SetProperty("column_family", value);
    }

    /// <summary>
    /// The deletion policy for the GC policy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted
    /// 				in a replicated instance. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// Serialized JSON string for garbage collection policy. Conflicts with &amp;quot;mode&amp;quot;, &amp;quot;max_age&amp;quot; and &amp;quot;max_version&amp;quot;.
    /// </summary>
    public TerraformProperty<string> GcRules
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gc_rules");
        set => SetProperty("gc_rules", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Allows ignoring warnings when updating the GC policy. This can be used
    /// 				to increase the gc policy on replicated clusters. Doing this may make clusters be
    /// 				inconsistent for a longer period of time, before using this make sure you understand
    /// 				the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing
    /// </summary>
    public TerraformProperty<bool> IgnoreWarnings
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_warnings");
        set => SetProperty("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_name");
        set => SetProperty("instance_name", value);
    }

    /// <summary>
    /// NOTE: &#39;gc_rules&#39; is more flexible, and should be preferred over this field for new resources. This field may be deprecated in the future. If multiple policies are set, you should choose between UNION OR INTERSECTION.
    /// </summary>
    public TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<string> Table
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table");
        set => SetProperty("table", value);
    }

    /// <summary>
    /// Block for max_age.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxAge block(s) allowed")]
    public List<GoogleBigtableGcPolicyMaxAgeBlock>? MaxAge
    {
        set => SetProperty("max_age", value);
    }

    /// <summary>
    /// Block for max_version.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigtableGcPolicyMaxVersionBlock>? MaxVersion
    {
        set => SetProperty("max_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableGcPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
