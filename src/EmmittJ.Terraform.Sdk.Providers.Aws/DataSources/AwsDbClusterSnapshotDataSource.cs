using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_cluster_snapshot.
/// </summary>
public class AwsDbClusterSnapshotDataSource : TerraformDataSource
{
    public AwsDbClusterSnapshotDataSource(string name) : base("aws_db_cluster_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("db_cluster_snapshot_arn");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("license_model");
        this.DeclareOutput("port");
        this.DeclareOutput("snapshot_create_time");
        this.DeclareOutput("source_db_cluster_snapshot_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_identifier");
        set => this.WithProperty("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_cluster_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_snapshot_identifier");
        set => this.WithProperty("db_cluster_snapshot_identifier", value);
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    public TerraformExpression DbClusterSnapshotArn => this["db_cluster_snapshot_arn"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    public TerraformExpression SnapshotCreateTime => this["snapshot_create_time"];

    /// <summary>
    /// The source_db_cluster_snapshot_arn attribute.
    /// </summary>
    public TerraformExpression SourceDbClusterSnapshotArn => this["source_db_cluster_snapshot_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
