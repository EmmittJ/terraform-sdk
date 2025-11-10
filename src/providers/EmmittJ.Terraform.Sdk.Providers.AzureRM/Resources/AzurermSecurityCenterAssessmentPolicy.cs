using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Categories { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "categories");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The implementation_effort attribute.
    /// </summary>
    [TerraformPropertyName("implementation_effort")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImplementationEffort { get; set; }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    [TerraformPropertyName("remediation_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RemediationDescription { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformPropertyName("severity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Severity { get; set; }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    [TerraformPropertyName("threats")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Threats { get; set; }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    [TerraformPropertyName("user_impact")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserImpact { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSecurityCenterAssessmentPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
