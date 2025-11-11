using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for process_interval in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleRetrohuntProcessIntervalBlock : TerraformBlockBase
{
    /// <summary>
    /// Exclusive end of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    [TerraformProperty("end_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndTime { get; set; }

    /// <summary>
    /// Inclusive start of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformProperty("start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleRetrohuntTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_chronicle_retrohunt resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleChronicleRetrohunt : TerraformResource
{
    public GoogleChronicleRetrohunt(string name) : base("google_chronicle_retrohunt", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The retrohunt ID of the Retrohunt. A retrohunt is an execution of a Rule over a time range in the past.
    /// </summary>
    [TerraformProperty("retrohunt")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Retrohunt { get; set; }

    /// <summary>
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformProperty("rule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Rule { get; set; }

    /// <summary>
    /// Block for process_interval.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProcessInterval is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProcessInterval block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessInterval block(s) allowed")]
    [TerraformProperty("process_interval")]
    public partial TerraformList<TerraformBlock<GoogleChronicleRetrohuntProcessIntervalBlock>>? ProcessInterval { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleChronicleRetrohuntTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a
    /// Timestamp end (exclusive).
    /// 
    /// The start must be less than or equal to the end.
    /// When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    [TerraformProperty("execution_interval")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ExecutionInterval { get; }

    /// <summary>
    /// The resource name of the retrohunt.
    /// Retrohunt is the child of a rule revision. {rule} in the format below is
    /// structured as {rule_id@revision_id}.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Percent progress of the retrohunt towards completion, from 0.00 to 100.00.
    /// </summary>
    [TerraformProperty("progress_percentage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProgressPercentage { get; }

    /// <summary>
    /// Output only. The state of the retrohunt.
    /// Possible values:
    /// RUNNING
    /// DONE
    /// CANCELLED
    /// FAILED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
