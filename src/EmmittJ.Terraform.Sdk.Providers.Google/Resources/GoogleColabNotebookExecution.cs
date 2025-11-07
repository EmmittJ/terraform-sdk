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
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs).
    /// </summary>
    public TerraformProperty<string>? ExecutionTimeout
    {
        get => GetProperty<TerraformProperty<string>>("execution_timeout");
        set => this.WithProperty("execution_timeout", value);
    }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    public TerraformProperty<string>? ExecutionUser
    {
        get => GetProperty<TerraformProperty<string>>("execution_user");
        set => this.WithProperty("execution_user", value);
    }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    public TerraformProperty<string>? GcsOutputUri
    {
        get => GetProperty<TerraformProperty<string>>("gcs_output_uri");
        set => this.WithProperty("gcs_output_uri", value);
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
    /// User specified ID for the Notebook Execution Job
    /// </summary>
    public TerraformProperty<string>? NotebookExecutionJobId
    {
        get => GetProperty<TerraformProperty<string>>("notebook_execution_job_id");
        set => this.WithProperty("notebook_execution_job_id", value);
    }

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    public TerraformProperty<string>? NotebookRuntimeTemplateResourceName
    {
        get => GetProperty<TerraformProperty<string>>("notebook_runtime_template_resource_name");
        set => this.WithProperty("notebook_runtime_template_resource_name", value);
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
    /// The service account to run the execution as.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

}
