using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AuditDestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("audit_destination_arn")?.Value;
        set => this.WithProperty("audit_destination_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public string? BucketRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_region")?.Value;
        set => this.WithProperty("bucket_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_list attribute.
    /// </summary>
    public HashSet<string>? ClientList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("client_list")?.Value;
        set => this.WithProperty("client_list", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    public string? DefaultStorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_storage_class")?.Value;
        set => this.WithProperty("default_storage_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public string? FileShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_share_name")?.Value;
        set => this.WithProperty("file_share_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    public string? GatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_arn")?.Value;
        set => this.WithProperty("gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    public bool? GuessMimeTypeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("guess_mime_type_enabled")?.Value;
        set => this.WithProperty("guess_mime_type_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    public bool? KmsEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kms_encrypted")?.Value;
        set => this.WithProperty("kms_encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    public string? LocationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_arn")?.Value;
        set => this.WithProperty("location_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    public string? NotificationPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_policy")?.Value;
        set => this.WithProperty("notification_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    public string? ObjectAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_acl")?.Value;
        set => this.WithProperty("object_acl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public bool? ReadOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("read_only")?.Value;
        set => this.WithProperty("read_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    public bool? RequesterPays
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requester_pays")?.Value;
        set => this.WithProperty("requester_pays", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The squash attribute.
    /// </summary>
    public string? Squash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("squash")?.Value;
        set => this.WithProperty("squash", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    public string? VpcEndpointDnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_dns_name")?.Value;
        set => this.WithProperty("vpc_endpoint_dns_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
