using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_cached_iscsi_volume resource.
/// </summary>
public class AwsStoragegatewayCachedIscsiVolume : TerraformResource
{
    public AwsStoragegatewayCachedIscsiVolume(string name) : base("aws_storagegateway_cached_iscsi_volume", name)
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
        SetOutput("volume_arn");
        SetOutput("volume_id");
        SetOutput("gateway_arn");
        SetOutput("id");
        SetOutput("kms_encrypted");
        SetOutput("kms_key");
        SetOutput("network_interface_id");
        SetOutput("region");
        SetOutput("snapshot_id");
        SetOutput("source_volume_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_name");
        SetOutput("volume_size_in_bytes");
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
    /// The source_volume_arn attribute.
    /// </summary>
    public TerraformProperty<string> SourceVolumeArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_volume_arn");
        set => SetProperty("source_volume_arn", value);
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
    /// The volume_size_in_bytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSizeInBytes is required")]
    public required TerraformProperty<double> VolumeSizeInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("volume_size_in_bytes");
        set => SetProperty("volume_size_in_bytes", value);
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
    /// The volume_arn attribute.
    /// </summary>
    public TerraformExpression VolumeArn => this["volume_arn"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

}
