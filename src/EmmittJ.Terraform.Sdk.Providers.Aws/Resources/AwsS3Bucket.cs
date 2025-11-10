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
        get => GetProperty<List<TerraformProperty<string>>>("allowed_headers");
        set => WithProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public List<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public List<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExposeHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("expose_headers");
        set => WithProperty("expose_headers", value);
    }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_age_seconds");
        set => WithProperty("max_age_seconds", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public HashSet<TerraformProperty<string>>? Permissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permissions");
        set => WithProperty("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
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
        get => GetProperty<TerraformProperty<double>>("abort_incomplete_multipart_upload_days");
        set => WithProperty("abort_incomplete_multipart_upload_days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("target_bucket");
        set => WithProperty("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? TargetPrefix
    {
        get => GetProperty<TerraformProperty<string>>("target_prefix");
        set => WithProperty("target_prefix", value);
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
        get => GetProperty<TerraformProperty<string>>("object_lock_enabled");
        set => WithProperty("object_lock_enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => WithProperty("role", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? MfaDelete
    {
        get => GetProperty<TerraformProperty<bool>>("mfa_delete");
        set => WithProperty("mfa_delete", value);
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
        get => GetProperty<TerraformProperty<string>>("error_document");
        set => WithProperty("error_document", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformProperty<string>? IndexDocument
    {
        get => GetProperty<TerraformProperty<string>>("index_document");
        set => WithProperty("index_document", value);
    }

    /// <summary>
    /// The redirect_all_requests_to attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectAllRequestsTo
    {
        get => GetProperty<TerraformProperty<string>>("redirect_all_requests_to");
        set => WithProperty("redirect_all_requests_to", value);
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingRules
    {
        get => GetProperty<TerraformProperty<string>>("routing_rules");
        set => WithProperty("routing_rules", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("bucket_domain_name");
        this.DeclareOutput("bucket_region");
        this.DeclareOutput("bucket_regional_domain_name");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("website_domain");
        this.DeclareOutput("website_endpoint");
    }

    /// <summary>
    /// The acceleration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? AccelerationStatus
    {
        get => GetProperty<TerraformProperty<string>>("acceleration_status");
        set => this.WithProperty("acceleration_status", value);
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Acl
    {
        get => GetProperty<TerraformProperty<string>>("acl");
        set => this.WithProperty("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? BucketPrefix
    {
        get => GetProperty<TerraformProperty<string>>("bucket_prefix");
        set => this.WithProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The object_lock_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ObjectLockEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("object_lock_enabled");
        set => this.WithProperty("object_lock_enabled", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? RequestPayer
    {
        get => GetProperty<TerraformProperty<string>>("request_payer");
        set => this.WithProperty("request_payer", value);
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
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketCorsRuleBlock>? CorsRule
    {
        get => GetProperty<List<AwsS3BucketCorsRuleBlock>>("cors_rule");
        set => this.WithProperty("cors_rule", value);
    }

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AwsS3BucketGrantBlock>? Grant
    {
        get => GetProperty<HashSet<AwsS3BucketGrantBlock>>("grant");
        set => this.WithProperty("grant", value);
    }

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketLifecycleRuleBlock>? LifecycleRule
    {
        get => GetProperty<List<AwsS3BucketLifecycleRuleBlock>>("lifecycle_rule");
        set => this.WithProperty("lifecycle_rule", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketLoggingBlock>? Logging
    {
        get => GetProperty<List<AwsS3BucketLoggingBlock>>("logging");
        set => this.WithProperty("logging", value);
    }

    /// <summary>
    /// Block for object_lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectLockConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketObjectLockConfigurationBlock>? ObjectLockConfiguration
    {
        get => GetProperty<List<AwsS3BucketObjectLockConfigurationBlock>>("object_lock_configuration");
        set => this.WithProperty("object_lock_configuration", value);
    }

    /// <summary>
    /// Block for replication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketReplicationConfigurationBlock>? ReplicationConfiguration
    {
        get => GetProperty<List<AwsS3BucketReplicationConfigurationBlock>>("replication_configuration");
        set => this.WithProperty("replication_configuration", value);
    }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        get => GetProperty<List<AwsS3BucketServerSideEncryptionConfigurationBlock>>("server_side_encryption_configuration");
        set => this.WithProperty("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsS3BucketTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsS3BucketTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketVersioningBlock>? Versioning
    {
        get => GetProperty<List<AwsS3BucketVersioningBlock>>("versioning");
        set => this.WithProperty("versioning", value);
    }

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsS3BucketWebsiteBlock>? Website
    {
        get => GetProperty<List<AwsS3BucketWebsiteBlock>>("website");
        set => this.WithProperty("website", value);
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
