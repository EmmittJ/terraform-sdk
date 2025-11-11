using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketCorsRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformProperty("allowed_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformProperty("allowed_origins")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    [TerraformProperty("expose_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    [TerraformProperty("max_age_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAgeSeconds { get; set; }

}

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketGrantBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformProperty("permissions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Permissions { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketLifecycleRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The abort_incomplete_multipart_upload_days attribute.
    /// </summary>
    [TerraformProperty("abort_incomplete_multipart_upload_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AbortIncompleteMultipartUploadDays { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketLoggingBlock : TerraformBlockBase
{
    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    [TerraformProperty("target_bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetBucket { get; set; }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [TerraformProperty("target_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetPrefix { get; set; }

}

/// <summary>
/// Block type for object_lock_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketObjectLockConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("object_lock_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectLockEnabled { get; set; }

}

/// <summary>
/// Block type for replication_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketReplicationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketServerSideEncryptionConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsS3BucketTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketVersioningBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    [TerraformProperty("mfa_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MfaDelete { get; set; }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsS3BucketWebsiteBlock : TerraformBlockBase
{
    /// <summary>
    /// The error_document attribute.
    /// </summary>
    [TerraformProperty("error_document")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ErrorDocument { get; set; }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    [TerraformProperty("index_document")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndexDocument { get; set; }

    /// <summary>
    /// The redirect_all_requests_to attribute.
    /// </summary>
    [TerraformProperty("redirect_all_requests_to")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedirectAllRequestsTo { get; set; }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformProperty("routing_rules")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoutingRules { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3Bucket : TerraformResource
{
    public AwsS3Bucket(string name) : base("aws_s3_bucket", name)
    {
    }

    /// <summary>
    /// The acceleration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("acceleration_status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccelerationStatus { get; set; }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("acl")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Acl { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformProperty("bucket")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformProperty("bucket_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BucketPrefix { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    [TerraformProperty("object_lock_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ObjectLockEnabled { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("request_payer")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RequestPayer { get; set; }

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
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("cors_rule")]
    public partial TerraformList<TerraformBlock<AwsS3BucketCorsRuleBlock>>? CorsRule { get; set; }

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("grant")]
    public partial TerraformSet<TerraformBlock<AwsS3BucketGrantBlock>>? Grant { get; set; }

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("lifecycle_rule")]
    public partial TerraformList<TerraformBlock<AwsS3BucketLifecycleRuleBlock>>? LifecycleRule { get; set; }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("logging")]
    public partial TerraformList<TerraformBlock<AwsS3BucketLoggingBlock>>? Logging { get; set; }

    /// <summary>
    /// Block for object_lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectLockConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("object_lock_configuration")]
    public partial TerraformList<TerraformBlock<AwsS3BucketObjectLockConfigurationBlock>>? ObjectLockConfiguration { get; set; }

    /// <summary>
    /// Block for replication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("replication_configuration")]
    public partial TerraformList<TerraformBlock<AwsS3BucketReplicationConfigurationBlock>>? ReplicationConfiguration { get; set; }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("server_side_encryption_configuration")]
    public partial TerraformList<TerraformBlock<AwsS3BucketServerSideEncryptionConfigurationBlock>>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsS3BucketTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("versioning")]
    public partial TerraformList<TerraformBlock<AwsS3BucketVersioningBlock>>? Versioning { get; set; }

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("website")]
    public partial TerraformList<TerraformBlock<AwsS3BucketWebsiteBlock>>? Website { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    [TerraformProperty("bucket_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BucketDomainName { get; }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformProperty("bucket_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BucketRegion { get; }

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    [TerraformProperty("bucket_regional_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BucketRegionalDomainName { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [TerraformProperty("website_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebsiteDomain { get; }

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [TerraformProperty("website_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebsiteEndpoint { get; }

}
