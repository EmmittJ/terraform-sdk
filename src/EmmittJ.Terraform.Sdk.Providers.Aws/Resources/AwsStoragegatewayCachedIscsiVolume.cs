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
    public TerraformProperty<string>? GatewayArn
    {
        get => GetProperty<TerraformProperty<string>>("gateway_arn");
        set => this.WithProperty("gateway_arn", value);
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
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
    }

    /// <summary>
    /// The source_volume_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVolumeArn
    {
        get => GetProperty<TerraformProperty<string>>("source_volume_arn");
        set => this.WithProperty("source_volume_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetName
    {
        get => GetProperty<TerraformProperty<string>>("target_name");
        set => this.WithProperty("target_name", value);
    }

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSizeInBytes
    {
        get => GetProperty<TerraformProperty<double>>("volume_size_in_bytes");
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
