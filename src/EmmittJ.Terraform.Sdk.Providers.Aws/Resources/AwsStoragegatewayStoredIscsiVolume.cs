using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_stored_iscsi_volume resource.
/// </summary>
public class AwsStoragegatewayStoredIscsiVolume : TerraformResource
{
    public AwsStoragegatewayStoredIscsiVolume(string name) : base("aws_storagegateway_stored_iscsi_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("chap_enabled");
        this.DeclareOutput("lun_number");
        this.DeclareOutput("network_interface_port");
        this.DeclareOutput("target_arn");
        this.DeclareOutput("volume_attachment_status");
        this.DeclareOutput("volume_id");
        this.DeclareOutput("volume_size_in_bytes");
        this.DeclareOutput("volume_status");
        this.DeclareOutput("volume_type");
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_id");
        set => this.WithProperty("disk_id", value);
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
    /// The kms_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// The preserve_existing_data attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PreserveExistingData
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve_existing_data");
        set => this.WithProperty("preserve_existing_data", value);
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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
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
    /// The target_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_name");
        set => this.WithProperty("target_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The chap_enabled attribute.
    /// </summary>
    public TerraformExpression ChapEnabled => this["chap_enabled"];

    /// <summary>
    /// The lun_number attribute.
    /// </summary>
    public TerraformExpression LunNumber => this["lun_number"];

    /// <summary>
    /// The network_interface_port attribute.
    /// </summary>
    public TerraformExpression NetworkInterfacePort => this["network_interface_port"];

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    public TerraformExpression TargetArn => this["target_arn"];

    /// <summary>
    /// The volume_attachment_status attribute.
    /// </summary>
    public TerraformExpression VolumeAttachmentStatus => this["volume_attachment_status"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    public TerraformExpression VolumeSizeInBytes => this["volume_size_in_bytes"];

    /// <summary>
    /// The volume_status attribute.
    /// </summary>
    public TerraformExpression VolumeStatus => this["volume_status"];

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformExpression VolumeType => this["volume_type"];

}
