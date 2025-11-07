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
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs).
    /// </summary>
    public TerraformLiteralProperty<string>? ExecutionTimeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_timeout");
        set => this.WithProperty("execution_timeout", value);
    }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    public TerraformLiteralProperty<string>? ExecutionUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_user");
        set => this.WithProperty("execution_user", value);
    }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    public TerraformLiteralProperty<string>? GcsOutputUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gcs_output_uri");
        set => this.WithProperty("gcs_output_uri", value);
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// User specified ID for the Notebook Execution Job
    /// </summary>
    public TerraformLiteralProperty<string>? NotebookExecutionJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notebook_execution_job_id");
        set => this.WithProperty("notebook_execution_job_id", value);
    }

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    public TerraformLiteralProperty<string>? NotebookRuntimeTemplateResourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notebook_runtime_template_resource_name");
        set => this.WithProperty("notebook_runtime_template_resource_name", value);
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
    /// The service account to run the execution as.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

}
