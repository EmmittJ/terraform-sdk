using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for runtime in AwsAppsyncFunction.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionRuntimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformValue<string> RuntimeVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

}


/// <summary>
/// Block type for sync_config in AwsAppsyncFunction.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionSyncConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sync_config";

    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    public TerraformValue<string>? ConflictDetection
    {
        get => GetArgument<TerraformValue<string>>("conflict_detection");
        set => SetArgument("conflict_detection", value);
    }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    public TerraformValue<string>? ConflictHandler
    {
        get => GetArgument<TerraformValue<string>>("conflict_handler");
        set => SetArgument("conflict_handler", value);
    }

    /// <summary>
    /// LambdaConflictHandlerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConflictHandlerConfig block(s) allowed")]
    public TerraformList<AwsAppsyncFunctionSyncConfigBlockLambdaConflictHandlerConfigBlock>? LambdaConflictHandlerConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncFunctionSyncConfigBlockLambdaConflictHandlerConfigBlock>>("lambda_conflict_handler_config");
        set => SetArgument("lambda_conflict_handler_config", value);
    }

}

/// <summary>
/// Block type for lambda_conflict_handler_config in AwsAppsyncFunctionSyncConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionSyncConfigBlockLambdaConflictHandlerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_conflict_handler_config";

    /// <summary>
    /// The lambda_conflict_handler_arn attribute.
    /// </summary>
    public TerraformValue<string>? LambdaConflictHandlerArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_conflict_handler_arn");
        set => SetArgument("lambda_conflict_handler_arn", value);
    }

}


/// <summary>
/// Represents a aws_appsync_function Terraform resource.
/// Manages a aws_appsync_function resource.
/// </summary>
public partial class AwsAppsyncFunction(string name) : TerraformResource("aws_appsync_function", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformValue<string>? Code
    {
        get => GetArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    public required TerraformValue<string> DataSource
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_source");
        set => SetArgument("data_source", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    public TerraformValue<string> FunctionVersion
    {
        get => GetArgument<TerraformValue<string>>("function_version") ?? CreateReference("function_version");
        set => SetArgument("function_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    public TerraformValue<double>? MaxBatchSize
    {
        get => GetArgument<TerraformValue<double>>("max_batch_size");
        set => SetArgument("max_batch_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_mapping_template attribute.
    /// </summary>
    public TerraformValue<string>? RequestMappingTemplate
    {
        get => GetArgument<TerraformValue<string>>("request_mapping_template");
        set => SetArgument("request_mapping_template", value);
    }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    public TerraformValue<string>? ResponseMappingTemplate
    {
        get => GetArgument<TerraformValue<string>>("response_mapping_template");
        set => SetArgument("response_mapping_template", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    public TerraformValue<string> FunctionId
        => CreateReference("function_id");

    /// <summary>
    /// Runtime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    public TerraformList<AwsAppsyncFunctionRuntimeBlock>? Runtime
    {
        get => GetArgument<TerraformList<AwsAppsyncFunctionRuntimeBlock>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// SyncConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public TerraformList<AwsAppsyncFunctionSyncConfigBlock>? SyncConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncFunctionSyncConfigBlock>>("sync_config");
        set => SetArgument("sync_config", value);
    }

}
