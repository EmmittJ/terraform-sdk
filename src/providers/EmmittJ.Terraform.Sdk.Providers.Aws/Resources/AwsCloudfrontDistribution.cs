using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_error_response in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionCustomErrorResponseBlock : ITerraformBlock
{
    /// <summary>
    /// The error_caching_min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("error_caching_min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ErrorCachingMinTtl { get; set; }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    [TerraformPropertyName("error_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ErrorCode { get; set; }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    [TerraformPropertyName("response_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ResponseCode { get; set; }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    [TerraformPropertyName("response_page_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponsePagePath { get; set; }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedMethods { get; set; }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("cache_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CachePolicyId { get; set; }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    [TerraformPropertyName("cached_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CachedMethods { get; set; }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    [TerraformPropertyName("compress")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Compress { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DefaultTtl { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "default_ttl");

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    [TerraformPropertyName("field_level_encryption_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FieldLevelEncryptionId { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxTtl { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_ttl");

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinTtl { get; set; }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_request_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OriginRequestPolicyId { get; set; }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("realtime_log_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RealtimeLogConfigArn { get; set; }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("response_headers_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseHeadersPolicyId { get; set; }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    [TerraformPropertyName("smooth_streaming")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmoothStreaming { get; set; }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    [TerraformPropertyName("target_origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetOriginId { get; set; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformPropertyName("trusted_key_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> TrustedKeyGroups { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "trusted_key_groups");

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformPropertyName("trusted_signers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> TrustedSigners { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "trusted_signers");

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    [TerraformPropertyName("viewer_protocol_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ViewerProtocolPolicy { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    [TerraformPropertyName("include_cookies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeCookies { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

}

/// <summary>
/// Block type for ordered_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedMethods { get; set; }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("cache_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CachePolicyId { get; set; }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    [TerraformPropertyName("cached_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CachedMethods { get; set; }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    [TerraformPropertyName("compress")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Compress { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DefaultTtl { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "default_ttl");

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    [TerraformPropertyName("field_level_encryption_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FieldLevelEncryptionId { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxTtl { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_ttl");

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinTtl { get; set; }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_request_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OriginRequestPolicyId { get; set; }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    [TerraformPropertyName("path_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PathPattern { get; set; }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("realtime_log_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RealtimeLogConfigArn { get; set; }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("response_headers_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseHeadersPolicyId { get; set; }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    [TerraformPropertyName("smooth_streaming")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmoothStreaming { get; set; }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    [TerraformPropertyName("target_origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetOriginId { get; set; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformPropertyName("trusted_key_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TrustedKeyGroups { get; set; }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformPropertyName("trusted_signers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TrustedSigners { get; set; }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    [TerraformPropertyName("viewer_protocol_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ViewerProtocolPolicy { get; set; }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginBlock : ITerraformBlock
{
    /// <summary>
    /// The connection_attempts attribute.
    /// </summary>
    [TerraformPropertyName("connection_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ConnectionAttempts { get; set; }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    [TerraformPropertyName("connection_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ConnectionTimeout { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_access_control_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OriginAccessControlId { get; set; }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    [TerraformPropertyName("origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OriginId { get; set; }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    [TerraformPropertyName("origin_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OriginPath { get; set; }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    [TerraformPropertyName("response_completion_timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ResponseCompletionTimeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "response_completion_timeout");

}

/// <summary>
/// Block type for origin_group in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    [TerraformPropertyName("origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OriginId { get; set; }

}

/// <summary>
/// Block type for restrictions in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionRestrictionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for viewer_certificate in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionViewerCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The acm_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("acm_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcmCertificateArn { get; set; }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_default_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CloudfrontDefaultCertificate { get; set; }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("iam_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamCertificateId { get; set; }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_protocol_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimumProtocolVersion { get; set; }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    [TerraformPropertyName("ssl_support_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SslSupportMethod { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_distribution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontDistribution : TerraformResource
{
    public AwsCloudfrontDistribution(string name) : base("aws_cloudfront_distribution", name)
    {
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Aliases { get; set; }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    [TerraformPropertyName("anycast_ip_list_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AnycastIpListId { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("continuous_deployment_policy_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContinuousDeploymentPolicyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "continuous_deployment_policy_id");

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    [TerraformPropertyName("default_root_object")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultRootObject { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    [TerraformPropertyName("http_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The is_ipv6_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_ipv6_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsIpv6Enabled { get; set; }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    [TerraformPropertyName("price_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PriceClass { get; set; }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    [TerraformPropertyName("retain_on_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RetainOnDelete { get; set; }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    [TerraformPropertyName("staging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Staging { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_deployment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForDeployment { get; set; }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    [TerraformPropertyName("web_acl_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WebAclId { get; set; }

    /// <summary>
    /// Block for custom_error_response.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("custom_error_response")]
    public TerraformSet<TerraformBlock<AwsCloudfrontDistributionCustomErrorResponseBlock>>? CustomErrorResponse { get; set; } = new();

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    [TerraformPropertyName("default_cache_behavior")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionDefaultCacheBehaviorBlock>>? DefaultCacheBehavior { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for ordered_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ordered_cache_behavior")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>>? OrderedCacheBehavior { get; set; } = new();

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [TerraformPropertyName("origin")]
    public TerraformSet<TerraformBlock<AwsCloudfrontDistributionOriginBlock>>? Origin { get; set; } = new();

    /// <summary>
    /// Block for origin_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("origin_group")]
    public TerraformSet<TerraformBlock<AwsCloudfrontDistributionOriginGroupBlock>>? OriginGroup { get; set; } = new();

    /// <summary>
    /// Block for restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Restrictions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    [TerraformPropertyName("restrictions")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionRestrictionsBlock>>? Restrictions { get; set; } = new();

    /// <summary>
    /// Block for viewer_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerCertificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ViewerCertificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ViewerCertificate block(s) allowed")]
    [TerraformPropertyName("viewer_certificate")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionViewerCertificateBlock>>? ViewerCertificate { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CallerReference => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "caller_reference");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    [TerraformPropertyName("in_progress_validation_batches")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InProgressValidationBatches => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "in_progress_validation_batches");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformPropertyName("trusted_key_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrustedKeyGroups => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "trusted_key_groups");

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformPropertyName("trusted_signers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrustedSigners => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "trusted_signers");

}
