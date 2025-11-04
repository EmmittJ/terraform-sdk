using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_batch_operations_job resource.
/// </summary>
public class GoogleStorageBatchOperationsJob : TerraformResource
{
    public GoogleStorageBatchOperationsJob(string name) : base("google_storage_batch_operations_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("complete_time");
        this.DeclareOutput("create_time");
        this.DeclareOutput("schedule_time");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// If set to &#39;true&#39;, the storage batch operation job will not be deleted and new job will be created.
    /// </summary>
    public bool? DeleteProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_protection")?.Value;
        set => this.WithProperty("delete_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The ID of the job.
    /// </summary>
    public string? JobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_id")?.Value;
        set => this.WithProperty("job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The time that the job was completed.
    /// </summary>
    public TerraformExpression CompleteTime => this["complete_time"];

    /// <summary>
    /// The timestamp at which this storage batch operation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time that the job was scheduled.
    /// </summary>
    public TerraformExpression ScheduleTime => this["schedule_time"];

    /// <summary>
    /// State of the job.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The timestamp at which this storage batch operation was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
