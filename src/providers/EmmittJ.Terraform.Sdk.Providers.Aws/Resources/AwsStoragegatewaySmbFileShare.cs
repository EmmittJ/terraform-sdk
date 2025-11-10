using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewaySmbFileShareCacheAttributesBlock : ITerraformBlock
{
    /// <summary>
    /// The cache_stale_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("cache_stale_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CacheStaleTimeoutInSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewaySmbFileShareTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AccessBasedEnumeration { get; set; }

    /// <summary>
    /// The admin_user_list attribute.
    /// </summary>
    [TerraformPropertyName("admin_user_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AdminUserList { get; set; }

    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    [TerraformPropertyName("audit_destination_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuditDestinationArn { get; set; }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformPropertyName("authentication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Authentication { get; set; }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformPropertyName("bucket_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BucketRegion { get; set; }

    /// <summary>
    /// The case_sensitivity attribute.
    /// </summary>
    [TerraformPropertyName("case_sensitivity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CaseSensitivity { get; set; }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    [TerraformPropertyName("default_storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultStorageClass { get; set; }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    [TerraformPropertyName("file_share_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FileShareName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_share_name");

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformPropertyName("gateway_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GatewayArn { get; set; }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    [TerraformPropertyName("guess_mime_type_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GuessMimeTypeEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The invalid_user_list attribute.
    /// </summary>
    [TerraformPropertyName("invalid_user_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? InvalidUserList { get; set; }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("kms_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    [TerraformPropertyName("location_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LocationArn { get; set; }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    [TerraformPropertyName("notification_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationPolicy { get; set; }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    [TerraformPropertyName("object_acl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectAcl { get; set; }

    /// <summary>
    /// The oplocks_enabled attribute.
    /// </summary>
    [TerraformPropertyName("oplocks_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> OplocksEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "oplocks_enabled");

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformPropertyName("read_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReadOnly { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    [TerraformPropertyName("requester_pays")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequesterPays { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The smb_acl_enabled attribute.
    /// </summary>
    [TerraformPropertyName("smb_acl_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbAclEnabled { get; set; }

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
    /// The valid_user_list attribute.
    /// </summary>
    [TerraformPropertyName("valid_user_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ValidUserList { get; set; }

    /// <summary>
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_dns_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcEndpointDnsName { get; set; }

    /// <summary>
    /// Block for cache_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    [TerraformPropertyName("cache_attributes")]
    public TerraformList<TerraformBlock<AwsStoragegatewaySmbFileShareCacheAttributesBlock>>? CacheAttributes { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsStoragegatewaySmbFileShareTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The fileshare_id attribute.
    /// </summary>
    [TerraformPropertyName("fileshare_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FileshareId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fileshare_id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

}
