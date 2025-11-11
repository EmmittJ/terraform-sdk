using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_account_suppression_attributes resource.
/// </summary>
public partial class AwsSesv2AccountSuppressionAttributes : TerraformResource
{
    public AwsSesv2AccountSuppressionAttributes(string name) : base("aws_sesv2_account_suppression_attributes", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SuppressedReasons is required")]
    [TerraformProperty("suppressed_reasons")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SuppressedReasons { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
