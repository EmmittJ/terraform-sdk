using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedHeaders
    {
        set => SetProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public List<TerraformProperty<string>>? AllowedMethods
    {
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public List<TerraformProperty<string>>? AllowedOrigins
    {
        set => SetProperty("allowed_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExposeHeaders
    {
        set => SetProperty("expose_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeSeconds
    {
        set => SetProperty("max_age_seconds", value);
    }

}

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketGrantBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public HashSet<TerraformProperty<string>>? Permissions
    {
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketLifecycleRuleBlock : TerraformBlock
{
    /// <summary>
    /// The abort_incomplete_multipart_upload_days attribute.
    /// </summary>
    public TerraformProperty<double>? AbortIncompleteMultipartUploadDays
    {
        set => SetProperty("abort_incomplete_multipart_upload_days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketLoggingBlock : TerraformBlock
{
    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    public required TerraformProperty<string> TargetBucket
    {
        set => SetProperty("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? TargetPrefix
    {
        set => SetProperty("target_prefix", value);
    }

}

/// <summary>
/// Block type for object_lock_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketObjectLockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ObjectLockEnabled
    {
        set => SetProperty("object_lock_enabled", value);
    }

}

/// <summary>
/// Block type for replication_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketReplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        set => SetProperty("role", value);
    }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketServerSideEncryptionConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsS3BucketTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketVersioningBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? MfaDelete
    {
        set => SetProperty("mfa_delete", value);
    }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketWebsiteBlock : TerraformBlock
{
    /// <summary>
    /// The error_document attribute.
    /// </summary>
    public TerraformProperty<string>? ErrorDocument
    {
        set => SetProperty("error_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformProperty<string>? IndexDocument
    {
        set => SetProperty("index_document", value);
    }

    /// <summary>
    /// The redirect_all_requests_to attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectAllRequestsTo
    {
        set => SetProperty("redirect_all_requests_to", value);
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingRules
    {
        set => SetProperty("routing_rules", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3Bucket : TerraformResource
{
    public AwsS3Bucket(string name) : base("aws_s3_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("bucket_domain_name");
        SetOutput("bucket_region");
        SetOutput("bucket_regional_domain_name");
        SetOutput("hosted_zone_id");
        SetOutput("website_domain");
        SetOutput("website_endpoint");
        SetOutput("acceleration_status");
        SetOutput("acl");
        SetOutput("bucket");
        SetOutput("bucket_prefix");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("object_lock_enabled");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("request_payer");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The acceleration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> AccelerationStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("acceleration_status");
        set => SetProperty("acceleration_status", value);
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Acl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("acl");
        set => SetProperty("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string> BucketPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_prefix");
        set => SetProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The object_lock_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ObjectLockEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("object_lock_enabled");
        set => SetProperty("object_lock_enabled", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> RequestPayer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_payer");
        set => SetProperty("request_payer", value);
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
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketCorsRuleBlock>? CorsRule
    {
        set => SetProperty("cors_rule", value);
    }

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AwsS3BucketGrantBlock>? Grant
    {
        set => SetProperty("grant", value);
    }

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketLifecycleRuleBlock>? LifecycleRule
    {
        set => SetProperty("lifecycle_rule", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketLoggingBlock>? Logging
    {
        set => SetProperty("logging", value);
    }

    /// <summary>
    /// Block for object_lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectLockConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketObjectLockConfigurationBlock>? ObjectLockConfiguration
    {
        set => SetProperty("object_lock_configuration", value);
    }

    /// <summary>
    /// Block for replication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketReplicationConfigurationBlock>? ReplicationConfiguration
    {
        set => SetProperty("replication_configuration", value);
    }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        set => SetProperty("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsS3BucketTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketVersioningBlock>? Versioning
    {
        set => SetProperty("versioning", value);
    }

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketWebsiteBlock>? Website
    {
        set => SetProperty("website", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    public TerraformExpression BucketDomainName => this["bucket_domain_name"];

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformExpression BucketRegion => this["bucket_region"];

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    public TerraformExpression BucketRegionalDomainName => this["bucket_regional_domain_name"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformExpression WebsiteDomain => this["website_domain"];

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformExpression WebsiteEndpoint => this["website_endpoint"];

}
