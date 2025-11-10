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
        SetOutput("id");
        SetOutput("cluster_identifier");
        SetOutput("destination_region");
        SetOutput("manual_snapshot_retention_period");
        SetOutput("region");
        SetOutput("retention_period");
        SetOutput("snapshot_copy_grant_name");
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRegion is required")]
    public required TerraformProperty<string> DestinationRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_region");
        set => SetProperty("destination_region", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> ManualSnapshotRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("manual_snapshot_retention_period");
        set => SetProperty("manual_snapshot_retention_period", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double> RetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_period");
        set => SetProperty("retention_period", value);
    }

    /// <summary>
    /// The snapshot_copy_grant_name attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotCopyGrantName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_copy_grant_name");
        set => SetProperty("snapshot_copy_grant_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
