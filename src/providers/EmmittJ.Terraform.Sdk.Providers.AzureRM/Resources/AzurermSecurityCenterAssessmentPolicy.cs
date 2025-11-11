using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSecurityCenterAssessmentPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_security_center_assessment_policy resource.
/// </summary>
public partial class AzurermSecurityCenterAssessmentPolicy : TerraformResource
{
    public AzurermSecurityCenterAssessmentPolicy(string name) : base("azurerm_security_center_assessment_policy", name)
    {
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    [TerraformProperty("categories")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Categories { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The implementation_effort attribute.
    /// </summary>
    [TerraformProperty("implementation_effort")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImplementationEffort { get; set; }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    [TerraformProperty("remediation_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RemediationDescription { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformProperty("severity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Severity { get; set; }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    [TerraformProperty("threats")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Threats { get; set; }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    [TerraformProperty("user_impact")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserImpact { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSecurityCenterAssessmentPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
