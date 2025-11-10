using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_tracker_association.
/// </summary>
public class AwsLocationTrackerAssociationDataSource : TerraformDataSource
{
    public AwsLocationTrackerAssociationDataSource(string name) : base("aws_location_tracker_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("consumer_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tracker_name");
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerArn is required")]
    public required TerraformProperty<string> ConsumerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consumer_arn");
        set => SetProperty("consumer_arn", value);
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
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    public required TerraformProperty<string> TrackerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tracker_name");
        set => SetProperty("tracker_name", value);
    }

}
