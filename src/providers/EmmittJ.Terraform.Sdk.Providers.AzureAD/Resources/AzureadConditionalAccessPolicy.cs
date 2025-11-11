using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlock
{
    /// <summary>
    /// The client_app_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientAppTypes is required")]
    [TerraformPropertyName("client_app_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? ClientAppTypes { get; set; }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("insider_risk_levels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InsiderRiskLevels { get; set; } = default!;

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("service_principal_risk_levels")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ServicePrincipalRiskLevels { get; set; }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_risk_levels")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SignInRiskLevels { get; set; }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("user_risk_levels")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? UserRiskLevels { get; set; }

}

/// <summary>
/// Block type for grant_controls in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyGrantControlsBlock
{
    /// <summary>
    /// The authentication_strength_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("authentication_strength_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthenticationStrengthPolicyId { get; set; }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    [TerraformPropertyName("built_in_controls")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? BuiltInControls { get; set; }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    [TerraformPropertyName("custom_authentication_factors")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CustomAuthenticationFactors { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformPropertyName("operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    [TerraformPropertyName("terms_of_use")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TermsOfUse { get; set; }

}

/// <summary>
/// Block type for session_controls in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicySessionControlsBlock
{
    /// <summary>
    /// The application_enforced_restrictions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("application_enforced_restrictions_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApplicationEnforcedRestrictionsEnabled { get; set; }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    [TerraformPropertyName("cloud_app_security_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudAppSecurityPolicy { get; set; }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    [TerraformPropertyName("disable_resilience_defaults")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableResilienceDefaults { get; set; }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    [TerraformPropertyName("persistent_browser_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PersistentBrowserMode { get; set; }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SignInFrequency { get; set; }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency_authentication_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SignInFrequencyAuthenticationType { get; set; } = default!;

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency_interval")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SignInFrequencyInterval { get; set; } = default!;

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency_period")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SignInFrequencyPeriod { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadConditionalAccessPolicyTimeoutsBlock
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
/// Manages a azuread_conditional_access_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadConditionalAccessPolicy : TerraformResource
{
    public AzureadConditionalAccessPolicy(string name) : base("azuread_conditional_access_policy", name)
    {
    }

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
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> State { get; set; }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    [TerraformPropertyName("conditions")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicyConditionsBlock>>? Conditions { get; set; }

    /// <summary>
    /// Block for grant_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrantControls block(s) allowed")]
    [TerraformPropertyName("grant_controls")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicyGrantControlsBlock>>? GrantControls { get; set; }

    /// <summary>
    /// Block for session_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionControls block(s) allowed")]
    [TerraformPropertyName("session_controls")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicySessionControlsBlock>>? SessionControls { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadConditionalAccessPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectId => new TerraformReference(this, "object_id");

}
