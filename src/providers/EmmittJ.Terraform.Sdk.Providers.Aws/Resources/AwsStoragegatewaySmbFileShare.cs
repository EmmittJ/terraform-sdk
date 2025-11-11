using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewaySmbFileShareCacheAttributesBlock
{
    /// <summary>
    /// The cache_stale_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("cache_stale_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CacheStaleTimeoutInSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewaySmbFileShareTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_storagegateway_smb_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsStoragegatewaySmbFileShare : TerraformResource
{
    public AwsStoragegatewaySmbFileShare(string name) : base("aws_storagegateway_smb_file_share", name)
    {
    }

    /// <summary>
    /// The access_based_enumeration attribute.
    /// </summary>
    [TerraformPropertyName("access_based_enumeration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AccessBasedEnumeration { get; set; }

    /// <summary>
    /// The admin_user_list attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_list")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AdminUserList { get; set; }

    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    [TerraformPropertyName("audit_destination_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuditDestinationArn { get; set; }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformPropertyName("authentication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Authentication { get; set; }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformPropertyName("bucket_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketRegion { get; set; }

    /// <summary>
    /// The case_sensitivity attribute.
    /// </summary>
    [TerraformPropertyName("case_sensitivity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CaseSensitivity { get; set; }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    [TerraformPropertyName("default_storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultStorageClass { get; set; }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    [TerraformPropertyName("file_share_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FileShareName { get; set; } = default!;

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformPropertyName("gateway_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GatewayArn { get; set; }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    [TerraformPropertyName("guess_mime_type_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GuessMimeTypeEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The invalid_user_list attribute.
    /// </summary>
    [TerraformPropertyName("invalid_user_list")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? InvalidUserList { get; set; }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("kms_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    [TerraformPropertyName("location_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LocationArn { get; set; }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    [TerraformPropertyName("notification_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotificationPolicy { get; set; }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    [TerraformPropertyName("object_acl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectAcl { get; set; }

    /// <summary>
    /// The oplocks_enabled attribute.
    /// </summary>
    [TerraformPropertyName("oplocks_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> OplocksEnabled { get; set; } = default!;

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformPropertyName("read_only")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReadOnly { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    [TerraformPropertyName("requester_pays")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequesterPays { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The smb_acl_enabled attribute.
    /// </summary>
    [TerraformPropertyName("smb_acl_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SmbAclEnabled { get; set; }

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
    /// The valid_user_list attribute.
    /// </summary>
    [TerraformPropertyName("valid_user_list")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ValidUserList { get; set; }

    /// <summary>
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_dns_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcEndpointDnsName { get; set; }

    /// <summary>
    /// Block for cache_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    [TerraformPropertyName("cache_attributes")]
    public TerraformList<TerraformBlock<AwsStoragegatewaySmbFileShareCacheAttributesBlock>>? CacheAttributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsStoragegatewaySmbFileShareTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The fileshare_id attribute.
    /// </summary>
    [TerraformPropertyName("fileshare_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FileshareId => new TerraformReference(this, "fileshare_id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Path => new TerraformReference(this, "path");

}
