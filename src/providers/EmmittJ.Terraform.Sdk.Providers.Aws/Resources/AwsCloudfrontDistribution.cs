using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_error_response in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudfrontDistributionCustomErrorResponseBlock() : TerraformBlock("custom_error_response")
{
    /// <summary>
    /// The error_caching_min_ttl attribute.
    /// </summary>
    [TerraformProperty("error_caching_min_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ErrorCachingMinTtl { get; set; }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    [TerraformProperty("error_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ErrorCode { get; set; }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    [TerraformProperty("response_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ResponseCode { get; set; }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    [TerraformProperty("response_page_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponsePagePath { get; set; }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontDistributionDefaultCacheBehaviorBlock() : TerraformBlock("default_cache_behavior")
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedMethods { get; set; }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    [TerraformProperty("cache_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CachePolicyId { get; set; }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    [TerraformProperty("cached_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> CachedMethods { get; set; }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    [TerraformProperty("compress")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Compress { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DefaultTtl { get; set; }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    [TerraformProperty("field_level_encryption_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FieldLevelEncryptionId { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformProperty("max_ttl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxTtl { get; set; }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformProperty("min_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinTtl { get; set; }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    [TerraformProperty("origin_request_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginRequestPolicyId { get; set; }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    [TerraformProperty("realtime_log_config_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RealtimeLogConfigArn { get; set; }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    [TerraformProperty("response_headers_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseHeadersPolicyId { get; set; }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    [TerraformProperty("smooth_streaming")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmoothStreaming { get; set; }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    [TerraformProperty("target_origin_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetOriginId { get; set; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformProperty("trusted_key_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> TrustedKeyGroups { get; set; }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformProperty("trusted_signers")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> TrustedSigners { get; set; }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    [TerraformProperty("viewer_protocol_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ViewerProtocolPolicy { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontDistributionLoggingConfigBlock() : TerraformBlock("logging_config")
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    [TerraformProperty("include_cookies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeCookies { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Block type for ordered_cache_behavior in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontDistributionOrderedCacheBehaviorBlock() : TerraformBlock("ordered_cache_behavior")
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedMethods { get; set; }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    [TerraformProperty("cache_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CachePolicyId { get; set; }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    [TerraformProperty("cached_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> CachedMethods { get; set; }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    [TerraformProperty("compress")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Compress { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DefaultTtl { get; set; }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    [TerraformProperty("field_level_encryption_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FieldLevelEncryptionId { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformProperty("max_ttl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxTtl { get; set; }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformProperty("min_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinTtl { get; set; }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    [TerraformProperty("origin_request_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginRequestPolicyId { get; set; }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    [TerraformProperty("path_pattern")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PathPattern { get; set; }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    [TerraformProperty("realtime_log_config_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RealtimeLogConfigArn { get; set; }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    [TerraformProperty("response_headers_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseHeadersPolicyId { get; set; }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    [TerraformProperty("smooth_streaming")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmoothStreaming { get; set; }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    [TerraformProperty("target_origin_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetOriginId { get; set; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformProperty("trusted_key_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TrustedKeyGroups { get; set; }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformProperty("trusted_signers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TrustedSigners { get; set; }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    [TerraformProperty("viewer_protocol_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ViewerProtocolPolicy { get; set; }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudfrontDistributionOriginBlock() : TerraformBlock("origin")
{
    /// <summary>
    /// The connection_attempts attribute.
    /// </summary>
    [TerraformProperty("connection_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ConnectionAttempts { get; set; }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    [TerraformProperty("connection_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ConnectionTimeout { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    [TerraformProperty("origin_access_control_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginAccessControlId { get; set; }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    [TerraformProperty("origin_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OriginId { get; set; }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    [TerraformProperty("origin_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginPath { get; set; }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    [TerraformProperty("response_completion_timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ResponseCompletionTimeout { get; set; }

}

/// <summary>
/// Block type for origin_group in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudfrontDistributionOriginGroupBlock() : TerraformBlock("origin_group")
{
    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    [TerraformProperty("origin_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OriginId { get; set; }

}

/// <summary>
/// Block type for restrictions in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontDistributionRestrictionsBlock() : TerraformBlock("restrictions")
{
}

/// <summary>
/// Block type for viewer_certificate in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontDistributionViewerCertificateBlock() : TerraformBlock("viewer_certificate")
{
    /// <summary>
    /// The acm_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("acm_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcmCertificateArn { get; set; }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    [TerraformProperty("cloudfront_default_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CloudfrontDefaultCertificate { get; set; }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    [TerraformProperty("iam_certificate_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamCertificateId { get; set; }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    [TerraformProperty("minimum_protocol_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumProtocolVersion { get; set; }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    [TerraformProperty("ssl_support_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslSupportMethod { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_distribution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontDistribution : TerraformResource
{
    public AwsCloudfrontDistribution(string name) : base("aws_cloudfront_distribution", name)
    {
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformProperty("aliases")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Aliases { get; set; }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    [TerraformProperty("anycast_ip_list_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AnycastIpListId { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    [TerraformProperty("continuous_deployment_policy_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContinuousDeploymentPolicyId { get; set; }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    [TerraformProperty("default_root_object")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultRootObject { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    [TerraformProperty("http_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The is_ipv6_enabled attribute.
    /// </summary>
    [TerraformProperty("is_ipv6_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsIpv6Enabled { get; set; }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    [TerraformProperty("price_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PriceClass { get; set; }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    [TerraformProperty("retain_on_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetainOnDelete { get; set; }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    [TerraformProperty("staging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Staging { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    [TerraformProperty("wait_for_deployment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForDeployment { get; set; }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    [TerraformProperty("web_acl_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebAclId { get; set; }

    /// <summary>
    /// Block for custom_error_response.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("custom_error_response")]
    public TerraformSet<AwsCloudfrontDistributionCustomErrorResponseBlock> CustomErrorResponse { get; set; } = new();

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    [TerraformProperty("default_cache_behavior")]
    public required TerraformList<AwsCloudfrontDistributionDefaultCacheBehaviorBlock> DefaultCacheBehavior { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public TerraformList<AwsCloudfrontDistributionLoggingConfigBlock> LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for ordered_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ordered_cache_behavior")]
    public TerraformList<AwsCloudfrontDistributionOrderedCacheBehaviorBlock> OrderedCacheBehavior { get; set; } = new();

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    [TerraformProperty("origin")]
    public required TerraformSet<AwsCloudfrontDistributionOriginBlock> Origin { get; set; } = new();

    /// <summary>
    /// Block for origin_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("origin_group")]
    public TerraformSet<AwsCloudfrontDistributionOriginGroupBlock> OriginGroup { get; set; } = new();

    /// <summary>
    /// Block for restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Restrictions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    [TerraformProperty("restrictions")]
    public required TerraformList<AwsCloudfrontDistributionRestrictionsBlock> Restrictions { get; set; } = new();

    /// <summary>
    /// Block for viewer_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerCertificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ViewerCertificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ViewerCertificate block(s) allowed")]
    [TerraformProperty("viewer_certificate")]
    public required TerraformList<AwsCloudfrontDistributionViewerCertificateBlock> ViewerCertificate { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformProperty("caller_reference")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CallerReference { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    [TerraformProperty("in_progress_validation_batches")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> InProgressValidationBatches { get; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTime { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    [TerraformProperty("trusted_key_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TrustedKeyGroups { get; }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    [TerraformProperty("trusted_signers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TrustedSigners { get; }

}
