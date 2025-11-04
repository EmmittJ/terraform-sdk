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
    public string? DbClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_cluster_identifier")?.Value;
        set => this.WithProperty("db_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_cluster_snapshot_identifier attribute.
    /// </summary>
    public string? DbClusterSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_cluster_snapshot_identifier")?.Value;
        set => this.WithProperty("db_cluster_snapshot_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The include_public attribute.
    /// </summary>
    public bool? IncludePublic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_public")?.Value;
        set => this.WithProperty("include_public", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    public bool? IncludeShared
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_shared")?.Value;
        set => this.WithProperty("include_shared", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The snapshot_type attribute.
    /// </summary>
    public string? SnapshotType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_type")?.Value;
        set => this.WithProperty("snapshot_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
