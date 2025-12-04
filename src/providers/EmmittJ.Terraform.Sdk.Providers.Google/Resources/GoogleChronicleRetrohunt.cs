using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for process_interval in GoogleChronicleRetrohunt.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleRetrohuntProcessIntervalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "process_interval";

    /// <summary>
    /// Exclusive end of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    public required TerraformValue<string> EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// Inclusive start of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleChronicleRetrohunt.
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRetrohuntTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_chronicle_retrohunt Terraform resource.
/// Manages a google_chronicle_retrohunt resource.
/// </summary>
public partial class GoogleChronicleRetrohunt(string name) : TerraformResource("google_chronicle_retrohunt", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The retrohunt ID of the Retrohunt. A retrohunt is an execution of a Rule over a time range in the past.
    /// </summary>
    public TerraformValue<string>? Retrohunt
    {
        get => GetArgument<TerraformValue<string>>("retrohunt");
        set => SetArgument("retrohunt", value);
    }

    /// <summary>
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => GetArgument<TerraformValue<string>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a
    /// Timestamp end (exclusive).
    /// 
    /// The start must be less than or equal to the end.
    /// When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExecutionInterval
        => AsReference("execution_interval");

    /// <summary>
    /// The resource name of the retrohunt.
    /// Retrohunt is the child of a rule revision. {rule} in the format below is
    /// structured as {rule_id@revision_id}.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. Percent progress of the retrohunt towards completion, from 0.00 to 100.00.
    /// </summary>
    public TerraformValue<double> ProgressPercentage
        => AsReference("progress_percentage");

    /// <summary>
    /// Output only. The state of the retrohunt.
    /// Possible values:
    /// RUNNING
    /// DONE
    /// CANCELLED
    /// FAILED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// ProcessInterval block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProcessInterval is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProcessInterval block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessInterval block(s) allowed")]
    public required TerraformList<GoogleChronicleRetrohuntProcessIntervalBlock> ProcessInterval
    {
        get => GetRequiredArgument<TerraformList<GoogleChronicleRetrohuntProcessIntervalBlock>>("process_interval");
        set => SetArgument("process_interval", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleChronicleRetrohuntTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleChronicleRetrohuntTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
