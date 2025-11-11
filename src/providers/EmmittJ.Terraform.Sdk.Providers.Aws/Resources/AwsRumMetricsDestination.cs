using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rum_metrics_destination resource.
/// </summary>
public partial class AwsRumMetricsDestination : TerraformResource
{
    public AwsRumMetricsDestination(string name) : base("aws_rum_metrics_destination", name)
    {
    }

    /// <summary>
    /// The app_monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppMonitorName is required")]
    [TerraformProperty("app_monitor_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppMonitorName { get; set; }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [TerraformProperty("destination_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationArn { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
