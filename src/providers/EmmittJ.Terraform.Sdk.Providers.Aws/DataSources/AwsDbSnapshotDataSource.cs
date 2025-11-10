using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_snapshot.
/// </summary>
public class AwsDbSnapshotDataSource : TerraformDataSource
{
    public AwsDbSnapshotDataSource(string name) : base("aws_db_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocated_storage");
        SetOutput("availability_zone");
        SetOutput("db_snapshot_arn");
        SetOutput("encrypted");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("iops");
        SetOutput("kms_key_id");
        SetOutput("license_model");
        SetOutput("option_group_name");
        SetOutput("original_snapshot_create_time");
        SetOutput("port");
        SetOutput("snapshot_create_time");
        SetOutput("source_db_snapshot_identifier");
        SetOutput("source_region");
        SetOutput("status");
        SetOutput("storage_type");
        SetOutput("vpc_id");
        SetOutput("db_instance_identifier");
        SetOutput("db_snapshot_identifier");
        SetOutput("id");
        SetOutput("include_public");
        SetOutput("include_shared");
        SetOutput("most_recent");
        SetOutput("region");
        SetOutput("snapshot_type");
        SetOutput("tags");
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string> DbInstanceIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_instance_identifier");
        set => SetProperty("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> DbSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_snapshot_identifier");
        set => SetProperty("db_snapshot_identifier", value);
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
    /// The include_public attribute.
    /// </summary>
    public TerraformProperty<bool> IncludePublic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_public");
        set => SetProperty("include_public", value);
    }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeShared
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_shared");
        set => SetProperty("include_shared", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool> MostRecent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("most_recent");
        set => SetProperty("most_recent", value);
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
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_type");
        set => SetProperty("snapshot_type", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformExpression OptionGroupName => this["option_group_name"];

    /// <summary>
    /// The original_snapshot_create_time attribute.
    /// </summary>
    public TerraformExpression OriginalSnapshotCreateTime => this["original_snapshot_create_time"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    public TerraformExpression SnapshotCreateTime => this["snapshot_create_time"];

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    public TerraformExpression SourceDbSnapshotIdentifier => this["source_db_snapshot_identifier"];

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformExpression SourceRegion => this["source_region"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
