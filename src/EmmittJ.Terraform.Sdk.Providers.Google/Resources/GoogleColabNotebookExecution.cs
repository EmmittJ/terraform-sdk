using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dataform_repository_source in .
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionDataformRepositorySourceBlock : TerraformBlock
{
    /// <summary>
    /// The commit SHA to read repository with. If unset, the file will be read at HEAD.
    /// </summary>
    public TerraformProperty<string>? CommitSha
    {
        get => GetProperty<TerraformProperty<string>>("commit_sha");
        set => WithProperty("commit_sha", value);
    }

    /// <summary>
    /// The resource name of the Dataform Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataformRepositoryResourceName is required")]
    public required TerraformProperty<string> DataformRepositoryResourceName
    {
        get => GetProperty<TerraformProperty<string>>("dataform_repository_resource_name");
        set => WithProperty("dataform_repository_resource_name", value);
    }

}

/// <summary>
/// Block type for direct_notebook_source in .
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionDirectNotebookSourceBlock : TerraformBlock
{
    /// <summary>
    /// The base64-encoded contents of the input notebook file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

}

/// <summary>
/// Block type for gcs_notebook_source in .
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionGcsNotebookSourceBlock : TerraformBlock
{
    /// <summary>
    /// The version of the Cloud Storage object to read. If unset, the current version of the object is read. See https://cloud.google.com/storage/docs/metadata#generation-number.
    /// </summary>
    public TerraformProperty<string>? Generation
    {
        get => GetProperty<TerraformProperty<string>>("generation");
        set => WithProperty("generation", value);
    }

    /// <summary>
    /// The Cloud Storage uri pointing to the ipynb file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabNotebookExecutionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_colab_notebook_execution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcsOutputUri is required")]
    public required TerraformProperty<string> GcsOutputUri
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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

    /// <summary>
    /// Block for dataform_repository_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataformRepositorySource block(s) allowed")]
    public List<GoogleColabNotebookExecutionDataformRepositorySourceBlock>? DataformRepositorySource
    {
        get => GetProperty<List<GoogleColabNotebookExecutionDataformRepositorySourceBlock>>("dataform_repository_source");
        set => this.WithProperty("dataform_repository_source", value);
    }

    /// <summary>
    /// Block for direct_notebook_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectNotebookSource block(s) allowed")]
    public List<GoogleColabNotebookExecutionDirectNotebookSourceBlock>? DirectNotebookSource
    {
        get => GetProperty<List<GoogleColabNotebookExecutionDirectNotebookSourceBlock>>("direct_notebook_source");
        set => this.WithProperty("direct_notebook_source", value);
    }

    /// <summary>
    /// Block for gcs_notebook_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsNotebookSource block(s) allowed")]
    public List<GoogleColabNotebookExecutionGcsNotebookSourceBlock>? GcsNotebookSource
    {
        get => GetProperty<List<GoogleColabNotebookExecutionGcsNotebookSourceBlock>>("gcs_notebook_source");
        set => this.WithProperty("gcs_notebook_source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleColabNotebookExecutionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleColabNotebookExecutionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
