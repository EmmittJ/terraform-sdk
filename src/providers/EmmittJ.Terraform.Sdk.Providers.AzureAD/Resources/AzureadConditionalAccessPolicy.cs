using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlock : ITerraformBlock
{
    /// <summary>
    /// The client_app_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientAppTypes is required")]
    [TerraformPropertyName("client_app_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ClientAppTypes { get; set; }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("insider_risk_levels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InsiderRiskLevels { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "insider_risk_levels");

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("service_principal_risk_levels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ServicePrincipalRiskLevels { get; set; }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_risk_levels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SignInRiskLevels { get; set; }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    [TerraformPropertyName("user_risk_levels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? UserRiskLevels { get; set; }

}

/// <summary>
/// Block type for grant_controls in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyGrantControlsBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_strength_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("authentication_strength_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthenticationStrengthPolicyId { get; set; }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    [TerraformPropertyName("built_in_controls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? BuiltInControls { get; set; }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    [TerraformPropertyName("custom_authentication_factors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CustomAuthenticationFactors { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformPropertyName("operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Operator { get; set; }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    [TerraformPropertyName("terms_of_use")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TermsOfUse { get; set; }

}

/// <summary>
/// Block type for session_controls in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicySessionControlsBlock : ITerraformBlock
{
    /// <summary>
    /// The application_enforced_restrictions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("application_enforced_restrictions_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApplicationEnforcedRestrictionsEnabled { get; set; }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    [TerraformPropertyName("cloud_app_security_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudAppSecurityPolicy { get; set; }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    [TerraformPropertyName("disable_resilience_defaults")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableResilienceDefaults { get; set; }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    [TerraformPropertyName("persistent_browser_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PersistentBrowserMode { get; set; }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SignInFrequency { get; set; }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency_authentication_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SignInFrequencyAuthenticationType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "sign_in_frequency_authentication_type");

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency_interval")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SignInFrequencyInterval { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "sign_in_frequency_interval");

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    [TerraformPropertyName("sign_in_frequency_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SignInFrequencyPeriod { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadConditionalAccessPolicyTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> State { get; set; }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    [TerraformPropertyName("conditions")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicyConditionsBlock>>? Conditions { get; set; } = new();

    /// <summary>
    /// Block for grant_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrantControls block(s) allowed")]
    [TerraformPropertyName("grant_controls")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicyGrantControlsBlock>>? GrantControls { get; set; } = new();

    /// <summary>
    /// Block for session_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionControls block(s) allowed")]
    [TerraformPropertyName("session_controls")]
    public TerraformList<TerraformBlock<AzureadConditionalAccessPolicySessionControlsBlock>>? SessionControls { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadConditionalAccessPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

}
