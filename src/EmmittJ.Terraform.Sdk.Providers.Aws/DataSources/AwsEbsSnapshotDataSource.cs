using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ebs_snapshot.
/// </summary>
public class AwsEbsSnapshotDataSource : TerraformDataSource
{
    public AwsEbsSnapshotDataSource(string name) : base("aws_ebs_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("data_encryption_key_id");
        this.DeclareOutput("description");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_alias");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("snapshot_id");
        this.DeclareOutput("start_time");
        this.DeclareOutput("state");
        this.DeclareOutput("storage_tier");
        this.DeclareOutput("volume_id");
        this.DeclareOutput("volume_size");
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
    /// The most_recent attribute.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent")?.Value;
        set => this.WithProperty("most_recent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public List<string>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("owners")?.Value;
        set => this.WithProperty("owners", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The restorable_by_user_ids attribute.
    /// </summary>
    public List<string>? RestorableByUserIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("restorable_by_user_ids")?.Value;
        set => this.WithProperty("restorable_by_user_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The snapshot_ids attribute.
    /// </summary>
    public List<string>? SnapshotIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("snapshot_ids")?.Value;
        set => this.WithProperty("snapshot_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    public TerraformExpression DataEncryptionKeyId => this["data_encryption_key_id"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformExpression SnapshotId => this["snapshot_id"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    public TerraformExpression StorageTier => this["storage_tier"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformExpression VolumeSize => this["volume_size"];

}
