using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in AwsStoragegatewaySmbFileShare.
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewaySmbFileShareCacheAttributesBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "cache_stale_timeout_in_seconds");
        set => SetArgument("cache_stale_timeout_in_seconds", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsStoragegatewaySmbFileShare.
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewaySmbFileShareTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_storagegateway_smb_file_share Terraform resource.
/// Manages a aws_storagegateway_smb_file_share resource.
/// </summary>
public partial class AwsStoragegatewaySmbFileShare(string name) : TerraformResource("aws_storagegateway_smb_file_share", name)
{
    /// <summary>
    /// The access_based_enumeration attribute.
    /// </summary>
    public TerraformValue<bool>? AccessBasedEnumeration
    {
        get => new TerraformReference<bool>(this, "access_based_enumeration");
        set => SetArgument("access_based_enumeration", value);
    }

    /// <summary>
    /// The admin_user_list attribute.
    /// </summary>
    public TerraformSet<string>? AdminUserList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "admin_user_list").ResolveNodes(ctx));
        set => SetArgument("admin_user_list", value);
    }

    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    public TerraformValue<string>? AuditDestinationArn
    {
        get => new TerraformReference<string>(this, "audit_destination_arn");
        set => SetArgument("audit_destination_arn", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformValue<string>? Authentication
    {
        get => new TerraformReference<string>(this, "authentication");
        set => SetArgument("authentication", value);
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformValue<string>? BucketRegion
    {
        get => new TerraformReference<string>(this, "bucket_region");
        set => SetArgument("bucket_region", value);
    }

    /// <summary>
    /// The case_sensitivity attribute.
    /// </summary>
    public TerraformValue<string>? CaseSensitivity
    {
        get => new TerraformReference<string>(this, "case_sensitivity");
        set => SetArgument("case_sensitivity", value);
    }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    public TerraformValue<string>? DefaultStorageClass
    {
        get => new TerraformReference<string>(this, "default_storage_class");
        set => SetArgument("default_storage_class", value);
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public TerraformValue<string> FileShareName
    {
        get => new TerraformReference<string>(this, "file_share_name");
        set => SetArgument("file_share_name", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformValue<string> GatewayArn
    {
        get => new TerraformReference<string>(this, "gateway_arn");
        set => SetArgument("gateway_arn", value);
    }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GuessMimeTypeEnabled
    {
        get => new TerraformReference<bool>(this, "guess_mime_type_enabled");
        set => SetArgument("guess_mime_type_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The invalid_user_list attribute.
    /// </summary>
    public TerraformSet<string>? InvalidUserList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "invalid_user_list").ResolveNodes(ctx));
        set => SetArgument("invalid_user_list", value);
    }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? KmsEncrypted
    {
        get => new TerraformReference<bool>(this, "kms_encrypted");
        set => SetArgument("kms_encrypted", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    public required TerraformValue<string> LocationArn
    {
        get => new TerraformReference<string>(this, "location_arn");
        set => SetArgument("location_arn", value);
    }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    public TerraformValue<string>? NotificationPolicy
    {
        get => new TerraformReference<string>(this, "notification_policy");
        set => SetArgument("notification_policy", value);
    }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    public TerraformValue<string>? ObjectAcl
    {
        get => new TerraformReference<string>(this, "object_acl");
        set => SetArgument("object_acl", value);
    }

    /// <summary>
    /// The oplocks_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OplocksEnabled
    {
        get => new TerraformReference<bool>(this, "oplocks_enabled");
        set => SetArgument("oplocks_enabled", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => new TerraformReference<bool>(this, "read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    public TerraformValue<bool>? RequesterPays
    {
        get => new TerraformReference<bool>(this, "requester_pays");
        set => SetArgument("requester_pays", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The smb_acl_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SmbAclEnabled
    {
        get => new TerraformReference<bool>(this, "smb_acl_enabled");
        set => SetArgument("smb_acl_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The valid_user_list attribute.
    /// </summary>
    public TerraformSet<string>? ValidUserList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "valid_user_list").ResolveNodes(ctx));
        set => SetArgument("valid_user_list", value);
    }

    /// <summary>
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointDnsName
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_dns_name");
        set => SetArgument("vpc_endpoint_dns_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The fileshare_id attribute.
    /// </summary>
    public TerraformValue<string> FileshareId
    {
        get => new TerraformReference<string>(this, "fileshare_id");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// CacheAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    public TerraformList<AwsStoragegatewaySmbFileShareCacheAttributesBlock>? CacheAttributes
    {
        get => GetArgument<TerraformList<AwsStoragegatewaySmbFileShareCacheAttributesBlock>>("cache_attributes");
        set => SetArgument("cache_attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsStoragegatewaySmbFileShareTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsStoragegatewaySmbFileShareTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
