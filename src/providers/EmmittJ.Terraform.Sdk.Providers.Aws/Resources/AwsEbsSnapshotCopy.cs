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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("arn");
        SetOutput("data_encryption_key_id");
        SetOutput("outpost_arn");
        SetOutput("owner_alias");
        SetOutput("owner_id");
        SetOutput("volume_id");
        SetOutput("volume_size");
        SetOutput("completion_duration_minutes");
        SetOutput("description");
        SetOutput("encrypted");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("permanent_restore");
        SetOutput("region");
        SetOutput("source_region");
        SetOutput("source_snapshot_id");
        SetOutput("storage_tier");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("temporary_restore_days");
    }

    /// <summary>
    /// The completion_duration_minutes attribute.
    /// </summary>
    public TerraformProperty<double> CompletionDurationMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("completion_duration_minutes");
        set => SetProperty("completion_duration_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> Encrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encrypted");
        set => SetProperty("encrypted", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The permanent_restore attribute.
    /// </summary>
    public TerraformProperty<bool> PermanentRestore
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("permanent_restore");
        set => SetProperty("permanent_restore", value);
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
    /// The source_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRegion is required")]
    public required TerraformProperty<string> SourceRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_region");
        set => SetProperty("source_region", value);
    }

    /// <summary>
    /// The source_snapshot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSnapshotId is required")]
    public required TerraformProperty<string> SourceSnapshotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_snapshot_id");
        set => SetProperty("source_snapshot_id", value);
    }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformProperty<string> StorageTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_tier");
        set => SetProperty("storage_tier", value);
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
    /// The temporary_restore_days attribute.
    /// </summary>
    public TerraformProperty<double> TemporaryRestoreDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("temporary_restore_days");
        set => SetProperty("temporary_restore_days", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsSnapshotCopyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
