using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_openzfs_volume resource.
/// </summary>
public class AwsFsxOpenzfsVolume : TerraformResource
{
    public AwsFsxOpenzfsVolume(string name) : base("aws_fsx_openzfs_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    public bool? CopyTagsToSnapshots
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_snapshots")?.Value;
        set => this.WithProperty("copy_tags_to_snapshots", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public string? DataCompressionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_compression_type")?.Value;
        set => this.WithProperty("data_compression_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    public List<string>? DeleteVolumeOptions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("delete_volume_options")?.Value;
        set => this.WithProperty("delete_volume_options", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    public string? ParentVolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_volume_id")?.Value;
        set => this.WithProperty("parent_volume_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The record_size_kib attribute.
    /// </summary>
    public double? RecordSizeKib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("record_size_kib")?.Value;
        set => this.WithProperty("record_size_kib", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    public double? StorageCapacityQuotaGib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity_quota_gib")?.Value;
        set => this.WithProperty("storage_capacity_quota_gib", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    public double? StorageCapacityReservationGib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity_reservation_gib")?.Value;
        set => this.WithProperty("storage_capacity_reservation_gib", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The volume_type attribute.
    /// </summary>
    public string? VolumeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_type")?.Value;
        set => this.WithProperty("volume_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
