using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dataform_repository_source in GoogleColabNotebookExecution.
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionDataformRepositorySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataform_repository_source";

    /// <summary>
    /// The commit SHA to read repository with. If unset, the file will be read at HEAD.
    /// </summary>
    public TerraformValue<string>? CommitSha
    {
        get => new TerraformReference<string>(this, "commit_sha");
        set => SetArgument("commit_sha", value);
    }

    /// <summary>
    /// The resource name of the Dataform Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataformRepositoryResourceName is required")]
    public required TerraformValue<string> DataformRepositoryResourceName
    {
        get => new TerraformReference<string>(this, "dataform_repository_resource_name");
        set => SetArgument("dataform_repository_resource_name", value);
    }

}


/// <summary>
/// Block type for direct_notebook_source in GoogleColabNotebookExecution.
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionDirectNotebookSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "direct_notebook_source";

    /// <summary>
    /// The base64-encoded contents of the input notebook file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

}


/// <summary>
/// Block type for gcs_notebook_source in GoogleColabNotebookExecution.
/// Nesting mode: list
/// </summary>
public class GoogleColabNotebookExecutionGcsNotebookSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_notebook_source";

    /// <summary>
    /// The version of the Cloud Storage object to read. If unset, the current version of the object is read. See https://cloud.google.com/storage/docs/metadata#generation-number.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// The Cloud Storage uri pointing to the ipynb file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleColabNotebookExecution.
/// Nesting mode: single
/// </summary>
public class GoogleColabNotebookExecutionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_colab_notebook_execution Terraform resource.
/// Manages a google_colab_notebook_execution resource.
/// </summary>
public partial class GoogleColabNotebookExecution(string name) : TerraformResource("google_colab_notebook_execution", name)
{
    /// <summary>
    /// Required. The display name of the Notebook Execution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs).
    /// </summary>
    public TerraformValue<string>? ExecutionTimeout
    {
        get => new TerraformReference<string>(this, "execution_timeout");
        set => SetArgument("execution_timeout", value);
    }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    public TerraformValue<string>? ExecutionUser
    {
        get => new TerraformReference<string>(this, "execution_user");
        set => SetArgument("execution_user", value);
    }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcsOutputUri is required")]
    public required TerraformValue<string> GcsOutputUri
    {
        get => new TerraformReference<string>(this, "gcs_output_uri");
        set => SetArgument("gcs_output_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// User specified ID for the Notebook Execution Job
    /// </summary>
    public TerraformValue<string> NotebookExecutionJobId
    {
        get => new TerraformReference<string>(this, "notebook_execution_job_id");
        set => SetArgument("notebook_execution_job_id", value);
    }

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    public TerraformValue<string>? NotebookRuntimeTemplateResourceName
    {
        get => new TerraformReference<string>(this, "notebook_runtime_template_resource_name");
        set => SetArgument("notebook_runtime_template_resource_name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service account to run the execution as.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// DataformRepositorySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataformRepositorySource block(s) allowed")]
    public TerraformList<GoogleColabNotebookExecutionDataformRepositorySourceBlock>? DataformRepositorySource
    {
        get => GetArgument<TerraformList<GoogleColabNotebookExecutionDataformRepositorySourceBlock>>("dataform_repository_source");
        set => SetArgument("dataform_repository_source", value);
    }

    /// <summary>
    /// DirectNotebookSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectNotebookSource block(s) allowed")]
    public TerraformList<GoogleColabNotebookExecutionDirectNotebookSourceBlock>? DirectNotebookSource
    {
        get => GetArgument<TerraformList<GoogleColabNotebookExecutionDirectNotebookSourceBlock>>("direct_notebook_source");
        set => SetArgument("direct_notebook_source", value);
    }

    /// <summary>
    /// GcsNotebookSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsNotebookSource block(s) allowed")]
    public TerraformList<GoogleColabNotebookExecutionGcsNotebookSourceBlock>? GcsNotebookSource
    {
        get => GetArgument<TerraformList<GoogleColabNotebookExecutionGcsNotebookSourceBlock>>("gcs_notebook_source");
        set => SetArgument("gcs_notebook_source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleColabNotebookExecutionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleColabNotebookExecutionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
