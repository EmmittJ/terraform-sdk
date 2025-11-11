using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dataform_repository_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabNotebookExecutionDataformRepositorySourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The commit SHA to read repository with. If unset, the file will be read at HEAD.
    /// </summary>
    [TerraformProperty("commit_sha")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CommitSha { get; set; }

    /// <summary>
    /// The resource name of the Dataform Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataformRepositoryResourceName is required")]
    [TerraformProperty("dataform_repository_resource_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataformRepositoryResourceName { get; set; }

}

/// <summary>
/// Block type for direct_notebook_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabNotebookExecutionDirectNotebookSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The base64-encoded contents of the input notebook file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

}

/// <summary>
/// Block type for gcs_notebook_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabNotebookExecutionGcsNotebookSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The version of the Cloud Storage object to read. If unset, the current version of the object is read. See https://cloud.google.com/storage/docs/metadata#generation-number.
    /// </summary>
    [TerraformProperty("generation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Generation { get; set; }

    /// <summary>
    /// The Cloud Storage uri pointing to the ipynb file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleColabNotebookExecutionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_colab_notebook_execution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleColabNotebookExecution : TerraformResource
{
    public GoogleColabNotebookExecution(string name) : base("google_colab_notebook_execution", name)
    {
    }

    /// <summary>
    /// Required. The display name of the Notebook Execution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs).
    /// </summary>
    [TerraformProperty("execution_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionTimeout { get; set; }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    [TerraformProperty("execution_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionUser { get; set; }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcsOutputUri is required")]
    [TerraformProperty("gcs_output_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GcsOutputUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// User specified ID for the Notebook Execution Job
    /// </summary>
    [TerraformProperty("notebook_execution_job_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NotebookExecutionJobId { get; set; }

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    [TerraformProperty("notebook_runtime_template_resource_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NotebookRuntimeTemplateResourceName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The service account to run the execution as.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for dataform_repository_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataformRepositorySource block(s) allowed")]
    [TerraformProperty("dataform_repository_source")]
    public partial TerraformList<TerraformBlock<GoogleColabNotebookExecutionDataformRepositorySourceBlock>>? DataformRepositorySource { get; set; }

    /// <summary>
    /// Block for direct_notebook_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectNotebookSource block(s) allowed")]
    [TerraformProperty("direct_notebook_source")]
    public partial TerraformList<TerraformBlock<GoogleColabNotebookExecutionDirectNotebookSourceBlock>>? DirectNotebookSource { get; set; }

    /// <summary>
    /// Block for gcs_notebook_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsNotebookSource block(s) allowed")]
    [TerraformProperty("gcs_notebook_source")]
    public partial TerraformList<TerraformBlock<GoogleColabNotebookExecutionGcsNotebookSourceBlock>>? GcsNotebookSource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleColabNotebookExecutionTimeoutsBlock>? Timeouts { get; set; }

}
