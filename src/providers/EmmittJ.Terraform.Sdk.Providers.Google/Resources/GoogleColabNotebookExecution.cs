using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dataform_repository_source in .
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionDataformRepositorySourceBlock
{
    /// <summary>
    /// The commit SHA to read repository with. If unset, the file will be read at HEAD.
    /// </summary>
    [TerraformPropertyName("commit_sha")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CommitSha { get; set; }

    /// <summary>
    /// The resource name of the Dataform Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataformRepositoryResourceName is required")]
    [TerraformPropertyName("dataform_repository_resource_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataformRepositoryResourceName { get; set; }

}

/// <summary>
/// Block type for direct_notebook_source in .
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionDirectNotebookSourceBlock
{
    /// <summary>
    /// The base64-encoded contents of the input notebook file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Content { get; set; }

}

/// <summary>
/// Block type for gcs_notebook_source in .
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionGcsNotebookSourceBlock
{
    /// <summary>
    /// The version of the Cloud Storage object to read. If unset, the current version of the object is read. See https://cloud.google.com/storage/docs/metadata#generation-number.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Generation { get; set; }

    /// <summary>
    /// The Cloud Storage uri pointing to the ipynb file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabNotebookExecutionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_colab_notebook_execution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleColabNotebookExecution : TerraformResource
{
    public GoogleColabNotebookExecution(string name) : base("google_colab_notebook_execution", name)
    {
    }

    /// <summary>
    /// Required. The display name of the Notebook Execution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs).
    /// </summary>
    [TerraformPropertyName("execution_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionTimeout { get; set; }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    [TerraformPropertyName("execution_user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionUser { get; set; }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcsOutputUri is required")]
    [TerraformPropertyName("gcs_output_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GcsOutputUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// User specified ID for the Notebook Execution Job
    /// </summary>
    [TerraformPropertyName("notebook_execution_job_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NotebookExecutionJobId { get; set; } = default!;

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    [TerraformPropertyName("notebook_runtime_template_resource_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotebookRuntimeTemplateResourceName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The service account to run the execution as.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Block for dataform_repository_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataformRepositorySource block(s) allowed")]
    [TerraformPropertyName("dataform_repository_source")]
    public TerraformList<TerraformBlock<GoogleColabNotebookExecutionDataformRepositorySourceBlock>>? DataformRepositorySource { get; set; }

    /// <summary>
    /// Block for direct_notebook_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectNotebookSource block(s) allowed")]
    [TerraformPropertyName("direct_notebook_source")]
    public TerraformList<TerraformBlock<GoogleColabNotebookExecutionDirectNotebookSourceBlock>>? DirectNotebookSource { get; set; }

    /// <summary>
    /// Block for gcs_notebook_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsNotebookSource block(s) allowed")]
    [TerraformPropertyName("gcs_notebook_source")]
    public TerraformList<TerraformBlock<GoogleColabNotebookExecutionGcsNotebookSourceBlock>>? GcsNotebookSource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleColabNotebookExecutionTimeoutsBlock>? Timeouts { get; set; }

}
