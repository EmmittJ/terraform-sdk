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
        set => SetProperty("cache_stale_timeout_in_seconds", value);
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
        SetOutput("arn");
        SetOutput("fileshare_id");
        SetOutput("path");
        SetOutput("access_based_enumeration");
        SetOutput("admin_user_list");
        SetOutput("audit_destination_arn");
        SetOutput("authentication");
        SetOutput("bucket_region");
        SetOutput("case_sensitivity");
        SetOutput("default_storage_class");
        SetOutput("file_share_name");
        SetOutput("gateway_arn");
        SetOutput("guess_mime_type_enabled");
        SetOutput("id");
        SetOutput("invalid_user_list");
        SetOutput("kms_encrypted");
        SetOutput("kms_key_arn");
        SetOutput("location_arn");
        SetOutput("notification_policy");
        SetOutput("object_acl");
        SetOutput("oplocks_enabled");
        SetOutput("read_only");
        SetOutput("region");
        SetOutput("requester_pays");
        SetOutput("role_arn");
        SetOutput("smb_acl_enabled");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("valid_user_list");
        SetOutput("vpc_endpoint_dns_name");
    }

    /// <summary>
    /// The access_based_enumeration attribute.
    /// </summary>
    public TerraformProperty<bool> AccessBasedEnumeration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("access_based_enumeration");
        set => SetProperty("access_based_enumeration", value);
    }

    /// <summary>
    /// The admin_user_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AdminUserList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("admin_user_list");
        set => SetProperty("admin_user_list", value);
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
    /// The authentication attribute.
    /// </summary>
    public TerraformProperty<string> Authentication
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication");
        set => SetProperty("authentication", value);
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
    /// The case_sensitivity attribute.
    /// </summary>
    public TerraformProperty<string> CaseSensitivity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("case_sensitivity");
        set => SetProperty("case_sensitivity", value);
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
    /// The invalid_user_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> InvalidUserList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("invalid_user_list");
        set => SetProperty("invalid_user_list", value);
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
    /// The oplocks_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OplocksEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("oplocks_enabled");
        set => SetProperty("oplocks_enabled", value);
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
    /// The smb_acl_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SmbAclEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("smb_acl_enabled");
        set => SetProperty("smb_acl_enabled", value);
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
    /// The valid_user_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ValidUserList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("valid_user_list");
        set => SetProperty("valid_user_list", value);
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
    public List<AwsStoragegatewaySmbFileShareCacheAttributesBlock>? CacheAttributes
    {
        set => SetProperty("cache_attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsStoragegatewaySmbFileShareTimeoutsBlock? Timeouts
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
