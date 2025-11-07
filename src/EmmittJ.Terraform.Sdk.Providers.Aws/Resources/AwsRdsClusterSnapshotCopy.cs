using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_snapshot_copy resource.
/// </summary>
public class AwsRdsClusterSnapshotCopy : TerraformResource
{
    public AwsRdsClusterSnapshotCopy(string name) : base("aws_rds_cluster_snapshot_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("db_cluster_snapshot_arn");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("id");
        this.DeclareOutput("license_model");
        this.DeclareOutput("snapshot_type");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CopyTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags");
        set => this.WithProperty("copy_tags", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_region");
        set => this.WithProperty("destination_region", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PresignedUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("presigned_url");
        set => this.WithProperty("presigned_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SharedAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("shared_accounts");
        set => this.WithProperty("shared_accounts", value);
    }

    /// <summary>
    /// The source_db_cluster_snapshot_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceDbClusterSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_db_cluster_snapshot_identifier");
        set => this.WithProperty("source_db_cluster_snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The target_db_cluster_snapshot_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetDbClusterSnapshotIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_db_cluster_snapshot_identifier");
        set => this.WithProperty("target_db_cluster_snapshot_identifier", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformExpression AllocatedStorage => this["allocated_storage"];

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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformExpression SnapshotType => this["snapshot_type"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
