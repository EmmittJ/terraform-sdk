using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for process_interval in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleRetrohuntProcessIntervalBlock : TerraformBlock
{
    /// <summary>
    /// Exclusive end of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    public required TerraformProperty<string> EndTime
    {
        set => SetProperty("end_time", value);
    }

    /// <summary>
    /// Inclusive start of the interval.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformProperty<string> StartTime
    {
        set => SetProperty("start_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRetrohuntTimeoutsBlock : TerraformBlock
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
/// Manages a google_chronicle_retrohunt resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleChronicleRetrohunt : TerraformResource
{
    public GoogleChronicleRetrohunt(string name) : base("google_chronicle_retrohunt", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("execution_interval");
        SetOutput("name");
        SetOutput("progress_percentage");
        SetOutput("state");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("location");
        SetOutput("project");
        SetOutput("retrohunt");
        SetOutput("rule");
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The retrohunt ID of the Retrohunt. A retrohunt is an execution of a Rule over a time range in the past.
    /// </summary>
    public TerraformProperty<string> Retrohunt
    {
        get => GetRequiredOutput<TerraformProperty<string>>("retrohunt");
        set => SetProperty("retrohunt", value);
    }

    /// <summary>
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformProperty<string> Rule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule");
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// Block for process_interval.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProcessInterval is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProcessInterval block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessInterval block(s) allowed")]
    public List<GoogleChronicleRetrohuntProcessIntervalBlock>? ProcessInterval
    {
        set => SetProperty("process_interval", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleRetrohuntTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a
    /// Timestamp end (exclusive).
    /// 
    /// The start must be less than or equal to the end.
    /// When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public TerraformExpression ExecutionInterval => this["execution_interval"];

    /// <summary>
    /// The resource name of the retrohunt.
    /// Retrohunt is the child of a rule revision. {rule} in the format below is
    /// structured as {rule_id@revision_id}.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Percent progress of the retrohunt towards completion, from 0.00 to 100.00.
    /// </summary>
    public TerraformExpression ProgressPercentage => this["progress_percentage"];

    /// <summary>
    /// Output only. The state of the retrohunt.
    /// Possible values:
    /// RUNNING
    /// DONE
    /// CANCELLED
    /// FAILED
    /// </summary>
    public TerraformExpression State => this["state"];

}
