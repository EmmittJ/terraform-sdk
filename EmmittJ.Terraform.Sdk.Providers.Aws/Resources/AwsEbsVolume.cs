using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ebs_volume resource.
/// </summary>
public class AwsEbsVolume : TerraformResource
{
    public AwsEbsVolume(string name) : base("aws_ebs_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public bool? Encrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encrypted")?.Value;
        set => this.WithProperty("encrypted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The final_snapshot attribute.
    /// </summary>
    public bool? FinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("final_snapshot")?.Value;
        set => this.WithProperty("final_snapshot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The iops attribute.
    /// </summary>
    public double? Iops
    {
        get => GetProperty<TerraformLiteralProperty<double>>("iops")?.Value;
        set => this.WithProperty("iops", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_attach_enabled attribute.
    /// </summary>
    public bool? MultiAttachEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_attach_enabled")?.Value;
        set => this.WithProperty("multi_attach_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public string? OutpostArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_arn")?.Value;
        set => this.WithProperty("outpost_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public double? Size
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size")?.Value;
        set => this.WithProperty("size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The throughput attribute.
    /// </summary>
    public double? Throughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput")?.Value;
        set => this.WithProperty("throughput", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
