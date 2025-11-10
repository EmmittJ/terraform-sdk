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
        SetOutput("arn");
        SetOutput("chap_enabled");
        SetOutput("lun_number");
        SetOutput("network_interface_port");
        SetOutput("target_arn");
        SetOutput("volume_attachment_status");
        SetOutput("volume_id");
        SetOutput("volume_size_in_bytes");
        SetOutput("volume_status");
        SetOutput("volume_type");
        SetOutput("disk_id");
        SetOutput("gateway_arn");
        SetOutput("id");
        SetOutput("kms_encrypted");
        SetOutput("kms_key");
        SetOutput("network_interface_id");
        SetOutput("preserve_existing_data");
        SetOutput("region");
        SetOutput("snapshot_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_name");
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskId is required")]
    public required TerraformProperty<string> DiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_id");
        set => SetProperty("disk_id", value);
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
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// The preserve_existing_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveExistingData is required")]
    public required TerraformProperty<bool> PreserveExistingData
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("preserve_existing_data");
        set => SetProperty("preserve_existing_data", value);
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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_id");
        set => SetProperty("snapshot_id", value);
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
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    public required TerraformProperty<string> TargetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_name");
        set => SetProperty("target_name", value);
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
