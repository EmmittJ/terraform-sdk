using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_error_response in AwsCloudfrontDistribution.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionCustomErrorResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_error_response";

    /// <summary>
    /// The error_caching_min_ttl attribute.
    /// </summary>
    public TerraformValue<double>? ErrorCachingMinTtl
    {
        get => GetArgument<TerraformValue<double>>("error_caching_min_ttl");
        set => SetArgument("error_caching_min_ttl", value);
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    public required TerraformValue<double> ErrorCode
    {
        get => GetArgument<TerraformValue<double>>("error_code");
        set => SetArgument("error_code", value);
    }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    public TerraformValue<double>? ResponseCode
    {
        get => GetArgument<TerraformValue<double>>("response_code");
        set => SetArgument("response_code", value);
    }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    public TerraformValue<string>? ResponsePagePath
    {
        get => GetArgument<TerraformValue<string>>("response_page_path");
        set => SetArgument("response_page_path", value);
    }

}


/// <summary>
/// Block type for default_cache_behavior in AwsCloudfrontDistribution.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_cache_behavior";

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public required TerraformSet<string> AllowedMethods
    {
        get => GetArgument<TerraformSet<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? CachePolicyId
    {
        get => GetArgument<TerraformValue<string>>("cache_policy_id");
        set => SetArgument("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public required TerraformSet<string> CachedMethods
    {
        get => GetArgument<TerraformSet<string>>("cached_methods");
        set => SetArgument("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformValue<bool>? Compress
    {
        get => GetArgument<TerraformValue<bool>>("compress");
        set => SetArgument("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTtl
    {
        get => GetArgument<TerraformValue<double>>("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformValue<string>? FieldLevelEncryptionId
    {
        get => GetArgument<TerraformValue<string>>("field_level_encryption_id");
        set => SetArgument("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MaxTtl
    {
        get => GetArgument<TerraformValue<double>>("max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinTtl
    {
        get => GetArgument<TerraformValue<double>>("min_ttl");
        set => SetArgument("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? OriginRequestPolicyId
    {
        get => GetArgument<TerraformValue<string>>("origin_request_policy_id");
        set => SetArgument("origin_request_policy_id", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? RealtimeLogConfigArn
    {
        get => GetArgument<TerraformValue<string>>("realtime_log_config_arn");
        set => SetArgument("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? ResponseHeadersPolicyId
    {
        get => GetArgument<TerraformValue<string>>("response_headers_policy_id");
        set => SetArgument("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformValue<bool>? SmoothStreaming
    {
        get => GetArgument<TerraformValue<bool>>("smooth_streaming");
        set => SetArgument("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformValue<string> TargetOriginId
    {
        get => GetArgument<TerraformValue<string>>("target_origin_id");
        set => SetArgument("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformList<string>? TrustedKeyGroups
    {
        get => GetArgument<TerraformList<string>>("trusted_key_groups");
        set => SetArgument("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformList<string>? TrustedSigners
    {
        get => GetArgument<TerraformList<string>>("trusted_signers");
        set => SetArgument("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformValue<string> ViewerProtocolPolicy
    {
        get => GetArgument<TerraformValue<string>>("viewer_protocol_policy");
        set => SetArgument("viewer_protocol_policy", value);
    }

    /// <summary>
    /// ForwardedValues block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardedValues block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlock>? ForwardedValues
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlock>>("forwarded_values");
        set => SetArgument("forwarded_values", value);
    }

    /// <summary>
    /// FunctionAssociation block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 FunctionAssociation block(s) allowed")]
    public TerraformSet<AwsCloudfrontDistributionDefaultCacheBehaviorBlockFunctionAssociationBlock>? FunctionAssociation
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionDefaultCacheBehaviorBlockFunctionAssociationBlock>>("function_association");
        set => SetArgument("function_association", value);
    }

    /// <summary>
    /// GrpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlockGrpcConfigBlock>? GrpcConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlockGrpcConfigBlock>>("grpc_config");
        set => SetArgument("grpc_config", value);
    }

    /// <summary>
    /// LambdaFunctionAssociation block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 LambdaFunctionAssociation block(s) allowed")]
    public TerraformSet<AwsCloudfrontDistributionDefaultCacheBehaviorBlockLambdaFunctionAssociationBlock>? LambdaFunctionAssociation
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionDefaultCacheBehaviorBlockLambdaFunctionAssociationBlock>>("lambda_function_association");
        set => SetArgument("lambda_function_association", value);
    }

}

/// <summary>
/// Block type for forwarded_values in AwsCloudfrontDistributionDefaultCacheBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarded_values";

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformSet<string>? Headers
    {
        get => GetArgument<TerraformSet<string>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformValue<bool> QueryString
    {
        get => GetArgument<TerraformValue<bool>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The query_string_cache_keys attribute.
    /// </summary>
    public TerraformList<string>? QueryStringCacheKeys
    {
        get => GetArgument<TerraformList<string>>("query_string_cache_keys");
        set => SetArgument("query_string_cache_keys", value);
    }

    /// <summary>
    /// Cookies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cookies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Cookies block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cookies block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlockCookiesBlock> Cookies
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlockCookiesBlock>>("cookies");
        set => SetArgument("cookies", value);
    }

}

/// <summary>
/// Block type for cookies in AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlockForwardedValuesBlockCookiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookies";

    /// <summary>
    /// The forward attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Forward is required")]
    public required TerraformValue<string> Forward
    {
        get => GetArgument<TerraformValue<string>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// The whitelisted_names attribute.
    /// </summary>
    public TerraformSet<string>? WhitelistedNames
    {
        get => GetArgument<TerraformSet<string>>("whitelisted_names");
        set => SetArgument("whitelisted_names", value);
    }

}

/// <summary>
/// Block type for function_association in AwsCloudfrontDistributionDefaultCacheBehaviorBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlockFunctionAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "function_association";

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => GetArgument<TerraformValue<string>>("function_arn");
        set => SetArgument("function_arn", value);
    }

}

/// <summary>
/// Block type for grpc_config in AwsCloudfrontDistributionDefaultCacheBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlockGrpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for lambda_function_association in AwsCloudfrontDistributionDefaultCacheBehaviorBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlockLambdaFunctionAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_association";

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The include_body attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeBody
    {
        get => GetArgument<TerraformValue<bool>>("include_body");
        set => SetArgument("include_body", value);
    }

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

}


/// <summary>
/// Block type for logging_config in AwsCloudfrontDistribution.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeCookies
    {
        get => GetArgument<TerraformValue<bool>>("include_cookies");
        set => SetArgument("include_cookies", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for ordered_cache_behavior in AwsCloudfrontDistribution.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ordered_cache_behavior";

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public required TerraformSet<string> AllowedMethods
    {
        get => GetArgument<TerraformSet<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? CachePolicyId
    {
        get => GetArgument<TerraformValue<string>>("cache_policy_id");
        set => SetArgument("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public required TerraformSet<string> CachedMethods
    {
        get => GetArgument<TerraformSet<string>>("cached_methods");
        set => SetArgument("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformValue<bool>? Compress
    {
        get => GetArgument<TerraformValue<bool>>("compress");
        set => SetArgument("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double>? DefaultTtl
    {
        get => GetArgument<TerraformValue<double>>("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformValue<string>? FieldLevelEncryptionId
    {
        get => GetArgument<TerraformValue<string>>("field_level_encryption_id");
        set => SetArgument("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MaxTtl
    {
        get => GetArgument<TerraformValue<double>>("max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinTtl
    {
        get => GetArgument<TerraformValue<double>>("min_ttl");
        set => SetArgument("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? OriginRequestPolicyId
    {
        get => GetArgument<TerraformValue<string>>("origin_request_policy_id");
        set => SetArgument("origin_request_policy_id", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformValue<string> PathPattern
    {
        get => GetArgument<TerraformValue<string>>("path_pattern");
        set => SetArgument("path_pattern", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? RealtimeLogConfigArn
    {
        get => GetArgument<TerraformValue<string>>("realtime_log_config_arn");
        set => SetArgument("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? ResponseHeadersPolicyId
    {
        get => GetArgument<TerraformValue<string>>("response_headers_policy_id");
        set => SetArgument("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformValue<bool>? SmoothStreaming
    {
        get => GetArgument<TerraformValue<bool>>("smooth_streaming");
        set => SetArgument("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformValue<string> TargetOriginId
    {
        get => GetArgument<TerraformValue<string>>("target_origin_id");
        set => SetArgument("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformList<string>? TrustedKeyGroups
    {
        get => GetArgument<TerraformList<string>>("trusted_key_groups");
        set => SetArgument("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformList<string>? TrustedSigners
    {
        get => GetArgument<TerraformList<string>>("trusted_signers");
        set => SetArgument("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformValue<string> ViewerProtocolPolicy
    {
        get => GetArgument<TerraformValue<string>>("viewer_protocol_policy");
        set => SetArgument("viewer_protocol_policy", value);
    }

    /// <summary>
    /// ForwardedValues block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardedValues block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlock>? ForwardedValues
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlock>>("forwarded_values");
        set => SetArgument("forwarded_values", value);
    }

    /// <summary>
    /// FunctionAssociation block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 FunctionAssociation block(s) allowed")]
    public TerraformSet<AwsCloudfrontDistributionOrderedCacheBehaviorBlockFunctionAssociationBlock>? FunctionAssociation
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionOrderedCacheBehaviorBlockFunctionAssociationBlock>>("function_association");
        set => SetArgument("function_association", value);
    }

    /// <summary>
    /// GrpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlockGrpcConfigBlock>? GrpcConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlockGrpcConfigBlock>>("grpc_config");
        set => SetArgument("grpc_config", value);
    }

    /// <summary>
    /// LambdaFunctionAssociation block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 LambdaFunctionAssociation block(s) allowed")]
    public TerraformSet<AwsCloudfrontDistributionOrderedCacheBehaviorBlockLambdaFunctionAssociationBlock>? LambdaFunctionAssociation
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionOrderedCacheBehaviorBlockLambdaFunctionAssociationBlock>>("lambda_function_association");
        set => SetArgument("lambda_function_association", value);
    }

}

/// <summary>
/// Block type for forwarded_values in AwsCloudfrontDistributionOrderedCacheBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarded_values";

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformSet<string>? Headers
    {
        get => GetArgument<TerraformSet<string>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformValue<bool> QueryString
    {
        get => GetArgument<TerraformValue<bool>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The query_string_cache_keys attribute.
    /// </summary>
    public TerraformList<string>? QueryStringCacheKeys
    {
        get => GetArgument<TerraformList<string>>("query_string_cache_keys");
        set => SetArgument("query_string_cache_keys", value);
    }

    /// <summary>
    /// Cookies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cookies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Cookies block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cookies block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlockCookiesBlock> Cookies
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlockCookiesBlock>>("cookies");
        set => SetArgument("cookies", value);
    }

}

/// <summary>
/// Block type for cookies in AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlockForwardedValuesBlockCookiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookies";

    /// <summary>
    /// The forward attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Forward is required")]
    public required TerraformValue<string> Forward
    {
        get => GetArgument<TerraformValue<string>>("forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// The whitelisted_names attribute.
    /// </summary>
    public TerraformSet<string>? WhitelistedNames
    {
        get => GetArgument<TerraformSet<string>>("whitelisted_names");
        set => SetArgument("whitelisted_names", value);
    }

}

/// <summary>
/// Block type for function_association in AwsCloudfrontDistributionOrderedCacheBehaviorBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlockFunctionAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "function_association";

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => GetArgument<TerraformValue<string>>("function_arn");
        set => SetArgument("function_arn", value);
    }

}

/// <summary>
/// Block type for grpc_config in AwsCloudfrontDistributionOrderedCacheBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlockGrpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for lambda_function_association in AwsCloudfrontDistributionOrderedCacheBehaviorBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlockLambdaFunctionAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_association";

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The include_body attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeBody
    {
        get => GetArgument<TerraformValue<bool>>("include_body");
        set => SetArgument("include_body", value);
    }

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

}


/// <summary>
/// Block type for origin in AwsCloudfrontDistribution.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin";

    /// <summary>
    /// The connection_attempts attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionAttempts
    {
        get => GetArgument<TerraformValue<double>>("connection_attempts");
        set => SetArgument("connection_attempts", value);
    }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionTimeout
    {
        get => GetArgument<TerraformValue<double>>("connection_timeout");
        set => SetArgument("connection_timeout", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    public TerraformValue<string>? OriginAccessControlId
    {
        get => GetArgument<TerraformValue<string>>("origin_access_control_id");
        set => SetArgument("origin_access_control_id", value);
    }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformValue<string> OriginId
    {
        get => GetArgument<TerraformValue<string>>("origin_id");
        set => SetArgument("origin_id", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformValue<string>? OriginPath
    {
        get => GetArgument<TerraformValue<string>>("origin_path");
        set => SetArgument("origin_path", value);
    }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    public TerraformValue<double>? ResponseCompletionTimeout
    {
        get => GetArgument<TerraformValue<double>>("response_completion_timeout");
        set => SetArgument("response_completion_timeout", value);
    }

    /// <summary>
    /// CustomHeader block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontDistributionOriginBlockCustomHeaderBlock>? CustomHeader
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionOriginBlockCustomHeaderBlock>>("custom_header");
        set => SetArgument("custom_header", value);
    }

    /// <summary>
    /// CustomOriginConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomOriginConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOriginBlockCustomOriginConfigBlock>? CustomOriginConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOriginBlockCustomOriginConfigBlock>>("custom_origin_config");
        set => SetArgument("custom_origin_config", value);
    }

    /// <summary>
    /// OriginShield block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginShield block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOriginBlockOriginShieldBlock>? OriginShield
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOriginBlockOriginShieldBlock>>("origin_shield");
        set => SetArgument("origin_shield", value);
    }

    /// <summary>
    /// S3OriginConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3OriginConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOriginBlockS3OriginConfigBlock>? S3OriginConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOriginBlockS3OriginConfigBlock>>("s3_origin_config");
        set => SetArgument("s3_origin_config", value);
    }

    /// <summary>
    /// VpcOriginConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOriginConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOriginBlockVpcOriginConfigBlock>? VpcOriginConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOriginBlockVpcOriginConfigBlock>>("vpc_origin_config");
        set => SetArgument("vpc_origin_config", value);
    }

}

/// <summary>
/// Block type for custom_header in AwsCloudfrontDistributionOriginBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginBlockCustomHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_header";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for custom_origin_config in AwsCloudfrontDistributionOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOriginBlockCustomOriginConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_origin_config";

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpPort is required")]
    public required TerraformValue<double> HttpPort
    {
        get => GetArgument<TerraformValue<double>>("http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpsPort is required")]
    public required TerraformValue<double> HttpsPort
    {
        get => GetArgument<TerraformValue<double>>("https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The origin_keepalive_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginKeepaliveTimeout
    {
        get => GetArgument<TerraformValue<double>>("origin_keepalive_timeout");
        set => SetArgument("origin_keepalive_timeout", value);
    }

    /// <summary>
    /// The origin_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginProtocolPolicy is required")]
    public required TerraformValue<string> OriginProtocolPolicy
    {
        get => GetArgument<TerraformValue<string>>("origin_protocol_policy");
        set => SetArgument("origin_protocol_policy", value);
    }

    /// <summary>
    /// The origin_read_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginReadTimeout
    {
        get => GetArgument<TerraformValue<double>>("origin_read_timeout");
        set => SetArgument("origin_read_timeout", value);
    }

    /// <summary>
    /// The origin_ssl_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginSslProtocols is required")]
    public required TerraformSet<string> OriginSslProtocols
    {
        get => GetArgument<TerraformSet<string>>("origin_ssl_protocols");
        set => SetArgument("origin_ssl_protocols", value);
    }

}

/// <summary>
/// Block type for origin_shield in AwsCloudfrontDistributionOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOriginBlockOriginShieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin_shield";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The origin_shield_region attribute.
    /// </summary>
    public TerraformValue<string>? OriginShieldRegion
    {
        get => GetArgument<TerraformValue<string>>("origin_shield_region");
        set => SetArgument("origin_shield_region", value);
    }

}

/// <summary>
/// Block type for s3_origin_config in AwsCloudfrontDistributionOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOriginBlockS3OriginConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_origin_config";

    /// <summary>
    /// The origin_access_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginAccessIdentity is required")]
    public required TerraformValue<string> OriginAccessIdentity
    {
        get => GetArgument<TerraformValue<string>>("origin_access_identity");
        set => SetArgument("origin_access_identity", value);
    }

}

/// <summary>
/// Block type for vpc_origin_config in AwsCloudfrontDistributionOriginBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOriginBlockVpcOriginConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_origin_config";

    /// <summary>
    /// The origin_keepalive_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginKeepaliveTimeout
    {
        get => GetArgument<TerraformValue<double>>("origin_keepalive_timeout");
        set => SetArgument("origin_keepalive_timeout", value);
    }

    /// <summary>
    /// The origin_read_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginReadTimeout
    {
        get => GetArgument<TerraformValue<double>>("origin_read_timeout");
        set => SetArgument("origin_read_timeout", value);
    }

    /// <summary>
    /// The vpc_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcOriginId is required")]
    public required TerraformValue<string> VpcOriginId
    {
        get => GetArgument<TerraformValue<string>>("vpc_origin_id");
        set => SetArgument("vpc_origin_id", value);
    }

}


/// <summary>
/// Block type for origin_group in AwsCloudfrontDistribution.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin_group";

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformValue<string> OriginId
    {
        get => GetArgument<TerraformValue<string>>("origin_id");
        set => SetArgument("origin_id", value);
    }

    /// <summary>
    /// FailoverCriteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverCriteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverCriteria block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionOriginGroupBlockFailoverCriteriaBlock> FailoverCriteria
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionOriginGroupBlockFailoverCriteriaBlock>>("failover_criteria");
        set => SetArgument("failover_criteria", value);
    }

    /// <summary>
    /// Member block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Member block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Member block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionOriginGroupBlockMemberBlock>? Member
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOriginGroupBlockMemberBlock>>("member");
        set => SetArgument("member", value);
    }

}

/// <summary>
/// Block type for failover_criteria in AwsCloudfrontDistributionOriginGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOriginGroupBlockFailoverCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_criteria";

    /// <summary>
    /// The status_codes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCodes is required")]
    public required TerraformSet<double> StatusCodes
    {
        get => GetArgument<TerraformSet<double>>("status_codes");
        set => SetArgument("status_codes", value);
    }

}

/// <summary>
/// Block type for member in AwsCloudfrontDistributionOriginGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOriginGroupBlockMemberBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "member";

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformValue<string> OriginId
    {
        get => GetArgument<TerraformValue<string>>("origin_id");
        set => SetArgument("origin_id", value);
    }

}


/// <summary>
/// Block type for restrictions in AwsCloudfrontDistribution.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restrictions";

    /// <summary>
    /// GeoRestriction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoRestriction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GeoRestriction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoRestriction block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionRestrictionsBlockGeoRestrictionBlock> GeoRestriction
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionRestrictionsBlockGeoRestrictionBlock>>("geo_restriction");
        set => SetArgument("geo_restriction", value);
    }

}

/// <summary>
/// Block type for geo_restriction in AwsCloudfrontDistributionRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionRestrictionsBlockGeoRestrictionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo_restriction";

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformSet<string>? Locations
    {
        get => GetArgument<TerraformSet<string>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The restriction_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestrictionType is required")]
    public required TerraformValue<string> RestrictionType
    {
        get => GetArgument<TerraformValue<string>>("restriction_type");
        set => SetArgument("restriction_type", value);
    }

}


/// <summary>
/// Block type for viewer_certificate in AwsCloudfrontDistribution.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionViewerCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "viewer_certificate";

    /// <summary>
    /// The acm_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? AcmCertificateArn
    {
        get => GetArgument<TerraformValue<string>>("acm_certificate_arn");
        set => SetArgument("acm_certificate_arn", value);
    }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? CloudfrontDefaultCertificate
    {
        get => GetArgument<TerraformValue<bool>>("cloudfront_default_certificate");
        set => SetArgument("cloudfront_default_certificate", value);
    }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? IamCertificateId
    {
        get => GetArgument<TerraformValue<string>>("iam_certificate_id");
        set => SetArgument("iam_certificate_id", value);
    }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumProtocolVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_protocol_version");
        set => SetArgument("minimum_protocol_version", value);
    }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    public TerraformValue<string>? SslSupportMethod
    {
        get => GetArgument<TerraformValue<string>>("ssl_support_method");
        set => SetArgument("ssl_support_method", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_distribution Terraform resource.
/// Manages a aws_cloudfront_distribution resource.
/// </summary>
public partial class AwsCloudfrontDistribution(string name) : TerraformResource("aws_cloudfront_distribution", name)
{
    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformSet<string>? Aliases
    {
        get => GetArgument<TerraformSet<string>>("aliases");
        set => SetArgument("aliases", value);
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformValue<string>? AnycastIpListId
    {
        get => GetArgument<TerraformValue<string>>("anycast_ip_list_id");
        set => SetArgument("anycast_ip_list_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? ContinuousDeploymentPolicyId
    {
        get => GetArgument<TerraformValue<string>>("continuous_deployment_policy_id");
        set => SetArgument("continuous_deployment_policy_id", value);
    }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRootObject
    {
        get => GetArgument<TerraformValue<string>>("default_root_object");
        set => SetArgument("default_root_object", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    public TerraformValue<string>? HttpVersion
    {
        get => GetArgument<TerraformValue<string>>("http_version");
        set => SetArgument("http_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_ipv6_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsIpv6Enabled
    {
        get => GetArgument<TerraformValue<bool>>("is_ipv6_enabled");
        set => SetArgument("is_ipv6_enabled", value);
    }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    public TerraformValue<string>? PriceClass
    {
        get => GetArgument<TerraformValue<string>>("price_class");
        set => SetArgument("price_class", value);
    }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    public TerraformValue<bool>? RetainOnDelete
    {
        get => GetArgument<TerraformValue<bool>>("retain_on_delete");
        set => SetArgument("retain_on_delete", value);
    }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    public TerraformValue<bool>? Staging
    {
        get => GetArgument<TerraformValue<bool>>("staging");
        set => SetArgument("staging", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForDeployment
    {
        get => GetArgument<TerraformValue<bool>>("wait_for_deployment");
        set => SetArgument("wait_for_deployment", value);
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformValue<string>? WebAclId
    {
        get => GetArgument<TerraformValue<string>>("web_acl_id");
        set => SetArgument("web_acl_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
        => AsReference("caller_reference");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => AsReference("domain_name");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    public TerraformValue<double> InProgressValidationBatches
        => AsReference("in_progress_validation_batches");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
        => AsReference("last_modified_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedKeyGroups
        => AsReference("trusted_key_groups");

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedSigners
        => AsReference("trusted_signers");

    /// <summary>
    /// CustomErrorResponse block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontDistributionCustomErrorResponseBlock>? CustomErrorResponse
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionCustomErrorResponseBlock>>("custom_error_response");
        set => SetArgument("custom_error_response", value);
    }

    /// <summary>
    /// DefaultCacheBehavior block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlock> DefaultCacheBehavior
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlock>>("default_cache_behavior");
        set => SetArgument("default_cache_behavior", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontDistributionLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// OrderedCacheBehavior block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>? OrderedCacheBehavior
    {
        get => GetArgument<TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>>("ordered_cache_behavior");
        set => SetArgument("ordered_cache_behavior", value);
    }

    /// <summary>
    /// Origin block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    public required TerraformSet<AwsCloudfrontDistributionOriginBlock> Origin
    {
        get => GetRequiredArgument<TerraformSet<AwsCloudfrontDistributionOriginBlock>>("origin");
        set => SetArgument("origin", value);
    }

    /// <summary>
    /// OriginGroup block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontDistributionOriginGroupBlock>? OriginGroup
    {
        get => GetArgument<TerraformSet<AwsCloudfrontDistributionOriginGroupBlock>>("origin_group");
        set => SetArgument("origin_group", value);
    }

    /// <summary>
    /// Restrictions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Restrictions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionRestrictionsBlock> Restrictions
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionRestrictionsBlock>>("restrictions");
        set => SetArgument("restrictions", value);
    }

    /// <summary>
    /// ViewerCertificate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerCertificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ViewerCertificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ViewerCertificate block(s) allowed")]
    public required TerraformList<AwsCloudfrontDistributionViewerCertificateBlock> ViewerCertificate
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontDistributionViewerCertificateBlock>>("viewer_certificate");
        set => SetArgument("viewer_certificate", value);
    }

}
