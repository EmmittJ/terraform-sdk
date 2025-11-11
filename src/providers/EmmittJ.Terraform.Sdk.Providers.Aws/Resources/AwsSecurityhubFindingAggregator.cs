using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_finding_aggregator resource.
/// </summary>
public partial class AwsSecurityhubFindingAggregator : TerraformResource
{
    public AwsSecurityhubFindingAggregator(string name) : base("aws_securityhub_finding_aggregator", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linking_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkingMode is required")]
    [TerraformProperty("linking_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkingMode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The specified_regions attribute.
    /// </summary>
    [TerraformProperty("specified_regions")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SpecifiedRegions { get; set; }

}
