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
        get => GetProperty<List<TerraformProperty<string>>>("client_app_types");
        set => WithProperty("client_app_types", value);
    }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    public TerraformProperty<string>? InsiderRiskLevels
    {
        get => GetProperty<TerraformProperty<string>>("insider_risk_levels");
        set => WithProperty("insider_risk_levels", value);
    }

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ServicePrincipalRiskLevels
    {
        get => GetProperty<List<TerraformProperty<string>>>("service_principal_risk_levels");
        set => WithProperty("service_principal_risk_levels", value);
    }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SignInRiskLevels
    {
        get => GetProperty<List<TerraformProperty<string>>>("sign_in_risk_levels");
        set => WithProperty("sign_in_risk_levels", value);
    }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    public List<TerraformProperty<string>>? UserRiskLevels
    {
        get => GetProperty<List<TerraformProperty<string>>>("user_risk_levels");
        set => WithProperty("user_risk_levels", value);
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
        get => GetProperty<TerraformProperty<string>>("authentication_strength_policy_id");
        set => WithProperty("authentication_strength_policy_id", value);
    }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? BuiltInControls
    {
        get => GetProperty<List<TerraformProperty<string>>>("built_in_controls");
        set => WithProperty("built_in_controls", value);
    }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomAuthenticationFactors
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_authentication_factors");
        set => WithProperty("custom_authentication_factors", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        get => GetProperty<TerraformProperty<string>>("operator");
        set => WithProperty("operator", value);
    }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TermsOfUse
    {
        get => GetProperty<List<TerraformProperty<string>>>("terms_of_use");
        set => WithProperty("terms_of_use", value);
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
        get => GetProperty<TerraformProperty<bool>>("application_enforced_restrictions_enabled");
        set => WithProperty("application_enforced_restrictions_enabled", value);
    }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? CloudAppSecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("cloud_app_security_policy");
        set => WithProperty("cloud_app_security_policy", value);
    }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableResilienceDefaults
    {
        get => GetProperty<TerraformProperty<bool>>("disable_resilience_defaults");
        set => WithProperty("disable_resilience_defaults", value);
    }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PersistentBrowserMode
    {
        get => GetProperty<TerraformProperty<string>>("persistent_browser_mode");
        set => WithProperty("persistent_browser_mode", value);
    }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    public TerraformProperty<double>? SignInFrequency
    {
        get => GetProperty<TerraformProperty<double>>("sign_in_frequency");
        set => WithProperty("sign_in_frequency", value);
    }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? SignInFrequencyAuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("sign_in_frequency_authentication_type");
        set => WithProperty("sign_in_frequency_authentication_type", value);
    }

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    public TerraformProperty<string>? SignInFrequencyInterval
    {
        get => GetProperty<TerraformProperty<string>>("sign_in_frequency_interval");
        set => WithProperty("sign_in_frequency_interval", value);
    }

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    public TerraformProperty<string>? SignInFrequencyPeriod
    {
        get => GetProperty<TerraformProperty<string>>("sign_in_frequency_period");
        set => WithProperty("sign_in_frequency_period", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_conditional_access_policy resource.
/// </summary>
public class AzureadConditionalAccessPolicy : TerraformResource
{
    public AzureadConditionalAccessPolicy(string name) : base("azuread_conditional_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("object_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// Block for conditions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public List<AzureadConditionalAccessPolicyConditionsBlock>? Conditions
    {
        get => GetProperty<List<AzureadConditionalAccessPolicyConditionsBlock>>("conditions");
        set => this.WithProperty("conditions", value);
    }

    /// <summary>
    /// Block for grant_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrantControls block(s) allowed")]
    public List<AzureadConditionalAccessPolicyGrantControlsBlock>? GrantControls
    {
        get => GetProperty<List<AzureadConditionalAccessPolicyGrantControlsBlock>>("grant_controls");
        set => this.WithProperty("grant_controls", value);
    }

    /// <summary>
    /// Block for session_controls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionControls block(s) allowed")]
    public List<AzureadConditionalAccessPolicySessionControlsBlock>? SessionControls
    {
        get => GetProperty<List<AzureadConditionalAccessPolicySessionControlsBlock>>("session_controls");
        set => this.WithProperty("session_controls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadConditionalAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadConditionalAccessPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
