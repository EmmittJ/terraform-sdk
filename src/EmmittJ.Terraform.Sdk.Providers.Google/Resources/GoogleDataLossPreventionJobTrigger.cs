using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_loss_prevention_job_trigger resource.
/// </summary>
public class GoogleDataLossPreventionJobTrigger : TerraformResource
{
    public GoogleDataLossPreventionJobTrigger(string name) : base("google_data_loss_prevention_job_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("last_run_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A description of the job trigger.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User set display name of the job trigger.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent of the trigger, either in the format &#39;projects/{{project}}&#39;
    /// or &#39;projects/{{project}}/locations/{{location}}&#39;
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the trigger is currently active. Default value: &amp;quot;HEALTHY&amp;quot; Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;HEALTHY&amp;quot;, &amp;quot;CANCELLED&amp;quot;]
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public string? TriggerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trigger_id")?.Value;
        set => this.WithProperty("trigger_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
