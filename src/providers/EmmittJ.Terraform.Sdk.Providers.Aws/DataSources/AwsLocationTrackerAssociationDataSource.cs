using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_location_tracker_association Terraform data source.
/// Retrieves information about a aws_location_tracker_association.
/// </summary>
public partial class AwsLocationTrackerAssociationDataSource(string name) : TerraformDataSource("aws_location_tracker_association", name)
{
    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerArn is required")]
    public required TerraformValue<string> ConsumerArn
    {
        get => new TerraformReference<string>(this, "consumer_arn");
        set => SetArgument("consumer_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    public required TerraformValue<string> TrackerName
    {
        get => new TerraformReference<string>(this, "tracker_name");
        set => SetArgument("tracker_name", value);
    }

}
