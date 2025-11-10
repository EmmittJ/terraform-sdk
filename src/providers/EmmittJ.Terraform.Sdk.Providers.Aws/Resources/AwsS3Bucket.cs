using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketCorsRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformPropertyName("allowed_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformPropertyName("allowed_origins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedOrigins { get; set; }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    [TerraformPropertyName("expose_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExposeHeaders { get; set; }

    /// <summary>
    /// The max_age_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_age_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxAgeSeconds { get; set; }

}

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketGrantBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformPropertyName("permissions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Permissions { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uri { get; set; }

}

/// <summary>
/// Block type for lifecycle_rule in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketLifecycleRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The abort_incomplete_multipart_upload_days attribute.
    /// </summary>
    [TerraformPropertyName("abort_incomplete_multipart_upload_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AbortIncompleteMultipartUploadDays { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketLoggingBlock : ITerraformBlock
{
    /// <summary>
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    [TerraformPropertyName("target_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetBucket { get; set; }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [TerraformPropertyName("target_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetPrefix { get; set; }

}

/// <summary>
/// Block type for object_lock_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketObjectLockConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("object_lock_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectLockEnabled { get; set; }

}

/// <summary>
/// Block type for replication_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketReplicationConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Role { get; set; }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketServerSideEncryptionConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsS3BucketTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for versioning in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketVersioningBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    [TerraformPropertyName("mfa_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MfaDelete { get; set; }

}

/// <summary>
/// Block type for website in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsS3BucketWebsiteBlock : ITerraformBlock
{
    /// <summary>
    /// The error_document attribute.
    /// </summary>
    [TerraformPropertyName("error_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ErrorDocument { get; set; }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    [TerraformPropertyName("index_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IndexDocument { get; set; }

    /// <summary>
    /// The redirect_all_requests_to attribute.
    /// </summary>
    [TerraformPropertyName("redirect_all_requests_to")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RedirectAllRequestsTo { get; set; }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformPropertyName("routing_rules")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoutingRules { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3Bucket : TerraformResource
{
    public AwsS3Bucket(string name) : base("aws_s3_bucket", name)
    {
    }

    /// <summary>
    /// The acceleration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("acceleration_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccelerationStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "acceleration_status");

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("acl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Acl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "acl");

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Bucket { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket");

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformPropertyName("bucket_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BucketPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_prefix");

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ObjectLockEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "object_lock_enabled");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Policy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("request_payer")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RequestPayer { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "request_payer");

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
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("cors_rule")]
    public TerraformList<TerraformBlock<AwsS3BucketCorsRuleBlock>>? CorsRule { get; set; } = new();

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("grant")]
    public TerraformSet<TerraformBlock<AwsS3BucketGrantBlock>>? Grant { get; set; } = new();

    /// <summary>
    /// Block for lifecycle_rule.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("lifecycle_rule")]
    public TerraformList<TerraformBlock<AwsS3BucketLifecycleRuleBlock>>? LifecycleRule { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("logging")]
    public TerraformList<TerraformBlock<AwsS3BucketLoggingBlock>>? Logging { get; set; } = new();

    /// <summary>
    /// Block for object_lock_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectLockConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("object_lock_configuration")]
    public TerraformList<TerraformBlock<AwsS3BucketObjectLockConfigurationBlock>>? ObjectLockConfiguration { get; set; } = new();

    /// <summary>
    /// Block for replication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("replication_configuration")]
    public TerraformList<TerraformBlock<AwsS3BucketReplicationConfigurationBlock>>? ReplicationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("server_side_encryption_configuration")]
    public TerraformList<TerraformBlock<AwsS3BucketServerSideEncryptionConfigurationBlock>>? ServerSideEncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsS3BucketTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for versioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Versioning block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("versioning")]
    public TerraformList<TerraformBlock<AwsS3BucketVersioningBlock>>? Versioning { get; set; } = new();

    /// <summary>
    /// Block for website.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Website block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("website")]
    public TerraformList<TerraformBlock<AwsS3BucketWebsiteBlock>>? Website { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_domain_name");

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformPropertyName("bucket_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_region");

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("bucket_regional_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketRegionalDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_regional_domain_name");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    [TerraformPropertyName("website_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebsiteDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_domain");

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("website_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebsiteEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_endpoint");

}
