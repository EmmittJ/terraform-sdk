using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_applications in .
/// Nesting mode: set
/// </summary>
public partial class AwsChimesdkvoiceSipRuleTargetApplicationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRegion is required")]
    [TerraformProperty("aws_region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AwsRegion { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The sip_media_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SipMediaApplicationId is required")]
    [TerraformProperty("sip_media_application_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SipMediaApplicationId { get; set; }

}

/// <summary>
/// Manages a aws_chimesdkvoice_sip_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsChimesdkvoiceSipRule : TerraformResource
{
    public AwsChimesdkvoiceSipRule(string name) : base("aws_chimesdkvoice_sip_rule", name)
    {
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    [TerraformProperty("trigger_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TriggerType { get; set; }

    /// <summary>
    /// The trigger_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerValue is required")]
    [TerraformProperty("trigger_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TriggerValue { get; set; }

    /// <summary>
    /// Block for target_applications.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetApplications is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetApplications block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 TargetApplications block(s) allowed")]
    [TerraformProperty("target_applications")]
    public TerraformSet<TerraformBlock<AwsChimesdkvoiceSipRuleTargetApplicationsBlock>>? TargetApplications { get; set; }

}
