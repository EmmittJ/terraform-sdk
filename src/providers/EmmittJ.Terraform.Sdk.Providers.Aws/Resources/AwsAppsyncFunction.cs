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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformProperty<string> RuntimeVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("runtime_version");
        set => WithProperty("runtime_version", value);
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
        get => GetProperty<TerraformProperty<string>>("conflict_detection");
        set => WithProperty("conflict_detection", value);
    }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictHandler
    {
        get => GetProperty<TerraformProperty<string>>("conflict_handler");
        set => WithProperty("conflict_handler", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("function_id");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformProperty<string>? Code
    {
        get => GetProperty<TerraformProperty<string>>("code");
        set => this.WithProperty("code", value);
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    public required TerraformProperty<string> DataSource
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_source");
        set => this.WithProperty("data_source", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionVersion
    {
        get => GetProperty<TerraformProperty<string>>("function_version");
        set => this.WithProperty("function_version", value);
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
    /// The max_batch_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBatchSize
    {
        get => GetProperty<TerraformProperty<double>>("max_batch_size");
        set => this.WithProperty("max_batch_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_mapping_template attribute.
    /// </summary>
    public TerraformProperty<string>? RequestMappingTemplate
    {
        get => GetProperty<TerraformProperty<string>>("request_mapping_template");
        set => this.WithProperty("request_mapping_template", value);
    }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseMappingTemplate
    {
        get => GetProperty<TerraformProperty<string>>("response_mapping_template");
        set => this.WithProperty("response_mapping_template", value);
    }

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    public List<AwsAppsyncFunctionRuntimeBlock>? Runtime
    {
        get => GetProperty<List<AwsAppsyncFunctionRuntimeBlock>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public List<AwsAppsyncFunctionSyncConfigBlock>? SyncConfig
    {
        get => GetProperty<List<AwsAppsyncFunctionSyncConfigBlock>>("sync_config");
        set => this.WithProperty("sync_config", value);
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
