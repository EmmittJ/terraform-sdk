using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsStoragegatewayNfsFileShareCacheAttributesBlock() : TerraformBlock("cache_attributes")
{
    /// <summary>
    /// The cache_stale_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("cache_stale_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CacheStaleTimeoutInSeconds { get; set; }

}

/// <summary>
/// Block type for nfs_file_share_defaults in .
/// Nesting mode: list
/// </summary>
public partial class AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock() : TerraformBlock("nfs_file_share_defaults")
{
    /// <summary>
    /// The directory_mode attribute.
    /// </summary>
    [TerraformProperty("directory_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectoryMode { get; set; }

    /// <summary>
    /// The file_mode attribute.
    /// </summary>
    [TerraformProperty("file_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileMode { get; set; }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [TerraformProperty("group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GroupId { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OwnerId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsStoragegatewayNfsFileShareTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_storagegateway_nfs_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsStoragegatewayNfsFileShare : TerraformResource
{
    public AwsStoragegatewayNfsFileShare(string name) : base("aws_storagegateway_nfs_file_share", name)
    {
    }

    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    [TerraformProperty("audit_destination_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuditDestinationArn { get; set; }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    [TerraformProperty("bucket_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketRegion { get; set; }

    /// <summary>
    /// The client_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientList is required")]
    [TerraformProperty("client_list")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> ClientList { get; set; }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    [TerraformProperty("default_storage_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultStorageClass { get; set; }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    [TerraformProperty("file_share_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FileShareName { get; set; }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    [TerraformProperty("gateway_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewayArn { get; set; }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    [TerraformProperty("guess_mime_type_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GuessMimeTypeEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    [TerraformProperty("kms_encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? KmsEncrypted { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    [TerraformProperty("location_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocationArn { get; set; }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    [TerraformProperty("notification_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NotificationPolicy { get; set; }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    [TerraformProperty("object_acl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectAcl { get; set; }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformProperty("read_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReadOnly { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    [TerraformProperty("requester_pays")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequesterPays { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The squash attribute.
    /// </summary>
    [TerraformProperty("squash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Squash { get; set; }

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
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_dns_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcEndpointDnsName { get; set; }

    /// <summary>
    /// Block for cache_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    [TerraformProperty("cache_attributes")]
    public TerraformList<AwsStoragegatewayNfsFileShareCacheAttributesBlock> CacheAttributes { get; set; } = new();

    /// <summary>
    /// Block for nfs_file_share_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsFileShareDefaults block(s) allowed")]
    [TerraformProperty("nfs_file_share_defaults")]
    public TerraformList<AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock> NfsFileShareDefaults { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsStoragegatewayNfsFileShareTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The fileshare_id attribute.
    /// </summary>
    [TerraformProperty("fileshare_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FileshareId { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Path { get; }

}
