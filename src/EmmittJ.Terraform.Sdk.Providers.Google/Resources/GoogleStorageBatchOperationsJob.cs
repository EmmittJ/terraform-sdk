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
    public TerraformLiteralProperty<bool>? DeleteProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_protection");
        set => this.WithProperty("delete_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the job.
    /// </summary>
    public TerraformLiteralProperty<string>? JobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_id");
        set => this.WithProperty("job_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
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
