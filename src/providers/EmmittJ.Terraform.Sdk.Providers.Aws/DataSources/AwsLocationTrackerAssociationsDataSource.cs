using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_location_tracker_associations Terraform data source.
/// Retrieves information about a aws_location_tracker_associations.
/// </summary>
public partial class AwsLocationTrackerAssociationsDataSource(string name) : TerraformDataSource("aws_location_tracker_associations", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    public required TerraformValue<string> TrackerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("tracker_name");
        set => SetArgument("tracker_name", value);
    }

    /// <summary>
    /// The consumer_arns attribute.
    /// </summary>
    public TerraformSet<string> ConsumerArns
        => CreateReference("consumer_arns");

}
