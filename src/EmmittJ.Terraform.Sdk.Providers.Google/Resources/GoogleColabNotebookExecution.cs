using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_colab_notebook_execution resource.
/// </summary>
public class GoogleColabNotebookExecution : TerraformResource
{
    public GoogleColabNotebookExecution(string name) : base("google_colab_notebook_execution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Required. The display name of the Notebook Execution.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs).
    /// </summary>
    public string? ExecutionTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_timeout")?.Value;
        set => this.WithProperty("execution_timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    public string? ExecutionUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_user")?.Value;
        set => this.WithProperty("execution_user", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    public string? GcsOutputUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gcs_output_uri")?.Value;
        set => this.WithProperty("gcs_output_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User specified ID for the Notebook Execution Job
    /// </summary>
    public string? NotebookExecutionJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notebook_execution_job_id")?.Value;
        set => this.WithProperty("notebook_execution_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    public string? NotebookRuntimeTemplateResourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notebook_runtime_template_resource_name")?.Value;
        set => this.WithProperty("notebook_runtime_template_resource_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service account to run the execution as.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
