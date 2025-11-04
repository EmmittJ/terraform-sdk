using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ebs_snapshot_copy resource.
/// </summary>
public class AwsEbsSnapshotCopy : TerraformResource
{
    public AwsEbsSnapshotCopy(string name) : base("aws_ebs_snapshot_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("data_encryption_key_id");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_alias");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("volume_id");
        this.DeclareOutput("volume_size");
    }

    /// <summary>
    /// The completion_duration_minutes attribute.
    /// </summary>
    public double? CompletionDurationMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("completion_duration_minutes")?.Value;
        set => this.WithProperty("completion_duration_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The permanent_restore attribute.
    /// </summary>
    public bool? PermanentRestore
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("permanent_restore")?.Value;
        set => this.WithProperty("permanent_restore", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public string? SourceRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_region")?.Value;
        set => this.WithProperty("source_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_snapshot_id attribute.
    /// </summary>
    public string? SourceSnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_snapshot_id")?.Value;
        set => this.WithProperty("source_snapshot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public string? StorageTier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_tier")?.Value;
        set => this.WithProperty("storage_tier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The temporary_restore_days attribute.
    /// </summary>
    public double? TemporaryRestoreDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("temporary_restore_days")?.Value;
        set => this.WithProperty("temporary_restore_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    public TerraformExpression DataEncryptionKeyId => this["data_encryption_key_id"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    public TerraformExpression OwnerAlias => this["owner_alias"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformExpression VolumeSize => this["volume_size"];

}
