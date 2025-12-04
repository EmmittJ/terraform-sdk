using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for caching_config in AwsAppsyncResolver.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverCachingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "caching_config";

    /// <summary>
    /// The caching_keys attribute.
    /// </summary>
    public TerraformSet<string>? CachingKeys
    {
        get => GetArgument<TerraformSet<string>>("caching_keys");
        set => SetArgument("caching_keys", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => GetArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for pipeline_config in AwsAppsyncResolver.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverPipelineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_config";

    /// <summary>
    /// The functions attribute.
    /// </summary>
    public TerraformList<string>? Functions
    {
        get => GetArgument<TerraformList<string>>("functions");
        set => SetArgument("functions", value);
    }

}


/// <summary>
/// Block type for runtime in AwsAppsyncResolver.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverRuntimeBlock : TerraformBlock
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
/// Block type for sync_config in AwsAppsyncResolver.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverSyncConfigBlock : TerraformBlock
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
    public TerraformList<AwsAppsyncResolverSyncConfigBlockLambdaConflictHandlerConfigBlock>? LambdaConflictHandlerConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncResolverSyncConfigBlockLambdaConflictHandlerConfigBlock>>("lambda_conflict_handler_config");
        set => SetArgument("lambda_conflict_handler_config", value);
    }

}

/// <summary>
/// Block type for lambda_conflict_handler_config in AwsAppsyncResolverSyncConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverSyncConfigBlockLambdaConflictHandlerConfigBlock : TerraformBlock
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
/// Represents a aws_appsync_resolver Terraform resource.
/// Manages a aws_appsync_resolver resource.
/// </summary>
public partial class AwsAppsyncResolver(string name) : TerraformResource("aws_appsync_resolver", name)
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
    public TerraformValue<string>? DataSource
    {
        get => GetArgument<TerraformValue<string>>("data_source");
        set => SetArgument("data_source", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => GetRequiredArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_template attribute.
    /// </summary>
    public TerraformValue<string>? RequestTemplate
    {
        get => GetArgument<TerraformValue<string>>("request_template");
        set => SetArgument("request_template", value);
    }

    /// <summary>
    /// The response_template attribute.
    /// </summary>
    public TerraformValue<string>? ResponseTemplate
    {
        get => GetArgument<TerraformValue<string>>("response_template");
        set => SetArgument("response_template", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// CachingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CachingConfig block(s) allowed")]
    public TerraformList<AwsAppsyncResolverCachingConfigBlock>? CachingConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncResolverCachingConfigBlock>>("caching_config");
        set => SetArgument("caching_config", value);
    }

    /// <summary>
    /// PipelineConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineConfig block(s) allowed")]
    public TerraformList<AwsAppsyncResolverPipelineConfigBlock>? PipelineConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncResolverPipelineConfigBlock>>("pipeline_config");
        set => SetArgument("pipeline_config", value);
    }

    /// <summary>
    /// Runtime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    public TerraformList<AwsAppsyncResolverRuntimeBlock>? Runtime
    {
        get => GetArgument<TerraformList<AwsAppsyncResolverRuntimeBlock>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// SyncConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public TerraformList<AwsAppsyncResolverSyncConfigBlock>? SyncConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncResolverSyncConfigBlock>>("sync_config");
        set => SetArgument("sync_config", value);
    }

}
