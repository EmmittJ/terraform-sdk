using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for process_interval in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleRetrohuntProcessIntervalBlock : ITerraformBlock
{
    /// <summary>
    /// Exclusive end of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    [TerraformPropertyName("end_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndTime { get; set; }

    /// <summary>
    /// Inclusive start of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformPropertyName("start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRetrohuntTimeoutsBlock : ITerraformBlock
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
/// Manages a google_chronicle_retrohunt resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleChronicleRetrohunt : TerraformResource
{
    public GoogleChronicleRetrohunt(string name) : base("google_chronicle_retrohunt", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The retrohunt ID of the Retrohunt. A retrohunt is an execution of a Rule over a time range in the past.
    /// </summary>
    [TerraformPropertyName("retrohunt")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Retrohunt { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "retrohunt");

    /// <summary>
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformPropertyName("rule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Rule { get; set; }

    /// <summary>
    /// Block for process_interval.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProcessInterval is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProcessInterval block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessInterval block(s) allowed")]
    [TerraformPropertyName("process_interval")]
    public TerraformList<TerraformBlock<GoogleChronicleRetrohuntProcessIntervalBlock>>? ProcessInterval { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleChronicleRetrohuntTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a
    /// Timestamp end (exclusive).
    /// 
    /// The start must be less than or equal to the end.
    /// When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    [TerraformPropertyName("execution_interval")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExecutionInterval => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "execution_interval");

    /// <summary>
    /// The resource name of the retrohunt.
    /// Retrohunt is the child of a rule revision. {rule} in the format below is
    /// structured as {rule_id@revision_id}.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. Percent progress of the retrohunt towards completion, from 0.00 to 100.00.
    /// </summary>
    [TerraformPropertyName("progress_percentage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProgressPercentage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "progress_percentage");

    /// <summary>
    /// Output only. The state of the retrohunt.
    /// Possible values:
    /// RUNNING
    /// DONE
    /// CANCELLED
    /// FAILED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
