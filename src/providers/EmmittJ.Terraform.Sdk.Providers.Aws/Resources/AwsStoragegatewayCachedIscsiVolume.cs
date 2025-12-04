using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_storagegateway_cached_iscsi_volume Terraform resource.
/// Manages a aws_storagegateway_cached_iscsi_volume resource.
/// </summary>
public partial class AwsStoragegatewayCachedIscsiVolume(string name) : TerraformResource("aws_storagegateway_cached_iscsi_volume", name)
{
    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformValue<string> GatewayArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_arn");
        set => SetArgument("gateway_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? KmsEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("kms_encrypted");
        set => SetArgument("kms_encrypted", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => GetArgument<TerraformValue<string>>("snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The source_volume_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceVolumeArn
    {
        get => GetArgument<TerraformValue<string>>("source_volume_arn");
        set => SetArgument("source_volume_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    public required TerraformValue<string> TargetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_name");
        set => SetArgument("target_name", value);
    }

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSizeInBytes is required")]
    public required TerraformValue<double> VolumeSizeInBytes
    {
        get => GetRequiredArgument<TerraformValue<double>>("volume_size_in_bytes");
        set => SetArgument("volume_size_in_bytes", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The chap_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ChapEnabled
        => AsReference("chap_enabled");

    /// <summary>
    /// The lun_number attribute.
    /// </summary>
    public TerraformValue<double> LunNumber
        => AsReference("lun_number");

    /// <summary>
    /// The network_interface_port attribute.
    /// </summary>
    public TerraformValue<double> NetworkInterfacePort
        => AsReference("network_interface_port");

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    public TerraformValue<string> TargetArn
        => AsReference("target_arn");

    /// <summary>
    /// The volume_arn attribute.
    /// </summary>
    public TerraformValue<string> VolumeArn
        => AsReference("volume_arn");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformValue<string> VolumeId
        => AsReference("volume_id");

}
