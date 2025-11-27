using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for max_age in GoogleBigtableGcPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableGcPolicyMaxAgeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_age";

    /// <summary>
    /// Number of days before applying GC policy.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<double> Days
    {
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// Duration before applying GC policy
    /// </summary>
    public TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

}


/// <summary>
/// Block type for max_version in GoogleBigtableGcPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableGcPolicyMaxVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_version";

    /// <summary>
    /// Number of version before applying the GC policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Number is required")]
    public required TerraformValue<double> Number
    {
        get => new TerraformReference<double>(this, "number");
        set => SetArgument("number", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigtableGcPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableGcPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_bigtable_gc_policy Terraform resource.
/// Manages a google_bigtable_gc_policy resource.
/// </summary>
public partial class GoogleBigtableGcPolicy(string name) : TerraformResource("google_bigtable_gc_policy", name)
{
    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnFamily is required")]
    public required TerraformValue<string> ColumnFamily
    {
        get => new TerraformReference<string>(this, "column_family");
        set => SetArgument("column_family", value);
    }

    /// <summary>
    /// The deletion policy for the GC policy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. This is useful for GC policy as it cannot be deleted
    /// 				in a replicated instance. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// Serialized JSON string for garbage collection policy. Conflicts with &amp;quot;mode&amp;quot;, &amp;quot;max_age&amp;quot; and &amp;quot;max_version&amp;quot;.
    /// </summary>
    public TerraformValue<string>? GcRules
    {
        get => new TerraformReference<string>(this, "gc_rules");
        set => SetArgument("gc_rules", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Allows ignoring warnings when updating the GC policy. This can be used
    /// 				to increase the gc policy on replicated clusters. Doing this may make clusters be
    /// 				inconsistent for a longer period of time, before using this make sure you understand
    /// 				the risks listed at https://cloud.google.com/bigtable/docs/garbage-collection#increasing
    /// </summary>
    public TerraformValue<bool>? IgnoreWarnings
    {
        get => new TerraformReference<bool>(this, "ignore_warnings");
        set => SetArgument("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => new TerraformReference<string>(this, "instance_name");
        set => SetArgument("instance_name", value);
    }

    /// <summary>
    /// NOTE: &#39;gc_rules&#39; is more flexible, and should be preferred over this field for new resources. This field may be deprecated in the future. If multiple policies are set, you should choose between UNION OR INTERSECTION.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => new TerraformReference<string>(this, "table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// MaxAge block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxAge block(s) allowed")]
    public TerraformList<GoogleBigtableGcPolicyMaxAgeBlock>? MaxAge
    {
        get => GetArgument<TerraformList<GoogleBigtableGcPolicyMaxAgeBlock>>("max_age");
        set => SetArgument("max_age", value);
    }

    /// <summary>
    /// MaxVersion block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigtableGcPolicyMaxVersionBlock>? MaxVersion
    {
        get => GetArgument<TerraformList<GoogleBigtableGcPolicyMaxVersionBlock>>("max_version");
        set => SetArgument("max_version", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableGcPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableGcPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
