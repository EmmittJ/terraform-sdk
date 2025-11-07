using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_colab_schedule resource.
/// </summary>
public class GoogleColabSchedule : TerraformResource
{
    public GoogleColabSchedule(string name) : base("google_colab_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Whether new scheduled runs can be queued when max_concurrent_runs limit is reached. If set to true, new runs will be queued instead of skipped. Default to false.
    /// </summary>
    public TerraformProperty<bool>? AllowQueueing
    {
        get => GetProperty<TerraformProperty<bool>>("allow_queueing");
        set => this.WithProperty("allow_queueing", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// </summary>
    public TerraformProperty<string>? Cron
    {
        get => GetProperty<TerraformProperty<string>>("cron");
        set => this.WithProperty("cron", value);
    }

    /// <summary>
    /// Desired state of the Colab Schedule. Set this field to &#39;ACTIVE&#39; to start/resume the schedule, and &#39;PAUSED&#39; to pause the schedule.
    /// </summary>
    public TerraformProperty<string>? DesiredState
    {
        get => GetProperty<TerraformProperty<string>>("desired_state");
        set => this.WithProperty("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Schedule.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Timestamp after which no new runs can be scheduled. If specified, the schedule will be completed when either end_time is reached or when scheduled_run_count &amp;gt;= max_run_count. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => this.WithProperty("end_time", value);
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Maximum number of runs that can be started concurrently for this Schedule. This is the limit for starting the scheduled requests and not the execution of the notebook execution jobs created by the requests.
    /// </summary>
    public TerraformProperty<string>? MaxConcurrentRunCount
    {
        get => GetProperty<TerraformProperty<string>>("max_concurrent_run_count");
        set => this.WithProperty("max_concurrent_run_count", value);
    }

    /// <summary>
    /// Maximum run count of the schedule. If specified, The schedule will be completed when either startedRunCount &amp;gt;= maxRunCount or when endTime is reached. If not specified, new runs will keep getting scheduled until this Schedule is paused or deleted. Already scheduled runs will be allowed to complete. Unset if not specified.
    /// </summary>
    public TerraformProperty<string>? MaxRunCount
    {
        get => GetProperty<TerraformProperty<string>>("max_run_count");
        set => this.WithProperty("max_run_count", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The timestamp after which the first run can be scheduled. Defaults to the schedule creation time. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
    }

    /// <summary>
    /// The resource name of the Schedule
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The state of the schedule.
    /// </summary>
    public TerraformExpression State => this["state"];

}
