using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_job resource.
/// </summary>
public class GoogleBigqueryJob : TerraformResource
{
    public GoogleBigqueryJob(string name) : base("google_bigquery_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("job_type");
        this.DeclareOutput("status");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("user_email");
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
    /// The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.
    /// </summary>
    public string? JobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_id")?.Value;
        set => this.WithProperty("job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.
    /// </summary>
    public string? JobTimeoutMs
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_timeout_ms")?.Value;
        set => this.WithProperty("job_timeout_ms", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The labels associated with this job. You can use these to organize and group your jobs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The geographic location of the job. The default value is US.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The type of the job.
    /// </summary>
    public TerraformExpression JobType => this["job_type"];

    /// <summary>
    /// The status of this job. Examine this value when polling an asynchronous job to see if the job is complete.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Email address of the user who ran the job.
    /// </summary>
    public TerraformExpression UserEmail => this["user_email"];

}
