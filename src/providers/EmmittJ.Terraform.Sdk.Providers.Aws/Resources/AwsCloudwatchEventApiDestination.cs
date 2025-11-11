using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_api_destination resource.
/// </summary>
public partial class AwsCloudwatchEventApiDestination : TerraformResource
{
    public AwsCloudwatchEventApiDestination(string name) : base("aws_cloudwatch_event_api_destination", name)
    {
    }

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionArn is required")]
    [TerraformProperty("connection_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformProperty("http_method")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The invocation_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvocationEndpoint is required")]
    [TerraformProperty("invocation_endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InvocationEndpoint { get; set; }

    /// <summary>
    /// The invocation_rate_limit_per_second attribute.
    /// </summary>
    [TerraformProperty("invocation_rate_limit_per_second")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? InvocationRateLimitPerSecond { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
