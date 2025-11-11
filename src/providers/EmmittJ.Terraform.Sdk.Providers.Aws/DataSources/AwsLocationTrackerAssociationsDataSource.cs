using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_tracker_associations.
/// </summary>
public partial class AwsLocationTrackerAssociationsDataSource : TerraformDataSource
{
    public AwsLocationTrackerAssociationsDataSource(string name) : base("aws_location_tracker_associations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    [TerraformProperty("tracker_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrackerName { get; set; }

    /// <summary>
    /// The consumer_arns attribute.
    /// </summary>
    [TerraformProperty("consumer_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ConsumerArns { get; }

}
