using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for conditions in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlock : TerraformBlock
{
    /// <summary>
    /// The client_app_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientAppTypes is required")]
    public List<TerraformProperty<string>>? ClientAppTypes
    {
        set => SetProperty("client_app_types", value);
    }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    public TerraformProperty<string>? InsiderRiskLevels
    {
        set => SetProperty("insider_risk_levels", value);
    }

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ServicePrincipalRiskLevels
    {
        set => SetProperty("service_principal_risk_levels", value);
    }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SignInRiskLevels
    {
        set => SetProperty("sign_in_risk_levels", value);
    }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? UserRiskLevels
    {
        set => SetProperty("user_risk_levels", value);
    }

}

/// <summary>
/// Block type for grant_controls in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyGrantControlsBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_strength_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationStrengthPolicyId
    {
        set => SetProperty("authentication_strength_policy_id", value);
    }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? BuiltInControls
    {
        set => SetProperty("built_in_controls", value);
    }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomAuthenticationFactors
    {
        set => SetProperty("custom_authentication_factors", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TermsOfUse
    {
        set => SetProperty("terms_of_use", value);
    }

}

/// <summary>
/// Block type for session_controls in .
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicySessionControlsBlock : TerraformBlock
{
    /// <summary>
    /// The application_enforced_restrictions_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplicationEnforcedRestrictionsEnabled
    {
        set => SetProperty("application_enforced_restrictions_enabled", value);
    }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? CloudAppSecurityPolicy
    {
        set => SetProperty("cloud_app_security_policy", value);
    }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableResilienceDefaults
    {
        set => SetProperty("disable_resilience_defaults", value);
    }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PersistentBrowserMode
    {
        set => SetProperty("persistent_browser_mode", value);
    }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    public TerraformProperty<double>? SignInFrequency
    {
        set => SetProperty("sign_in_frequency", value);
    }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? SignInFrequencyAuthenticationType
    {
        set => SetProperty("sign_in_frequency_authentication_type", value);
    }

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    public TerraformProperty<string>? SignInFrequencyInterval
    {
        set => SetProperty("sign_in_frequency_interval", value);
    }

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    public TerraformProperty<string>? SignInFrequencyPeriod
    {
        set => SetProperty("sign_in_frequency_period", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadConditionalAccessPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_conditional_access_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadConditionalAccessPolicy : TerraformResource
{
    public AzureadConditionalAccessPolicy(string name) : base("azuread_conditional_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("object_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("state");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public List<AzureadConditionalAccessPolicyConditionsBlock>? Conditions
    {
        set => SetProperty("conditions", value);
    }

    /// <summary>
    /// Block for grant_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrantControls block(s) allowed")]
    public List<AzureadConditionalAccessPolicyGrantControlsBlock>? GrantControls
    {
        set => SetProperty("grant_controls", value);
    }

    /// <summary>
    /// Block for session_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionControls block(s) allowed")]
    public List<AzureadConditionalAccessPolicySessionControlsBlock>? SessionControls
    {
        set => SetProperty("session_controls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadConditionalAccessPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
