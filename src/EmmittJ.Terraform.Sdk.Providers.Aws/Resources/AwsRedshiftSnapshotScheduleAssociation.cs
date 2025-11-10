using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_snapshot_schedule_association resource.
/// </summary>
public class AwsRedshiftSnapshotScheduleAssociation : TerraformResource
{
    public AwsRedshiftSnapshotScheduleAssociation(string name) : base("aws_redshift_snapshot_schedule_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The schedule_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleIdentifier is required")]
    public required TerraformProperty<string> ScheduleIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("schedule_identifier");
        set => this.WithProperty("schedule_identifier", value);
    }

}
