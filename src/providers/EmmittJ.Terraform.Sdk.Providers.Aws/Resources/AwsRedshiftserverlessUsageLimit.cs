using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_usage_limit resource.
/// </summary>
public partial class AwsRedshiftserverlessUsageLimit : TerraformResource
{
    public AwsRedshiftserverlessUsageLimit(string name) : base("aws_redshiftserverless_usage_limit", name)
    {
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformProperty("amount")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Amount { get; set; }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    [TerraformProperty("breach_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BreachAction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformProperty("period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Period { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformProperty("resource_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageType is required")]
    [TerraformProperty("usage_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UsageType { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
