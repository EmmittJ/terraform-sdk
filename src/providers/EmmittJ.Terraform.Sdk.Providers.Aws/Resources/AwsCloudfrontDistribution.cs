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
        get => new TerraformReference<double>(this, "error_caching_min_ttl");
        set => SetArgument("error_caching_min_ttl", value);
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    public required TerraformValue<double> ErrorCode
    {
        get => new TerraformReference<double>(this, "error_code");
        set => SetArgument("error_code", value);
    }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    public TerraformValue<double>? ResponseCode
    {
        get => new TerraformReference<double>(this, "response_code");
        set => SetArgument("response_code", value);
    }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    public TerraformValue<string>? ResponsePagePath
    {
        get => new TerraformReference<string>(this, "response_page_path");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? CachePolicyId
    {
        get => new TerraformReference<string>(this, "cache_policy_id");
        set => SetArgument("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public required TerraformSet<string> CachedMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cached_methods").ResolveNodes(ctx));
        set => SetArgument("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformValue<bool>? Compress
    {
        get => new TerraformReference<bool>(this, "compress");
        set => SetArgument("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double> DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformValue<string>? FieldLevelEncryptionId
    {
        get => new TerraformReference<string>(this, "field_level_encryption_id");
        set => SetArgument("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double> MaxTtl
    {
        get => new TerraformReference<double>(this, "max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinTtl
    {
        get => new TerraformReference<double>(this, "min_ttl");
        set => SetArgument("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? OriginRequestPolicyId
    {
        get => new TerraformReference<string>(this, "origin_request_policy_id");
        set => SetArgument("origin_request_policy_id", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? RealtimeLogConfigArn
    {
        get => new TerraformReference<string>(this, "realtime_log_config_arn");
        set => SetArgument("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? ResponseHeadersPolicyId
    {
        get => new TerraformReference<string>(this, "response_headers_policy_id");
        set => SetArgument("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformValue<bool>? SmoothStreaming
    {
        get => new TerraformReference<bool>(this, "smooth_streaming");
        set => SetArgument("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformValue<string> TargetOriginId
    {
        get => new TerraformReference<string>(this, "target_origin_id");
        set => SetArgument("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformList<string> TrustedKeyGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_key_groups").ResolveNodes(ctx));
        set => SetArgument("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformList<string> TrustedSigners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_signers").ResolveNodes(ctx));
        set => SetArgument("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformValue<string> ViewerProtocolPolicy
    {
        get => new TerraformReference<string>(this, "viewer_protocol_policy");
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
    public TerraformSet<string> Headers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformValue<bool> QueryString
    {
        get => new TerraformReference<bool>(this, "query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The query_string_cache_keys attribute.
    /// </summary>
    public TerraformList<string> QueryStringCacheKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "query_string_cache_keys").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// The whitelisted_names attribute.
    /// </summary>
    public TerraformSet<string> WhitelistedNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "whitelisted_names").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => new TerraformReference<string>(this, "function_arn");
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
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
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
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The include_body attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeBody
    {
        get => new TerraformReference<bool>(this, "include_body");
        set => SetArgument("include_body", value);
    }

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => new TerraformReference<string>(this, "lambda_arn");
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
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeCookies
    {
        get => new TerraformReference<bool>(this, "include_cookies");
        set => SetArgument("include_cookies", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? CachePolicyId
    {
        get => new TerraformReference<string>(this, "cache_policy_id");
        set => SetArgument("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public required TerraformSet<string> CachedMethods
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cached_methods").ResolveNodes(ctx));
        set => SetArgument("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformValue<bool>? Compress
    {
        get => new TerraformReference<bool>(this, "compress");
        set => SetArgument("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<double> DefaultTtl
    {
        get => new TerraformReference<double>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformValue<string>? FieldLevelEncryptionId
    {
        get => new TerraformReference<string>(this, "field_level_encryption_id");
        set => SetArgument("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformValue<double> MaxTtl
    {
        get => new TerraformReference<double>(this, "max_ttl");
        set => SetArgument("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinTtl
    {
        get => new TerraformReference<double>(this, "min_ttl");
        set => SetArgument("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? OriginRequestPolicyId
    {
        get => new TerraformReference<string>(this, "origin_request_policy_id");
        set => SetArgument("origin_request_policy_id", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformValue<string> PathPattern
    {
        get => new TerraformReference<string>(this, "path_pattern");
        set => SetArgument("path_pattern", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? RealtimeLogConfigArn
    {
        get => new TerraformReference<string>(this, "realtime_log_config_arn");
        set => SetArgument("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? ResponseHeadersPolicyId
    {
        get => new TerraformReference<string>(this, "response_headers_policy_id");
        set => SetArgument("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformValue<bool>? SmoothStreaming
    {
        get => new TerraformReference<bool>(this, "smooth_streaming");
        set => SetArgument("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformValue<string> TargetOriginId
    {
        get => new TerraformReference<string>(this, "target_origin_id");
        set => SetArgument("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformList<string>? TrustedKeyGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_key_groups").ResolveNodes(ctx));
        set => SetArgument("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformList<string>? TrustedSigners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_signers").ResolveNodes(ctx));
        set => SetArgument("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformValue<string> ViewerProtocolPolicy
    {
        get => new TerraformReference<string>(this, "viewer_protocol_policy");
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
    public TerraformSet<string> Headers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformValue<bool> QueryString
    {
        get => new TerraformReference<bool>(this, "query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// The query_string_cache_keys attribute.
    /// </summary>
    public TerraformList<string> QueryStringCacheKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "query_string_cache_keys").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "forward");
        set => SetArgument("forward", value);
    }

    /// <summary>
    /// The whitelisted_names attribute.
    /// </summary>
    public TerraformSet<string>? WhitelistedNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "whitelisted_names").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => new TerraformReference<string>(this, "function_arn");
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
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
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
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The include_body attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeBody
    {
        get => new TerraformReference<bool>(this, "include_body");
        set => SetArgument("include_body", value);
    }

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => new TerraformReference<string>(this, "lambda_arn");
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
        get => new TerraformReference<double>(this, "connection_attempts");
        set => SetArgument("connection_attempts", value);
    }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionTimeout
    {
        get => new TerraformReference<double>(this, "connection_timeout");
        set => SetArgument("connection_timeout", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    public TerraformValue<string>? OriginAccessControlId
    {
        get => new TerraformReference<string>(this, "origin_access_control_id");
        set => SetArgument("origin_access_control_id", value);
    }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformValue<string> OriginId
    {
        get => new TerraformReference<string>(this, "origin_id");
        set => SetArgument("origin_id", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformValue<string>? OriginPath
    {
        get => new TerraformReference<string>(this, "origin_path");
        set => SetArgument("origin_path", value);
    }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    public TerraformValue<double> ResponseCompletionTimeout
    {
        get => new TerraformReference<double>(this, "response_completion_timeout");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpsPort is required")]
    public required TerraformValue<double> HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The origin_keepalive_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginKeepaliveTimeout
    {
        get => new TerraformReference<double>(this, "origin_keepalive_timeout");
        set => SetArgument("origin_keepalive_timeout", value);
    }

    /// <summary>
    /// The origin_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginProtocolPolicy is required")]
    public required TerraformValue<string> OriginProtocolPolicy
    {
        get => new TerraformReference<string>(this, "origin_protocol_policy");
        set => SetArgument("origin_protocol_policy", value);
    }

    /// <summary>
    /// The origin_read_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginReadTimeout
    {
        get => new TerraformReference<double>(this, "origin_read_timeout");
        set => SetArgument("origin_read_timeout", value);
    }

    /// <summary>
    /// The origin_ssl_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginSslProtocols is required")]
    public required TerraformSet<string> OriginSslProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "origin_ssl_protocols").ResolveNodes(ctx));
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The origin_shield_region attribute.
    /// </summary>
    public TerraformValue<string>? OriginShieldRegion
    {
        get => new TerraformReference<string>(this, "origin_shield_region");
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
        get => new TerraformReference<string>(this, "origin_access_identity");
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
        get => new TerraformReference<double>(this, "origin_keepalive_timeout");
        set => SetArgument("origin_keepalive_timeout", value);
    }

    /// <summary>
    /// The origin_read_timeout attribute.
    /// </summary>
    public TerraformValue<double>? OriginReadTimeout
    {
        get => new TerraformReference<double>(this, "origin_read_timeout");
        set => SetArgument("origin_read_timeout", value);
    }

    /// <summary>
    /// The vpc_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcOriginId is required")]
    public required TerraformValue<string> VpcOriginId
    {
        get => new TerraformReference<string>(this, "vpc_origin_id");
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
        get => new TerraformReference<string>(this, "origin_id");
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
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "status_codes").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "origin_id");
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
    public TerraformSet<string> Locations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "locations").ResolveNodes(ctx));
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// The restriction_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestrictionType is required")]
    public required TerraformValue<string> RestrictionType
    {
        get => new TerraformReference<string>(this, "restriction_type");
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
        get => new TerraformReference<string>(this, "acm_certificate_arn");
        set => SetArgument("acm_certificate_arn", value);
    }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    public TerraformValue<bool>? CloudfrontDefaultCertificate
    {
        get => new TerraformReference<bool>(this, "cloudfront_default_certificate");
        set => SetArgument("cloudfront_default_certificate", value);
    }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? IamCertificateId
    {
        get => new TerraformReference<string>(this, "iam_certificate_id");
        set => SetArgument("iam_certificate_id", value);
    }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumProtocolVersion
    {
        get => new TerraformReference<string>(this, "minimum_protocol_version");
        set => SetArgument("minimum_protocol_version", value);
    }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    public TerraformValue<string>? SslSupportMethod
    {
        get => new TerraformReference<string>(this, "ssl_support_method");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "aliases").ResolveNodes(ctx));
        set => SetArgument("aliases", value);
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformValue<string>? AnycastIpListId
    {
        get => new TerraformReference<string>(this, "anycast_ip_list_id");
        set => SetArgument("anycast_ip_list_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    public TerraformValue<string> ContinuousDeploymentPolicyId
    {
        get => new TerraformReference<string>(this, "continuous_deployment_policy_id");
        set => SetArgument("continuous_deployment_policy_id", value);
    }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    public TerraformValue<string>? DefaultRootObject
    {
        get => new TerraformReference<string>(this, "default_root_object");
        set => SetArgument("default_root_object", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    public TerraformValue<string>? HttpVersion
    {
        get => new TerraformReference<string>(this, "http_version");
        set => SetArgument("http_version", value);
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
    /// The is_ipv6_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IsIpv6Enabled
    {
        get => new TerraformReference<bool>(this, "is_ipv6_enabled");
        set => SetArgument("is_ipv6_enabled", value);
    }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    public TerraformValue<string>? PriceClass
    {
        get => new TerraformReference<string>(this, "price_class");
        set => SetArgument("price_class", value);
    }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    public TerraformValue<bool>? RetainOnDelete
    {
        get => new TerraformReference<bool>(this, "retain_on_delete");
        set => SetArgument("retain_on_delete", value);
    }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    public TerraformValue<bool>? Staging
    {
        get => new TerraformReference<bool>(this, "staging");
        set => SetArgument("staging", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForDeployment
    {
        get => new TerraformReference<bool>(this, "wait_for_deployment");
        set => SetArgument("wait_for_deployment", value);
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformValue<string>? WebAclId
    {
        get => new TerraformReference<string>(this, "web_acl_id");
        set => SetArgument("web_acl_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
    {
        get => new TerraformReference<string>(this, "caller_reference");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    public TerraformValue<double> InProgressValidationBatches
    {
        get => new TerraformReference<double>(this, "in_progress_validation_batches");
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedKeyGroups
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trusted_key_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrustedSigners
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trusted_signers").ResolveNodes(ctx));
    }

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
