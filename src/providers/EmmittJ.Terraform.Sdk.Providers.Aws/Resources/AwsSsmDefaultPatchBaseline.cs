using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_default_patch_baseline resource.
/// </summary>
public partial class AwsSsmDefaultPatchBaseline : TerraformResource
{
    public AwsSsmDefaultPatchBaseline(string name) : base("aws_ssm_default_patch_baseline", name)
    {
    }

    /// <summary>
    /// The baseline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaselineId is required")]
    [TerraformProperty("baseline_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BaselineId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingSystem is required")]
    [TerraformProperty("operating_system")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OperatingSystem { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
