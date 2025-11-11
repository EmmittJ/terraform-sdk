using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_synthetics_group_association resource.
/// </summary>
public partial class AwsSyntheticsGroupAssociation : TerraformResource
{
    public AwsSyntheticsGroupAssociation(string name) : base("aws_synthetics_group_association", name)
    {
    }

    /// <summary>
    /// The canary_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanaryArn is required")]
    [TerraformProperty("canary_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CanaryArn { get; set; }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    [TerraformProperty("group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GroupName { get; set; }

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
    /// The group_arn attribute.
    /// </summary>
    [TerraformProperty("group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GroupArn { get; }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [TerraformProperty("group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GroupId { get; }

}
