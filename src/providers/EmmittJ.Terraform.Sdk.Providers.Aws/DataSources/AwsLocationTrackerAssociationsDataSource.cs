using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_tracker_associations.
/// </summary>
public class AwsLocationTrackerAssociationsDataSource : TerraformDataSource
{
    public AwsLocationTrackerAssociationsDataSource(string name) : base("aws_location_tracker_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("consumer_arns");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tracker_name");
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

    /// <summary>
    /// The consumer_arns attribute.
    /// </summary>
    public TerraformExpression ConsumerArns => this["consumer_arns"];

}
