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
        this.DeclareOutput("arn");
        this.DeclareOutput("chap_enabled");
        this.DeclareOutput("lun_number");
        this.DeclareOutput("network_interface_port");
        this.DeclareOutput("target_arn");
        this.DeclareOutput("volume_arn");
        this.DeclareOutput("volume_id");
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
    /// The source_volume_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceVolumeArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_volume_arn");
        set => this.WithProperty("source_volume_arn", value);
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
    /// The volume_size_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? VolumeSizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_size_in_bytes");
        set => this.WithProperty("volume_size_in_bytes", value);
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
