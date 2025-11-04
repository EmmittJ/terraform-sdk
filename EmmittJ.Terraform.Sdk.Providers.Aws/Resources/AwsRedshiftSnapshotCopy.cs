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
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public double? ManualSnapshotRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("manual_snapshot_retention_period")?.Value;
        set => this.WithProperty("manual_snapshot_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The retention_period attribute.
    /// </summary>
    public double? RetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period")?.Value;
        set => this.WithProperty("retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The snapshot_copy_grant_name attribute.
    /// </summary>
    public string? SnapshotCopyGrantName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_copy_grant_name")?.Value;
        set => this.WithProperty("snapshot_copy_grant_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
