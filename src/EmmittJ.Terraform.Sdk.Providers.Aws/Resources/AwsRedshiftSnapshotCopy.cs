using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_snapshot_copy resource.
/// </summary>
public class AwsRedshiftSnapshotCopy : TerraformResource
{
    public AwsRedshiftSnapshotCopy(string name) : base("aws_redshift_snapshot_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
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
    /// The destination_region attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationRegion
    {
        get => GetProperty<TerraformProperty<string>>("destination_region");
        set => this.WithProperty("destination_region", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("retention_period");
        set => this.WithProperty("retention_period", value);
    }

    /// <summary>
    /// The snapshot_copy_grant_name attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotCopyGrantName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_copy_grant_name");
        set => this.WithProperty("snapshot_copy_grant_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
