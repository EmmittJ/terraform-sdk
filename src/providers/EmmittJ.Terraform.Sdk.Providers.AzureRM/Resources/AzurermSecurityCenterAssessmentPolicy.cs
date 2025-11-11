using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_security_center_assessment_policy resource.
/// </summary>
public class AzurermSecurityCenterAssessmentPolicy : TerraformResource
{
    public AzurermSecurityCenterAssessmentPolicy(string name) : base("azurerm_security_center_assessment_policy", name)
    {
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    [TerraformPropertyName("categories")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Categories { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The implementation_effort attribute.
    /// </summary>
    [TerraformPropertyName("implementation_effort")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImplementationEffort { get; set; }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    [TerraformPropertyName("remediation_description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RemediationDescription { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformPropertyName("severity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Severity { get; set; }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    [TerraformPropertyName("threats")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Threats { get; set; }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    [TerraformPropertyName("user_impact")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserImpact { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSecurityCenterAssessmentPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
