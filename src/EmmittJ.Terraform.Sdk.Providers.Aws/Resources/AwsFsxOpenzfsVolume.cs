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
    public TerraformLiteralProperty<bool>? CopyTagsToSnapshots
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_snapshots");
        set => this.WithProperty("copy_tags_to_snapshots", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataCompressionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_compression_type");
        set => this.WithProperty("data_compression_type", value);
    }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DeleteVolumeOptions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("delete_volume_options");
        set => this.WithProperty("delete_volume_options", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentVolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_volume_id");
        set => this.WithProperty("parent_volume_id", value);
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
    /// The record_size_kib attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RecordSizeKib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("record_size_kib");
        set => this.WithProperty("record_size_kib", value);
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
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageCapacityQuotaGib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity_quota_gib");
        set => this.WithProperty("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageCapacityReservationGib
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity_reservation_gib");
        set => this.WithProperty("storage_capacity_reservation_gib", value);
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
    /// The volume_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_type");
        set => this.WithProperty("volume_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
