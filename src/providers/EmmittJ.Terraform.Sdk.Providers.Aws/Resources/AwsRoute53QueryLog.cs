using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_query_log resource.
/// </summary>
public partial class AwsRoute53QueryLog : TerraformResource
{
    public AwsRoute53QueryLog(string name) : base("aws_route53_query_log", name)
    {
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    [TerraformProperty("cloudwatch_log_group_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformProperty("zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
