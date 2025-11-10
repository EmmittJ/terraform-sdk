using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayNfsFileShareCacheAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The cache_stale_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? CacheStaleTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("cache_stale_timeout_in_seconds");
        set => WithProperty("cache_stale_timeout_in_seconds", value);
    }

}

/// <summary>
/// Block type for nfs_file_share_defaults in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// The directory_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryMode
    {
        get => GetProperty<TerraformProperty<string>>("directory_mode");
        set => WithProperty("directory_mode", value);
    }

    /// <summary>
    /// The file_mode attribute.
    /// </summary>
    public TerraformProperty<string>? FileMode
    {
        get => GetProperty<TerraformProperty<string>>("file_mode");
        set => WithProperty("file_mode", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => WithProperty("group_id", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerId
    {
        get => GetProperty<TerraformProperty<string>>("owner_id");
        set => WithProperty("owner_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayNfsFileShareTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_storagegateway_nfs_file_share resource.
/// </summary>
public class AwsStoragegatewayNfsFileShare : TerraformResource
{
    public AwsStoragegatewayNfsFileShare(string name) : base("aws_storagegateway_nfs_file_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("fileshare_id");
        this.DeclareOutput("path");
    }

    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AuditDestinationArn
    {
        get => GetProperty<TerraformProperty<string>>("audit_destination_arn");
        set => this.WithProperty("audit_destination_arn", value);
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformProperty<string>? BucketRegion
    {
        get => GetProperty<TerraformProperty<string>>("bucket_region");
        set => this.WithProperty("bucket_region", value);
    }

    /// <summary>
    /// The client_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientList is required")]
    public HashSet<TerraformProperty<string>>? ClientList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("client_list");
        set => this.WithProperty("client_list", value);
    }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultStorageClass
    {
        get => GetProperty<TerraformProperty<string>>("default_storage_class");
        set => this.WithProperty("default_storage_class", value);
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public TerraformProperty<string>? FileShareName
    {
        get => GetProperty<TerraformProperty<string>>("file_share_name");
        set => this.WithProperty("file_share_name", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformProperty<string> GatewayArn
    {
        get => GetProperty<TerraformProperty<string>>("gateway_arn");
        set => this.WithProperty("gateway_arn", value);
    }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GuessMimeTypeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("guess_mime_type_enabled");
        set => this.WithProperty("guess_mime_type_enabled", value);
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
    /// The kms_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? KmsEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("kms_encrypted");
        set => this.WithProperty("kms_encrypted", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    public required TerraformProperty<string> LocationArn
    {
        get => GetProperty<TerraformProperty<string>>("location_arn");
        set => this.WithProperty("location_arn", value);
    }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("notification_policy");
        set => this.WithProperty("notification_policy", value);
    }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectAcl
    {
        get => GetProperty<TerraformProperty<string>>("object_acl");
        set => this.WithProperty("object_acl", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadOnly
    {
        get => GetProperty<TerraformProperty<bool>>("read_only");
        set => this.WithProperty("read_only", value);
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
    /// The requester_pays attribute.
    /// </summary>
    public TerraformProperty<bool>? RequesterPays
    {
        get => GetProperty<TerraformProperty<bool>>("requester_pays");
        set => this.WithProperty("requester_pays", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The squash attribute.
    /// </summary>
    public TerraformProperty<string>? Squash
    {
        get => GetProperty<TerraformProperty<string>>("squash");
        set => this.WithProperty("squash", value);
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
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointDnsName
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_dns_name");
        set => this.WithProperty("vpc_endpoint_dns_name", value);
    }

    /// <summary>
    /// Block for cache_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    public List<AwsStoragegatewayNfsFileShareCacheAttributesBlock>? CacheAttributes
    {
        get => GetProperty<List<AwsStoragegatewayNfsFileShareCacheAttributesBlock>>("cache_attributes");
        set => this.WithProperty("cache_attributes", value);
    }

    /// <summary>
    /// Block for nfs_file_share_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsFileShareDefaults block(s) allowed")]
    public List<AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock>? NfsFileShareDefaults
    {
        get => GetProperty<List<AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock>>("nfs_file_share_defaults");
        set => this.WithProperty("nfs_file_share_defaults", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsStoragegatewayNfsFileShareTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsStoragegatewayNfsFileShareTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The fileshare_id attribute.
    /// </summary>
    public TerraformExpression FileshareId => this["fileshare_id"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

}
