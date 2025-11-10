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
        SetOutput("cluster_identifier");
        SetOutput("id");
        SetOutput("region");
        SetOutput("schedule_identifier");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The schedule_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleIdentifier is required")]
    public required TerraformProperty<string> ScheduleIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_identifier");
        set => SetProperty("schedule_identifier", value);
    }

}
