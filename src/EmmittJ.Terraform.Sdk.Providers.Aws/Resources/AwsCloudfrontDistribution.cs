using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_error_response in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionCustomErrorResponseBlock : TerraformBlock
{
    /// <summary>
    /// The error_caching_min_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? ErrorCachingMinTtl
    {
        get => GetProperty<TerraformProperty<double>>("error_caching_min_ttl");
        set => WithProperty("error_caching_min_ttl", value);
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    public required TerraformProperty<double> ErrorCode
    {
        get => GetProperty<TerraformProperty<double>>("error_code");
        set => WithProperty("error_code", value);
    }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    public TerraformProperty<double>? ResponseCode
    {
        get => GetProperty<TerraformProperty<double>>("response_code");
        set => WithProperty("response_code", value);
    }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    public TerraformProperty<string>? ResponsePagePath
    {
        get => GetProperty<TerraformProperty<string>>("response_page_path");
        set => WithProperty("response_page_path", value);
    }

}

/// <summary>
/// Block type for default_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionDefaultCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public HashSet<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? CachePolicyId
    {
        get => GetProperty<TerraformProperty<string>>("cache_policy_id");
        set => WithProperty("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public HashSet<TerraformProperty<string>>? CachedMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cached_methods");
        set => WithProperty("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformProperty<bool>? Compress
    {
        get => GetProperty<TerraformProperty<bool>>("compress");
        set => WithProperty("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl");
        set => WithProperty("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformProperty<string>? FieldLevelEncryptionId
    {
        get => GetProperty<TerraformProperty<string>>("field_level_encryption_id");
        set => WithProperty("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTtl
    {
        get => GetProperty<TerraformProperty<double>>("max_ttl");
        set => WithProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MinTtl
    {
        get => GetProperty<TerraformProperty<double>>("min_ttl");
        set => WithProperty("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? OriginRequestPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("origin_request_policy_id");
        set => WithProperty("origin_request_policy_id", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RealtimeLogConfigArn
    {
        get => GetProperty<TerraformProperty<string>>("realtime_log_config_arn");
        set => WithProperty("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseHeadersPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("response_headers_policy_id");
        set => WithProperty("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformProperty<bool>? SmoothStreaming
    {
        get => GetProperty<TerraformProperty<bool>>("smooth_streaming");
        set => WithProperty("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformProperty<string> TargetOriginId
    {
        get => GetProperty<TerraformProperty<string>>("target_origin_id");
        set => WithProperty("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedKeyGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_key_groups");
        set => WithProperty("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedSigners
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_signers");
        set => WithProperty("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformProperty<string> ViewerProtocolPolicy
    {
        get => GetProperty<TerraformProperty<string>>("viewer_protocol_policy");
        set => WithProperty("viewer_protocol_policy", value);
    }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeCookies
    {
        get => GetProperty<TerraformProperty<bool>>("include_cookies");
        set => WithProperty("include_cookies", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
    }

}

/// <summary>
/// Block type for ordered_cache_behavior in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionOrderedCacheBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public HashSet<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? CachePolicyId
    {
        get => GetProperty<TerraformProperty<string>>("cache_policy_id");
        set => WithProperty("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public HashSet<TerraformProperty<string>>? CachedMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cached_methods");
        set => WithProperty("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformProperty<bool>? Compress
    {
        get => GetProperty<TerraformProperty<bool>>("compress");
        set => WithProperty("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<double>>("default_ttl");
        set => WithProperty("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformProperty<string>? FieldLevelEncryptionId
    {
        get => GetProperty<TerraformProperty<string>>("field_level_encryption_id");
        set => WithProperty("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTtl
    {
        get => GetProperty<TerraformProperty<double>>("max_ttl");
        set => WithProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MinTtl
    {
        get => GetProperty<TerraformProperty<double>>("min_ttl");
        set => WithProperty("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? OriginRequestPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("origin_request_policy_id");
        set => WithProperty("origin_request_policy_id", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformProperty<string> PathPattern
    {
        get => GetProperty<TerraformProperty<string>>("path_pattern");
        set => WithProperty("path_pattern", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RealtimeLogConfigArn
    {
        get => GetProperty<TerraformProperty<string>>("realtime_log_config_arn");
        set => WithProperty("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseHeadersPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("response_headers_policy_id");
        set => WithProperty("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformProperty<bool>? SmoothStreaming
    {
        get => GetProperty<TerraformProperty<bool>>("smooth_streaming");
        set => WithProperty("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformProperty<string> TargetOriginId
    {
        get => GetProperty<TerraformProperty<string>>("target_origin_id");
        set => WithProperty("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedKeyGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_key_groups");
        set => WithProperty("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedSigners
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_signers");
        set => WithProperty("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformProperty<string> ViewerProtocolPolicy
    {
        get => GetProperty<TerraformProperty<string>>("viewer_protocol_policy");
        set => WithProperty("viewer_protocol_policy", value);
    }

}

/// <summary>
/// Block type for origin in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginBlock : TerraformBlock
{
    /// <summary>
    /// The connection_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? ConnectionAttempts
    {
        get => GetProperty<TerraformProperty<double>>("connection_attempts");
        set => WithProperty("connection_attempts", value);
    }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ConnectionTimeout
    {
        get => GetProperty<TerraformProperty<double>>("connection_timeout");
        set => WithProperty("connection_timeout", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    public TerraformProperty<string>? OriginAccessControlId
    {
        get => GetProperty<TerraformProperty<string>>("origin_access_control_id");
        set => WithProperty("origin_access_control_id", value);
    }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformProperty<string> OriginId
    {
        get => GetProperty<TerraformProperty<string>>("origin_id");
        set => WithProperty("origin_id", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformProperty<string>? OriginPath
    {
        get => GetProperty<TerraformProperty<string>>("origin_path");
        set => WithProperty("origin_path", value);
    }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ResponseCompletionTimeout
    {
        get => GetProperty<TerraformProperty<double>>("response_completion_timeout");
        set => WithProperty("response_completion_timeout", value);
    }

}

/// <summary>
/// Block type for origin_group in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontDistributionOriginGroupBlock : TerraformBlock
{
    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformProperty<string> OriginId
    {
        get => GetProperty<TerraformProperty<string>>("origin_id");
        set => WithProperty("origin_id", value);
    }

}

/// <summary>
/// Block type for restrictions in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionRestrictionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for viewer_certificate in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontDistributionViewerCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The acm_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AcmCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("acm_certificate_arn");
        set => WithProperty("acm_certificate_arn", value);
    }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? CloudfrontDefaultCertificate
    {
        get => GetProperty<TerraformProperty<bool>>("cloudfront_default_certificate");
        set => WithProperty("cloudfront_default_certificate", value);
    }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? IamCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("iam_certificate_id");
        set => WithProperty("iam_certificate_id", value);
    }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumProtocolVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_protocol_version");
        set => WithProperty("minimum_protocol_version", value);
    }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    public TerraformProperty<string>? SslSupportMethod
    {
        get => GetProperty<TerraformProperty<string>>("ssl_support_method");
        set => WithProperty("ssl_support_method", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_distribution resource.
/// </summary>
public class AwsCloudfrontDistribution : TerraformResource
{
    public AwsCloudfrontDistribution(string name) : base("aws_cloudfront_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("caller_reference");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("etag");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("in_progress_validation_batches");
        this.DeclareOutput("last_modified_time");
        this.DeclareOutput("status");
        this.DeclareOutput("trusted_key_groups");
        this.DeclareOutput("trusted_signers");
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Aliases
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("aliases");
        set => this.WithProperty("aliases", value);
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformProperty<string>? AnycastIpListId
    {
        get => GetProperty<TerraformProperty<string>>("anycast_ip_list_id");
        set => this.WithProperty("anycast_ip_list_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
    }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContinuousDeploymentPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("continuous_deployment_policy_id");
        set => this.WithProperty("continuous_deployment_policy_id", value);
    }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRootObject
    {
        get => GetProperty<TerraformProperty<string>>("default_root_object");
        set => this.WithProperty("default_root_object", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    public TerraformProperty<string>? HttpVersion
    {
        get => GetProperty<TerraformProperty<string>>("http_version");
        set => this.WithProperty("http_version", value);
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
    /// The is_ipv6_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IsIpv6Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_ipv6_enabled");
        set => this.WithProperty("is_ipv6_enabled", value);
    }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    public TerraformProperty<string>? PriceClass
    {
        get => GetProperty<TerraformProperty<string>>("price_class");
        set => this.WithProperty("price_class", value);
    }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainOnDelete
    {
        get => GetProperty<TerraformProperty<bool>>("retain_on_delete");
        set => this.WithProperty("retain_on_delete", value);
    }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    public TerraformProperty<bool>? Staging
    {
        get => GetProperty<TerraformProperty<bool>>("staging");
        set => this.WithProperty("staging", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForDeployment
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_deployment");
        set => this.WithProperty("wait_for_deployment", value);
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebAclId
    {
        get => GetProperty<TerraformProperty<string>>("web_acl_id");
        set => this.WithProperty("web_acl_id", value);
    }

    /// <summary>
    /// Block for custom_error_response.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudfrontDistributionCustomErrorResponseBlock>? CustomErrorResponse
    {
        get => GetProperty<HashSet<AwsCloudfrontDistributionCustomErrorResponseBlock>>("custom_error_response");
        set => this.WithProperty("custom_error_response", value);
    }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    public List<AwsCloudfrontDistributionDefaultCacheBehaviorBlock>? DefaultCacheBehavior
    {
        get => GetProperty<List<AwsCloudfrontDistributionDefaultCacheBehaviorBlock>>("default_cache_behavior");
        set => this.WithProperty("default_cache_behavior", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<AwsCloudfrontDistributionLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<AwsCloudfrontDistributionLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// Block for ordered_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>? OrderedCacheBehavior
    {
        get => GetProperty<List<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>>("ordered_cache_behavior");
        set => this.WithProperty("ordered_cache_behavior", value);
    }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    public HashSet<AwsCloudfrontDistributionOriginBlock>? Origin
    {
        get => GetProperty<HashSet<AwsCloudfrontDistributionOriginBlock>>("origin");
        set => this.WithProperty("origin", value);
    }

    /// <summary>
    /// Block for origin_group.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudfrontDistributionOriginGroupBlock>? OriginGroup
    {
        get => GetProperty<HashSet<AwsCloudfrontDistributionOriginGroupBlock>>("origin_group");
        set => this.WithProperty("origin_group", value);
    }

    /// <summary>
    /// Block for restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Restrictions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    public List<AwsCloudfrontDistributionRestrictionsBlock>? Restrictions
    {
        get => GetProperty<List<AwsCloudfrontDistributionRestrictionsBlock>>("restrictions");
        set => this.WithProperty("restrictions", value);
    }

    /// <summary>
    /// Block for viewer_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ViewerCertificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ViewerCertificate block(s) allowed")]
    public List<AwsCloudfrontDistributionViewerCertificateBlock>? ViewerCertificate
    {
        get => GetProperty<List<AwsCloudfrontDistributionViewerCertificateBlock>>("viewer_certificate");
        set => this.WithProperty("viewer_certificate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformExpression CallerReference => this["caller_reference"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    public TerraformExpression InProgressValidationBatches => this["in_progress_validation_batches"];

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public TerraformExpression TrustedKeyGroups => this["trusted_key_groups"];

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public TerraformExpression TrustedSigners => this["trusted_signers"];

}
