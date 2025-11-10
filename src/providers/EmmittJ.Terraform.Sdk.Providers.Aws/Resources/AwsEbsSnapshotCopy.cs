using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotCopyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("data_encryption_key_id");
        this.WithOutput("outpost_arn");
        this.WithOutput("owner_alias");
        this.WithOutput("owner_id");
        this.WithOutput("volume_id");
        this.WithOutput("volume_size");
    }

    /// <summary>
    /// The completion_duration_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? CompletionDurationMinutes
    {
        get => GetProperty<TerraformProperty<double>>("completion_duration_minutes");
        set => this.WithProperty("completion_duration_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => this.WithProperty("encrypted", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    public TerraformProperty<bool>? PermanentRestore
    {
        get => GetProperty<TerraformProperty<bool>>("permanent_restore");
        set => this.WithProperty("permanent_restore", value);
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
    /// The source_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRegion is required")]
    public required TerraformProperty<string> SourceRegion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_region");
        set => this.WithProperty("source_region", value);
    }

    /// <summary>
    /// The source_snapshot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSnapshotId is required")]
    public required TerraformProperty<string> SourceSnapshotId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_snapshot_id");
        set => this.WithProperty("source_snapshot_id", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformProperty<string>? StorageTier
    {
        get => GetProperty<TerraformProperty<string>>("storage_tier");
        set => this.WithProperty("storage_tier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The temporary_restore_days attribute.
    /// </summary>
    public TerraformProperty<double>? TemporaryRestoreDays
    {
        get => GetProperty<TerraformProperty<double>>("temporary_restore_days");
        set => this.WithProperty("temporary_restore_days", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsSnapshotCopyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEbsSnapshotCopyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
