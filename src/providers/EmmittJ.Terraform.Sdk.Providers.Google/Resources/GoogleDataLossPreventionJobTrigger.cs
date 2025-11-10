using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_job in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlock : TerraformBlock
{
    /// <summary>
    /// The name of the template to run when this job is triggered.
    /// </summary>
    public TerraformProperty<string>? InspectTemplateName
    {
        set => SetProperty("inspect_template_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionJobTriggerTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for triggers in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerTriggersBlock : TerraformBlock
{
}

/// <summary>
/// Manages a google_data_loss_prevention_job_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionJobTrigger : TerraformResource
{
    public GoogleDataLossPreventionJobTrigger(string name) : base("google_data_loss_prevention_job_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("last_run_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("parent");
        SetOutput("status");
        SetOutput("trigger_id");
    }

    /// <summary>
    /// A description of the job trigger.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User set display name of the job trigger.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The parent of the trigger, either in the format &#39;projects/{{project}}&#39;
    /// or &#39;projects/{{project}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Whether the trigger is currently active. Default value: &amp;quot;HEALTHY&amp;quot; Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;HEALTHY&amp;quot;, &amp;quot;CANCELLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformProperty<string> TriggerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trigger_id");
        set => SetProperty("trigger_id", value);
    }

    /// <summary>
    /// Block for inspect_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectJob block(s) allowed")]
    public List<GoogleDataLossPreventionJobTriggerInspectJobBlock>? InspectJob
    {
        set => SetProperty("inspect_job", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataLossPreventionJobTriggerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for triggers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Triggers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Triggers block(s) required")]
    public List<GoogleDataLossPreventionJobTriggerTriggersBlock>? Triggers
    {
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// The creation timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The timestamp of the last time this trigger executed.
    /// </summary>
    public TerraformExpression LastRunTime => this["last_run_time"];

    /// <summary>
    /// The resource name of the job trigger. Set by the server.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The last update timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
