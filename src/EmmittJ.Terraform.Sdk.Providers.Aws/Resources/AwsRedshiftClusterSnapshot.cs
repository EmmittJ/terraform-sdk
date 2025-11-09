using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_cluster_snapshot resource.
/// </summary>
public class AwsRedshiftClusterSnapshot : TerraformResource
{
    public AwsRedshiftClusterSnapshot(string name) : base("aws_redshift_cluster_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("owner_account");
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
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
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? ManualSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("manual_snapshot_retention_period");
        set => this.WithProperty("manual_snapshot_retention_period", value);
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
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The owner_account attribute.
    /// </summary>
    public TerraformExpression OwnerAccount => this["owner_account"];

}
