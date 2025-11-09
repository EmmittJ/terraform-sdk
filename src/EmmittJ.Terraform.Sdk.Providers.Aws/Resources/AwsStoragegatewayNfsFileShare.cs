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
    public TerraformProperty<HashSet<string>>? ClientList
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("client_list");
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
    public TerraformProperty<string>? GatewayArn
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
    public TerraformProperty<string>? LocationArn
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
    public TerraformProperty<string>? RoleArn
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
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
