using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_error_response in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionCustomErrorResponseBlock
{
    /// <summary>
    /// The error_caching_min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("error_caching_min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ErrorCachingMinTtl { get; set; }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    [TerraformPropertyName("error_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ErrorCode { get; set; }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    [TerraformPropertyName("response_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ResponseCode { get; set; }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    [TerraformPropertyName("response_page_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResponsePagePath { get; set; }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlock
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AllowedMethods { get; set; }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("cache_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CachePolicyId { get; set; }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    [TerraformPropertyName("cached_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> CachedMethods { get; set; }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    [TerraformPropertyName("compress")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Compress { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DefaultTtl { get; set; } = default!;

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    [TerraformPropertyName("field_level_encryption_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FieldLevelEncryptionId { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxTtl { get; set; } = default!;

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinTtl { get; set; }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_request_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OriginRequestPolicyId { get; set; }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("realtime_log_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RealtimeLogConfigArn { get; set; }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("response_headers_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResponseHeadersPolicyId { get; set; }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    [TerraformPropertyName("smooth_streaming")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SmoothStreaming { get; set; }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    [TerraformPropertyName("target_origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetOriginId { get; set; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformPropertyName("trusted_key_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> TrustedKeyGroups { get; set; } = default!;

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformPropertyName("trusted_signers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> TrustedSigners { get; set; } = default!;

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    [TerraformPropertyName("viewer_protocol_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ViewerProtocolPolicy { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionLoggingConfigBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    [TerraformPropertyName("include_cookies")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeCookies { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Block type for ordered_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlock
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AllowedMethods { get; set; }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("cache_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CachePolicyId { get; set; }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    [TerraformPropertyName("cached_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> CachedMethods { get; set; }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    [TerraformPropertyName("compress")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Compress { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DefaultTtl { get; set; } = default!;

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    [TerraformPropertyName("field_level_encryption_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FieldLevelEncryptionId { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxTtl { get; set; } = default!;

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinTtl { get; set; }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_request_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OriginRequestPolicyId { get; set; }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    [TerraformPropertyName("path_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PathPattern { get; set; }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("realtime_log_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RealtimeLogConfigArn { get; set; }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("response_headers_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResponseHeadersPolicyId { get; set; }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    [TerraformPropertyName("smooth_streaming")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SmoothStreaming { get; set; }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    [TerraformPropertyName("target_origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetOriginId { get; set; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformPropertyName("trusted_key_groups")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TrustedKeyGroups { get; set; }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformPropertyName("trusted_signers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TrustedSigners { get; set; }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    [TerraformPropertyName("viewer_protocol_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ViewerProtocolPolicy { get; set; }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginBlock
{
    /// <summary>
    /// The connection_attempts attribute.
    /// </summary>
    [TerraformPropertyName("connection_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ConnectionAttempts { get; set; }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    [TerraformPropertyName("connection_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ConnectionTimeout { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_access_control_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OriginAccessControlId { get; set; }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    [TerraformPropertyName("origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OriginId { get; set; }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    [TerraformPropertyName("origin_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OriginPath { get; set; }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    [TerraformPropertyName("response_completion_timeout")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ResponseCompletionTimeout { get; set; } = default!;

}

/// <summary>
/// Block type for origin_group in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginGroupBlock
{
    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    [TerraformPropertyName("origin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OriginId { get; set; }

}

/// <summary>
/// Block type for restrictions in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionRestrictionsBlock
{
}

/// <summary>
/// Block type for viewer_certificate in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionViewerCertificateBlock
{
    /// <summary>
    /// The acm_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("acm_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcmCertificateArn { get; set; }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    [TerraformPropertyName("cloudfront_default_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CloudfrontDefaultCertificate { get; set; }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("iam_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamCertificateId { get; set; }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_protocol_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinimumProtocolVersion { get; set; }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    [TerraformPropertyName("ssl_support_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslSupportMethod { get; set; }

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
    public TerraformSet<string>? Aliases { get; set; }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    [TerraformPropertyName("anycast_ip_list_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AnycastIpListId { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("continuous_deployment_policy_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ContinuousDeploymentPolicyId { get; set; } = default!;

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    [TerraformPropertyName("default_root_object")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultRootObject { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    [TerraformPropertyName("http_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The is_ipv6_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_ipv6_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsIpv6Enabled { get; set; }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    [TerraformPropertyName("price_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PriceClass { get; set; }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    [TerraformPropertyName("retain_on_delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RetainOnDelete { get; set; }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    [TerraformPropertyName("staging")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Staging { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_deployment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForDeployment { get; set; }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    [TerraformPropertyName("web_acl_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebAclId { get; set; }

    /// <summary>
    /// Block for custom_error_response.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("custom_error_response")]
    public TerraformSet<TerraformBlock<AwsCloudfrontDistributionCustomErrorResponseBlock>>? CustomErrorResponse { get; set; }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    [TerraformPropertyName("default_cache_behavior")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionDefaultCacheBehaviorBlock>>? DefaultCacheBehavior { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// Block for ordered_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ordered_cache_behavior")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>>? OrderedCacheBehavior { get; set; }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [TerraformPropertyName("origin")]
    public TerraformSet<TerraformBlock<AwsCloudfrontDistributionOriginBlock>>? Origin { get; set; }

    /// <summary>
    /// Block for origin_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("origin_group")]
    public TerraformSet<TerraformBlock<AwsCloudfrontDistributionOriginGroupBlock>>? OriginGroup { get; set; }

    /// <summary>
    /// Block for restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Restrictions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    [TerraformPropertyName("restrictions")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionRestrictionsBlock>>? Restrictions { get; set; }

    /// <summary>
    /// Block for viewer_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerCertificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ViewerCertificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ViewerCertificate block(s) allowed")]
    [TerraformPropertyName("viewer_certificate")]
    public TerraformList<TerraformBlock<AwsCloudfrontDistributionViewerCertificateBlock>>? ViewerCertificate { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformPropertyName("caller_reference")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CallerReference => new TerraformReference(this, "caller_reference");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostedZoneId => new TerraformReference(this, "hosted_zone_id");

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    [TerraformPropertyName("in_progress_validation_batches")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> InProgressValidationBatches => new TerraformReference(this, "in_progress_validation_batches");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedTime => new TerraformReference(this, "last_modified_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformPropertyName("trusted_key_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrustedKeyGroups => new TerraformReference(this, "trusted_key_groups");

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformPropertyName("trusted_signers")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrustedSigners => new TerraformReference(this, "trusted_signers");

}
