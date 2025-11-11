using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_dashboard resource.
/// </summary>
public partial class AwsCloudwatchDashboard : TerraformResource
{
    public AwsCloudwatchDashboard(string name) : base("aws_cloudwatch_dashboard", name)
    {
    }

    /// <summary>
    /// The dashboard_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardBody is required")]
    [TerraformProperty("dashboard_body")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DashboardBody { get; set; }

    /// <summary>
    /// The dashboard_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardName is required")]
    [TerraformProperty("dashboard_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DashboardName { get; set; }

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
    /// The dashboard_arn attribute.
    /// </summary>
    [TerraformProperty("dashboard_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DashboardArn { get; }

}
