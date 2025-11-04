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
    public string? GatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_arn")?.Value;
        set => this.WithProperty("gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key attribute.
    /// </summary>
    public string? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key")?.Value;
        set => this.WithProperty("kms_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public string? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id")?.Value;
        set => this.WithProperty("snapshot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_volume_arn attribute.
    /// </summary>
    public string? SourceVolumeArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_volume_arn")?.Value;
        set => this.WithProperty("source_volume_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_name attribute.
    /// </summary>
    public string? TargetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_name")?.Value;
        set => this.WithProperty("target_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The volume_size_in_bytes attribute.
    /// </summary>
    public double? VolumeSizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_size_in_bytes")?.Value;
        set => this.WithProperty("volume_size_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
