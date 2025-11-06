using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_scheduler_job resource.
/// </summary>
public class GoogleCloudSchedulerJob : TerraformResource
{
    public GoogleCloudSchedulerJob(string name) : base("google_cloud_scheduler_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The deadline for job attempts. If the request handler does not respond by this deadline then the request is
    /// cancelled and the attempt is marked as a DEADLINE_EXCEEDED failure. The failed attempt can be viewed in
    /// execution logs. Cloud Scheduler will retry the job according to the RetryConfig.
    /// The allowed duration for this deadline is:
    /// * For HTTP targets, between 15 seconds and 30 minutes.
    /// * For App Engine HTTP targets, between 15 seconds and 24 hours.
    /// * **Note**: For PubSub targets, this field is ignored - setting it will introduce an unresolvable diff.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    public string? AttemptDeadline
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attempt_deadline")?.Value;
        set => this.WithProperty("attempt_deadline", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name of the job.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Sets the job to a paused state. Jobs default to being enabled when this property is not set.
    /// </summary>
    public bool? Paused
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("paused")?.Value;
        set => this.WithProperty("paused", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where the scheduler job resides. If it is not provided, Terraform will use the provider default.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Describes the schedule on which the job will be executed.
    /// </summary>
    public string? Schedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule")?.Value;
        set => this.WithProperty("schedule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// State of the job.
    /// </summary>
    public TerraformExpression State => this["state"];

}
