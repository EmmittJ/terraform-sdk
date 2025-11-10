using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for runtime in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionRuntimeBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformProperty<string> RuntimeVersion
    {
        set => SetProperty("runtime_version", value);
    }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionSyncConfigBlock : TerraformBlock
{
    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictDetection
    {
        set => SetProperty("conflict_detection", value);
    }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictHandler
    {
        set => SetProperty("conflict_handler", value);
    }

}

/// <summary>
/// Manages a aws_appsync_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncFunction : TerraformResource
{
    public AwsAppsyncFunction(string name) : base("aws_appsync_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("function_id");
        SetOutput("api_id");
        SetOutput("code");
        SetOutput("data_source");
        SetOutput("description");
        SetOutput("function_version");
        SetOutput("id");
        SetOutput("max_batch_size");
        SetOutput("name");
        SetOutput("region");
        SetOutput("request_mapping_template");
        SetOutput("response_mapping_template");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformProperty<string> Code
    {
        get => GetRequiredOutput<TerraformProperty<string>>("code");
        set => SetProperty("code", value);
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    public required TerraformProperty<string> DataSource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_source");
        set => SetProperty("data_source", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    public TerraformProperty<string> FunctionVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_version");
        set => SetProperty("function_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    public TerraformProperty<double> MaxBatchSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_batch_size");
        set => SetProperty("max_batch_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The request_mapping_template attribute.
    /// </summary>
    public TerraformProperty<string> RequestMappingTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_mapping_template");
        set => SetProperty("request_mapping_template", value);
    }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    public TerraformProperty<string> ResponseMappingTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("response_mapping_template");
        set => SetProperty("response_mapping_template", value);
    }

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    public List<AwsAppsyncFunctionRuntimeBlock>? Runtime
    {
        set => SetProperty("runtime", value);
    }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public List<AwsAppsyncFunctionSyncConfigBlock>? SyncConfig
    {
        set => SetProperty("sync_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    public TerraformExpression FunctionId => this["function_id"];

}
