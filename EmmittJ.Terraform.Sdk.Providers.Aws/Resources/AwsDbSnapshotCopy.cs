using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_snapshot_copy resource.
/// </summary>
public class AwsDbSnapshotCopy : TerraformResource
{
    public AwsDbSnapshotCopy(string name) : base("aws_db_snapshot_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("db_snapshot_arn");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("iops");
        this.DeclareOutput("license_model");
        this.DeclareOutput("port");
        this.DeclareOutput("snapshot_type");
        this.DeclareOutput("source_region");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public bool? CopyTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags")?.Value;
        set => this.WithProperty("copy_tags", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public string? DestinationRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_region")?.Value;
        set => this.WithProperty("destination_region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The option_group_name attribute.
    /// </summary>
    public string? OptionGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("option_group_name")?.Value;
        set => this.WithProperty("option_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    public string? PresignedUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("presigned_url")?.Value;
        set => this.WithProperty("presigned_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    public HashSet<string>? SharedAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("shared_accounts")?.Value;
        set => this.WithProperty("shared_accounts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    public string? SourceDbSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_db_snapshot_identifier")?.Value;
        set => this.WithProperty("source_db_snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_custom_availability_zone attribute.
    /// </summary>
    public string? TargetCustomAvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_custom_availability_zone")?.Value;
        set => this.WithProperty("target_custom_availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_db_snapshot_identifier attribute.
    /// </summary>
    public string? TargetDbSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_db_snapshot_identifier")?.Value;
        set => this.WithProperty("target_db_snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformExpression AllocatedStorage => this["allocated_storage"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    public TerraformExpression DbSnapshotArn => this["db_snapshot_arn"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformExpression Iops => this["iops"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformExpression SnapshotType => this["snapshot_type"];

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformExpression SourceRegion => this["source_region"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
