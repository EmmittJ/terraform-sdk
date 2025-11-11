using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public partial class AzureadConditionalAccessPolicyConditionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_app_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientAppTypes is required")]
    [TerraformProperty("client_app_types")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ClientAppTypes { get; set; }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    [TerraformProperty("insider_risk_levels")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InsiderRiskLevels { get; set; }

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    [TerraformProperty("service_principal_risk_levels")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ServicePrincipalRiskLevels { get; set; }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    [TerraformProperty("sign_in_risk_levels")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SignInRiskLevels { get; set; }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    [TerraformProperty("user_risk_levels")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? UserRiskLevels { get; set; }

}

/// <summary>
/// Block type for grant_controls in .
/// Nesting mode: list
/// </summary>
public partial class AzureadConditionalAccessPolicyGrantControlsBlock : TerraformBlockBase
{
    /// <summary>
    /// The authentication_strength_policy_id attribute.
    /// </summary>
    [TerraformProperty("authentication_strength_policy_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthenticationStrengthPolicyId { get; set; }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    [TerraformProperty("built_in_controls")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? BuiltInControls { get; set; }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    [TerraformProperty("custom_authentication_factors")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CustomAuthenticationFactors { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformProperty("operator")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    [TerraformProperty("terms_of_use")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TermsOfUse { get; set; }

}

/// <summary>
/// Block type for session_controls in .
/// Nesting mode: list
/// </summary>
public partial class AzureadConditionalAccessPolicySessionControlsBlock : TerraformBlockBase
{
    /// <summary>
    /// The application_enforced_restrictions_enabled attribute.
    /// </summary>
    [TerraformProperty("application_enforced_restrictions_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ApplicationEnforcedRestrictionsEnabled { get; set; }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    [TerraformProperty("cloud_app_security_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CloudAppSecurityPolicy { get; set; }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    [TerraformProperty("disable_resilience_defaults")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableResilienceDefaults { get; set; }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    [TerraformProperty("persistent_browser_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PersistentBrowserMode { get; set; }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    [TerraformProperty("sign_in_frequency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SignInFrequency { get; set; }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    [TerraformProperty("sign_in_frequency_authentication_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SignInFrequencyAuthenticationType { get; set; }

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    [TerraformProperty("sign_in_frequency_interval")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SignInFrequencyInterval { get; set; }

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    [TerraformProperty("sign_in_frequency_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SignInFrequencyPeriod { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadConditionalAccessPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_conditional_access_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadConditionalAccessPolicy : TerraformResource
{
    public AzureadConditionalAccessPolicy(string name) : base("azuread_conditional_access_policy", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> State { get; set; }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    [TerraformProperty("conditions")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicyConditionsBlock>>? Conditions { get; set; }

    /// <summary>
    /// Block for grant_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrantControls block(s) allowed")]
    [TerraformProperty("grant_controls")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicyGrantControlsBlock>>? GrantControls { get; set; }

    /// <summary>
    /// Block for session_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionControls block(s) allowed")]
    [TerraformProperty("session_controls")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicySessionControlsBlock>>? SessionControls { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadConditionalAccessPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObjectId { get; }

}
