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
    public TerraformLiteralProperty<string>? AuditDestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("audit_destination_arn");
        set => this.WithProperty("audit_destination_arn", value);
    }

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_region");
        set => this.WithProperty("bucket_region", value);
    }

    /// <summary>
    /// The client_list attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ClientList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("client_list");
        set => this.WithProperty("client_list", value);
    }

    /// <summary>
    /// The default_storage_class attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultStorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_storage_class");
        set => this.WithProperty("default_storage_class", value);
    }

    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FileShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_share_name");
        set => this.WithProperty("file_share_name", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_arn");
        set => this.WithProperty("gateway_arn", value);
    }

    /// <summary>
    /// The guess_mime_type_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GuessMimeTypeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("guess_mime_type_enabled");
        set => this.WithProperty("guess_mime_type_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? KmsEncrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kms_encrypted");
        set => this.WithProperty("kms_encrypted", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The location_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_arn");
        set => this.WithProperty("location_arn", value);
    }

    /// <summary>
    /// The notification_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_policy");
        set => this.WithProperty("notification_policy", value);
    }

    /// <summary>
    /// The object_acl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_acl");
        set => this.WithProperty("object_acl", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ReadOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("read_only");
        set => this.WithProperty("read_only", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The requester_pays attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequesterPays
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requester_pays");
        set => this.WithProperty("requester_pays", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The squash attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Squash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("squash");
        set => this.WithProperty("squash", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_endpoint_dns_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcEndpointDnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_dns_name");
        set => this.WithProperty("vpc_endpoint_dns_name", value);
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
