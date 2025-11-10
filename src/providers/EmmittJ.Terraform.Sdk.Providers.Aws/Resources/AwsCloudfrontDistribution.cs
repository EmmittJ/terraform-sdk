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
        set => SetProperty("error_caching_min_ttl", value);
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ErrorCode is required")]
    public required TerraformProperty<double> ErrorCode
    {
        set => SetProperty("error_code", value);
    }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    public TerraformProperty<double>? ResponseCode
    {
        set => SetProperty("response_code", value);
    }

    /// <summary>
    /// The response_page_path attribute.
    /// </summary>
    public TerraformProperty<string>? ResponsePagePath
    {
        set => SetProperty("response_page_path", value);
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
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? CachePolicyId
    {
        set => SetProperty("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public HashSet<TerraformProperty<string>>? CachedMethods
    {
        set => SetProperty("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformProperty<bool>? Compress
    {
        set => SetProperty("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        set => SetProperty("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformProperty<string>? FieldLevelEncryptionId
    {
        set => SetProperty("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTtl
    {
        set => SetProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MinTtl
    {
        set => SetProperty("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? OriginRequestPolicyId
    {
        set => SetProperty("origin_request_policy_id", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RealtimeLogConfigArn
    {
        set => SetProperty("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseHeadersPolicyId
    {
        set => SetProperty("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformProperty<bool>? SmoothStreaming
    {
        set => SetProperty("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformProperty<string> TargetOriginId
    {
        set => SetProperty("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedKeyGroups
    {
        set => SetProperty("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedSigners
    {
        set => SetProperty("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformProperty<string> ViewerProtocolPolicy
    {
        set => SetProperty("viewer_protocol_policy", value);
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
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The include_cookies attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeCookies
    {
        set => SetProperty("include_cookies", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
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
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The cache_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? CachePolicyId
    {
        set => SetProperty("cache_policy_id", value);
    }

    /// <summary>
    /// The cached_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CachedMethods is required")]
    public HashSet<TerraformProperty<string>>? CachedMethods
    {
        set => SetProperty("cached_methods", value);
    }

    /// <summary>
    /// The compress attribute.
    /// </summary>
    public TerraformProperty<bool>? Compress
    {
        set => SetProperty("compress", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultTtl
    {
        set => SetProperty("default_ttl", value);
    }

    /// <summary>
    /// The field_level_encryption_id attribute.
    /// </summary>
    public TerraformProperty<string>? FieldLevelEncryptionId
    {
        set => SetProperty("field_level_encryption_id", value);
    }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTtl
    {
        set => SetProperty("max_ttl", value);
    }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MinTtl
    {
        set => SetProperty("min_ttl", value);
    }

    /// <summary>
    /// The origin_request_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? OriginRequestPolicyId
    {
        set => SetProperty("origin_request_policy_id", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformProperty<string> PathPattern
    {
        set => SetProperty("path_pattern", value);
    }

    /// <summary>
    /// The realtime_log_config_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RealtimeLogConfigArn
    {
        set => SetProperty("realtime_log_config_arn", value);
    }

    /// <summary>
    /// The response_headers_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseHeadersPolicyId
    {
        set => SetProperty("response_headers_policy_id", value);
    }

    /// <summary>
    /// The smooth_streaming attribute.
    /// </summary>
    public TerraformProperty<bool>? SmoothStreaming
    {
        set => SetProperty("smooth_streaming", value);
    }

    /// <summary>
    /// The target_origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetOriginId is required")]
    public required TerraformProperty<string> TargetOriginId
    {
        set => SetProperty("target_origin_id", value);
    }

    /// <summary>
    /// The trusted_key_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedKeyGroups
    {
        set => SetProperty("trusted_key_groups", value);
    }

    /// <summary>
    /// The trusted_signers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedSigners
    {
        set => SetProperty("trusted_signers", value);
    }

    /// <summary>
    /// The viewer_protocol_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerProtocolPolicy is required")]
    public required TerraformProperty<string> ViewerProtocolPolicy
    {
        set => SetProperty("viewer_protocol_policy", value);
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
        set => SetProperty("connection_attempts", value);
    }

    /// <summary>
    /// The connection_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ConnectionTimeout
    {
        set => SetProperty("connection_timeout", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The origin_access_control_id attribute.
    /// </summary>
    public TerraformProperty<string>? OriginAccessControlId
    {
        set => SetProperty("origin_access_control_id", value);
    }

    /// <summary>
    /// The origin_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginId is required")]
    public required TerraformProperty<string> OriginId
    {
        set => SetProperty("origin_id", value);
    }

    /// <summary>
    /// The origin_path attribute.
    /// </summary>
    public TerraformProperty<string>? OriginPath
    {
        set => SetProperty("origin_path", value);
    }

    /// <summary>
    /// The response_completion_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ResponseCompletionTimeout
    {
        set => SetProperty("response_completion_timeout", value);
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
        set => SetProperty("origin_id", value);
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
        set => SetProperty("acm_certificate_arn", value);
    }

    /// <summary>
    /// The cloudfront_default_certificate attribute.
    /// </summary>
    public TerraformProperty<bool>? CloudfrontDefaultCertificate
    {
        set => SetProperty("cloudfront_default_certificate", value);
    }

    /// <summary>
    /// The iam_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? IamCertificateId
    {
        set => SetProperty("iam_certificate_id", value);
    }

    /// <summary>
    /// The minimum_protocol_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumProtocolVersion
    {
        set => SetProperty("minimum_protocol_version", value);
    }

    /// <summary>
    /// The ssl_support_method attribute.
    /// </summary>
    public TerraformProperty<string>? SslSupportMethod
    {
        set => SetProperty("ssl_support_method", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_distribution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontDistribution : TerraformResource
{
    public AwsCloudfrontDistribution(string name) : base("aws_cloudfront_distribution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("caller_reference");
        SetOutput("domain_name");
        SetOutput("etag");
        SetOutput("hosted_zone_id");
        SetOutput("in_progress_validation_batches");
        SetOutput("last_modified_time");
        SetOutput("status");
        SetOutput("trusted_key_groups");
        SetOutput("trusted_signers");
        SetOutput("aliases");
        SetOutput("anycast_ip_list_id");
        SetOutput("comment");
        SetOutput("continuous_deployment_policy_id");
        SetOutput("default_root_object");
        SetOutput("enabled");
        SetOutput("http_version");
        SetOutput("id");
        SetOutput("is_ipv6_enabled");
        SetOutput("price_class");
        SetOutput("retain_on_delete");
        SetOutput("staging");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("wait_for_deployment");
        SetOutput("web_acl_id");
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Aliases
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("aliases");
        set => SetProperty("aliases", value);
    }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    public TerraformProperty<string> AnycastIpListId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("anycast_ip_list_id");
        set => SetProperty("anycast_ip_list_id", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The continuous_deployment_policy_id attribute.
    /// </summary>
    public TerraformProperty<string> ContinuousDeploymentPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("continuous_deployment_policy_id");
        set => SetProperty("continuous_deployment_policy_id", value);
    }

    /// <summary>
    /// The default_root_object attribute.
    /// </summary>
    public TerraformProperty<string> DefaultRootObject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_root_object");
        set => SetProperty("default_root_object", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The http_version attribute.
    /// </summary>
    public TerraformProperty<string> HttpVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_version");
        set => SetProperty("http_version", value);
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
    /// The is_ipv6_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IsIpv6Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_ipv6_enabled");
        set => SetProperty("is_ipv6_enabled", value);
    }

    /// <summary>
    /// The price_class attribute.
    /// </summary>
    public TerraformProperty<string> PriceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("price_class");
        set => SetProperty("price_class", value);
    }

    /// <summary>
    /// The retain_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool> RetainOnDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("retain_on_delete");
        set => SetProperty("retain_on_delete", value);
    }

    /// <summary>
    /// The staging attribute.
    /// </summary>
    public TerraformProperty<bool> Staging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("staging");
        set => SetProperty("staging", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The wait_for_deployment attribute.
    /// </summary>
    public TerraformProperty<bool> WaitForDeployment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_deployment");
        set => SetProperty("wait_for_deployment", value);
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public TerraformProperty<string> WebAclId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_acl_id");
        set => SetProperty("web_acl_id", value);
    }

    /// <summary>
    /// Block for custom_error_response.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudfrontDistributionCustomErrorResponseBlock>? CustomErrorResponse
    {
        set => SetProperty("custom_error_response", value);
    }

    /// <summary>
    /// Block for default_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultCacheBehavior is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultCacheBehavior block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultCacheBehavior block(s) allowed")]
    public List<AwsCloudfrontDistributionDefaultCacheBehaviorBlock>? DefaultCacheBehavior
    {
        set => SetProperty("default_cache_behavior", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<AwsCloudfrontDistributionLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
    }

    /// <summary>
    /// Block for ordered_cache_behavior.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudfrontDistributionOrderedCacheBehaviorBlock>? OrderedCacheBehavior
    {
        set => SetProperty("ordered_cache_behavior", value);
    }

    /// <summary>
    /// Block for origin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Origin block(s) required")]
    public HashSet<AwsCloudfrontDistributionOriginBlock>? Origin
    {
        set => SetProperty("origin", value);
    }

    /// <summary>
    /// Block for origin_group.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudfrontDistributionOriginGroupBlock>? OriginGroup
    {
        set => SetProperty("origin_group", value);
    }

    /// <summary>
    /// Block for restrictions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Restrictions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    public List<AwsCloudfrontDistributionRestrictionsBlock>? Restrictions
    {
        set => SetProperty("restrictions", value);
    }

    /// <summary>
    /// Block for viewer_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ViewerCertificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ViewerCertificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ViewerCertificate block(s) allowed")]
    public List<AwsCloudfrontDistributionViewerCertificateBlock>? ViewerCertificate
    {
        set => SetProperty("viewer_certificate", value);
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
