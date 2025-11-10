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
        set => SetProperty("cache_stale_timeout_in_seconds", value);
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
        set => SetProperty("directory_mode", value);
    }

    /// <summary>
    /// The file_mode attribute.
    /// </summary>
    public TerraformProperty<string>? FileMode
    {
        set => SetProperty("file_mode", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        set => SetProperty("group_id", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerId
    {
        set => SetProperty("owner_id", value);
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_storagegateway_nfs_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsStoragegatewayNfsFileShare : TerraformResource
{
    public AwsStoragegatewayNfsFileShare(string name) : base("aws_storagegateway_nfs_file_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("fileshare_id");
        SetOutput("path");
        SetOutput("audit_destination_arn");
        SetOutput("bucket_region");
        SetOutput("client_list");
        SetOutput("default_storage_class");
        SetOutput("file_share_name");
        SetOutput("gateway_arn");
        SetOutput("guess_mime_type_enabled");
        SetOutput("id");
        SetOutput("kms_encrypted");
        SetOutput("kms_key_arn");
        SetOutput("location_arn");
        SetOutput("notification_policy");
        SetOutput("object_acl");
        SetOutput("read_only");
        SetOutput("region");
        SetOutput("requester_pays");
        SetOutput("role_arn");
        SetOutput("squash");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_endpoint_dns_name");
    }

    /// <summary>
    /// The audit_destination_arn attribute.
    /// </summary>
    public TerraformProperty<string> AuditDestinationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("audit_destination_arn");
        set => SetProperty("audit_destination_arn", value);
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformProperty<string> BucketRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_region");
        set => SetProperty("bucket_region", value);
    }

    /// <summary>
    /// The client_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientList is required")]
    public HashSet<TerraformProperty<string>> ClientList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("client_list");
        set => SetProperty("client_list", value);
    }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    public TerraformProperty<string> DefaultStorageClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_storage_class");
        set => SetProperty("default_storage_class", value);
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public TerraformProperty<string> FileShareName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_share_name");
        set => SetProperty("file_share_name", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformProperty<string> GatewayArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_arn");
        set => SetProperty("gateway_arn", value);
    }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GuessMimeTypeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("guess_mime_type_enabled");
        set => SetProperty("guess_mime_type_enabled", value);
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
    /// The kms_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> KmsEncrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("kms_encrypted");
        set => SetProperty("kms_encrypted", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationArn is required")]
    public required TerraformProperty<string> LocationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location_arn");
        set => SetProperty("location_arn", value);
    }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    public TerraformProperty<string> NotificationPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_policy");
        set => SetProperty("notification_policy", value);
    }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    public TerraformProperty<string> ObjectAcl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_acl");
        set => SetProperty("object_acl", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformProperty<bool> ReadOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("read_only");
        set => SetProperty("read_only", value);
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
    /// The requester_pays attribute.
    /// </summary>
    public TerraformProperty<bool> RequesterPays
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("requester_pays");
        set => SetProperty("requester_pays", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The squash attribute.
    /// </summary>
    public TerraformProperty<string> Squash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("squash");
        set => SetProperty("squash", value);
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
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    public TerraformProperty<string> VpcEndpointDnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_dns_name");
        set => SetProperty("vpc_endpoint_dns_name", value);
    }

    /// <summary>
    /// Block for cache_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheAttributes block(s) allowed")]
    public List<AwsStoragegatewayNfsFileShareCacheAttributesBlock>? CacheAttributes
    {
        set => SetProperty("cache_attributes", value);
    }

    /// <summary>
    /// Block for nfs_file_share_defaults.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsFileShareDefaults block(s) allowed")]
    public List<AwsStoragegatewayNfsFileShareNfsFileShareDefaultsBlock>? NfsFileShareDefaults
    {
        set => SetProperty("nfs_file_share_defaults", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsStoragegatewayNfsFileShareTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
