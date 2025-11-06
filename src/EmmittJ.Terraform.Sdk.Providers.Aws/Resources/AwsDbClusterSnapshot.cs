using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_cluster_snapshot resource.
/// </summary>
public class AwsDbClusterSnapshot : TerraformResource
{
    public AwsDbClusterSnapshot(string name) : base("aws_db_cluster_snapshot", name)
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
        this.DeclareOutput("snapshot_type");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformExpression SnapshotType => this["snapshot_type"];

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
