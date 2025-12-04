using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in AwsStoragegatewayNfsFileShare.
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayNfsFileShareCacheAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_attributes";

    /// <summary>
    /// The cache_stale_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? CacheStaleTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("cache_stale_timeout_in_seconds");
        set => SetArgument("cache_stale_timeout_in_seconds", value);
    }

}


/// <summary>
/// Block type for nfs_file_share_defaults in AwsStoragegatewayNfsFileShare.
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs_file_share_defaults";

    /// <summary>
    /// The directory_mode attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryMode
    {
        get => GetArgument<TerraformValue<string>>("directory_mode");
        set => SetArgument("directory_mode", value);
    }

    /// <summary>
    /// The file_mode attribute.
    /// </summary>
    public TerraformValue<string>? FileMode
    {
        get => GetArgument<TerraformValue<string>>("file_mode");
        set => SetArgument("file_mode", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformValue<string>? GroupId
    {
        get => GetArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string>? OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id");
        set => SetArgument("owner_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsStoragegatewayNfsFileShare.
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayNfsFileShareTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_storagegateway_nfs_file_share Terraform resource.
/// Manages a aws_storagegateway_nfs_file_share resource.
/// </summary>
public partial class AwsStoragegatewayNfsFileShare(string name) : TerraformResource("aws_storagegateway_nfs_file_share", name)
{
    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    public TerraformValue<string>? AuditDestinationArn
    {
        get => GetArgument<TerraformValue<string>>("audit_destination_arn");
        set => SetArgument("audit_destination_arn", value);
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformValue<string>? BucketRegion
    {
        get => GetArgument<TerraformValue<string>>("bucket_region");
        set => SetArgument("bucket_region", value);
    }

    /// <summary>
    /// The client_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientList is required")]
    public required TerraformSet<string> ClientList
    {
        get => GetRequiredArgument<TerraformSet<string>>("client_list");
        set => SetArgument("client_list", value);
    }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    public TerraformValue<string>? DefaultStorageClass
    {
        get => GetArgument<TerraformValue<string>>("default_storage_class");
        set => SetArgument("default_storage_class", value);
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public TerraformValue<string> FileShareName
    {
        get => GetArgument<TerraformValue<string>>("file_share_name") ?? AsReference("file_share_name");
        set => SetArgument("file_share_name", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformValue<string> GatewayArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_arn");
        set => SetArgument("gateway_arn", value);
    }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GuessMimeTypeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("guess_mime_type_enabled");
        set => SetArgument("guess_mime_type_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? KmsEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("kms_encrypted");
        set => SetArgument("kms_encrypted", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    public required TerraformValue<string> LocationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("location_arn");
        set => SetArgument("location_arn", value);
    }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    public TerraformValue<string>? NotificationPolicy
    {
        get => GetArgument<TerraformValue<string>>("notification_policy");
        set => SetArgument("notification_policy", value);
    }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    public TerraformValue<string>? ObjectAcl
    {
        get => GetArgument<TerraformValue<string>>("object_acl");
        set => SetArgument("object_acl", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    public TerraformValue<bool>? RequesterPays
    {
        get => GetArgument<TerraformValue<bool>>("requester_pays");
        set => SetArgument("requester_pays", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The squash attribute.
    /// </summary>
    public TerraformValue<string>? Squash
    {
        get => GetArgument<TerraformValue<string>>("squash");
        set => SetArgument("squash", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointDnsName
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_dns_name");
        set => SetArgument("vpc_endpoint_dns_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The fileshare_id attribute.
    /// </summary>
    public TerraformValue<string> FileshareId
        => AsReference("fileshare_id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// CacheAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    public TerraformList<AwsStoragegatewayNfsFileShareCacheAttributesBlock>? CacheAttributes
    {
        get => GetArgument<TerraformList<AwsStoragegatewayNfsFileShareCacheAttributesBlock>>("cache_attributes");
        set => SetArgument("cache_attributes", value);
    }

    /// <summary>
    /// NfsFileShareDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsFileShareDefaults block(s) allowed")]
    public TerraformList<AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock>? NfsFileShareDefaults
    {
        get => GetArgument<TerraformList<AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock>>("nfs_file_share_defaults");
        set => SetArgument("nfs_file_share_defaults", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsStoragegatewayNfsFileShareTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsStoragegatewayNfsFileShareTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
