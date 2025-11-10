using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewaySmbFileShareCacheAttributesBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewaySmbFileShareTimeoutsBlock : TerraformBlock
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
/// Manages a aws_storagegateway_smb_file_share resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsStoragegatewaySmbFileShare : TerraformResource
{
    public AwsStoragegatewaySmbFileShare(string name) : base("aws_storagegateway_smb_file_share", name)
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
    /// The access_based_enumeration attribute.
    /// </summary>
    public TerraformProperty<bool>? AccessBasedEnumeration
    {
        get => GetProperty<TerraformProperty<bool>>("access_based_enumeration");
        set => this.WithProperty("access_based_enumeration", value);
    }

    /// <summary>
    /// The admin_user_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AdminUserList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("admin_user_list");
        set => this.WithProperty("admin_user_list", value);
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
    /// The authentication attribute.
    /// </summary>
    public TerraformProperty<string>? Authentication
    {
        get => GetProperty<TerraformProperty<string>>("authentication");
        set => this.WithProperty("authentication", value);
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
    /// The case_sensitivity attribute.
    /// </summary>
    public TerraformProperty<string>? CaseSensitivity
    {
        get => GetProperty<TerraformProperty<string>>("case_sensitivity");
        set => this.WithProperty("case_sensitivity", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("gateway_arn");
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
    /// The invalid_user_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InvalidUserList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("invalid_user_list");
        set => this.WithProperty("invalid_user_list", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("location_arn");
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
    /// The oplocks_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OplocksEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("oplocks_enabled");
        set => this.WithProperty("oplocks_enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The smb_acl_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmbAclEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb_acl_enabled");
        set => this.WithProperty("smb_acl_enabled", value);
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
    /// The valid_user_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ValidUserList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("valid_user_list");
        set => this.WithProperty("valid_user_list", value);
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
    public List<AwsStoragegatewaySmbFileShareCacheAttributesBlock>? CacheAttributes
    {
        get => GetProperty<List<AwsStoragegatewaySmbFileShareCacheAttributesBlock>>("cache_attributes");
        set => this.WithProperty("cache_attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsStoragegatewaySmbFileShareTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsStoragegatewaySmbFileShareTimeoutsBlock>("timeouts");
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
