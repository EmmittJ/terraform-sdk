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
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("db_snapshot_arn");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("iops");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("license_model");
        this.DeclareOutput("option_group_name");
        this.DeclareOutput("original_snapshot_create_time");
        this.DeclareOutput("port");
        this.DeclareOutput("snapshot_create_time");
        this.DeclareOutput("source_db_snapshot_identifier");
        this.DeclareOutput("source_region");
        this.DeclareOutput("status");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbInstanceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_instance_identifier");
        set => this.WithProperty("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_snapshot_identifier");
        set => this.WithProperty("db_snapshot_identifier", value);
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
    /// The include_public attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludePublic
    {
        get => GetProperty<TerraformProperty<bool>>("include_public");
        set => this.WithProperty("include_public", value);
    }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeShared
    {
        get => GetProperty<TerraformProperty<bool>>("include_shared");
        set => this.WithProperty("include_shared", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
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
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotType
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_type");
        set => this.WithProperty("snapshot_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
