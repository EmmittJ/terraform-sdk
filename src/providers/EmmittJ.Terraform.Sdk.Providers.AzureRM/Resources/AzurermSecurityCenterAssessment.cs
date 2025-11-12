using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for status in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSecurityCenterAssessmentStatusBlock() : TerraformBlock("status")
{
    /// <summary>
    /// The cause attribute.
    /// </summary>
    [TerraformProperty("cause")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cause { get; set; }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    [TerraformProperty("code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Code { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSecurityCenterAssessmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_security_center_assessment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSecurityCenterAssessment : TerraformResource
{
    public AzurermSecurityCenterAssessment(string name) : base("azurerm_security_center_assessment", name)
    {
    }

    /// <summary>
    /// The additional_data attribute.
    /// </summary>
    [TerraformProperty("additional_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalData { get; set; }

    /// <summary>
    /// The assessment_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentPolicyId is required")]
    [TerraformProperty("assessment_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AssessmentPolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformProperty("target_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetResourceId { get; set; }

    /// <summary>
    /// Block for status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Status block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Status block(s) allowed")]
    [TerraformProperty("status")]
    public required TerraformList<AzurermSecurityCenterAssessmentStatusBlock> Status { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSecurityCenterAssessmentTimeoutsBlock Timeouts { get; set; } = new();

}
