using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_snapshot_copy Terraform resource.
/// Manages a aws_redshift_snapshot_copy resource.
/// </summary>
public partial class AwsRedshiftSnapshotCopy(string name) : TerraformResource("aws_redshift_snapshot_copy", name)
{
    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRegion is required")]
    public required TerraformValue<string> DestinationRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_region");
        set => SetArgument("destination_region", value);
    }

    /// <summary>
    /// The manual_snapshot_retention_period attribute.
    /// </summary>
    public TerraformValue<double> ManualSnapshotRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("manual_snapshot_retention_period") ?? AsReference("manual_snapshot_retention_period");
        set => SetArgument("manual_snapshot_retention_period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double> RetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("retention_period") ?? AsReference("retention_period");
        set => SetArgument("retention_period", value);
    }

    /// <summary>
    /// The snapshot_copy_grant_name attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotCopyGrantName
    {
        get => GetArgument<TerraformValue<string>>("snapshot_copy_grant_name");
        set => SetArgument("snapshot_copy_grant_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
