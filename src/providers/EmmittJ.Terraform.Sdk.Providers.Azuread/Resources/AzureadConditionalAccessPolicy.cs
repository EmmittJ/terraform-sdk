using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for conditions in AzureadConditionalAccessPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// The client_app_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientAppTypes is required")]
    public TerraformList<string>? ClientAppTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "client_app_types").ResolveNodes(ctx));
        set => SetArgument("client_app_types", value);
    }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    public TerraformValue<string> InsiderRiskLevels
    {
        get => new TerraformReference<string>(this, "insider_risk_levels");
        set => SetArgument("insider_risk_levels", value);
    }

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    public TerraformList<string>? ServicePrincipalRiskLevels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_principal_risk_levels").ResolveNodes(ctx));
        set => SetArgument("service_principal_risk_levels", value);
    }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    public TerraformList<string>? SignInRiskLevels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "sign_in_risk_levels").ResolveNodes(ctx));
        set => SetArgument("sign_in_risk_levels", value);
    }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    public TerraformList<string>? UserRiskLevels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_risk_levels").ResolveNodes(ctx));
        set => SetArgument("user_risk_levels", value);
    }

    /// <summary>
    /// Applications block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Applications block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Applications block(s) allowed")]
    public required TerraformList<AzureadConditionalAccessPolicyConditionsBlockApplicationsBlock> Applications
    {
        get => GetRequiredArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockApplicationsBlock>>("applications");
        set => SetArgument("applications", value);
    }

    /// <summary>
    /// ClientApplications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientApplications block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlock>? ClientApplications
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlock>>("client_applications");
        set => SetArgument("client_applications", value);
    }

    /// <summary>
    /// Devices block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Devices block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockDevicesBlock>? Devices
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockDevicesBlock>>("devices");
        set => SetArgument("devices", value);
    }

    /// <summary>
    /// Locations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Locations block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockLocationsBlock>? Locations
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockLocationsBlock>>("locations");
        set => SetArgument("locations", value);
    }

    /// <summary>
    /// Platforms block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platforms block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockPlatformsBlock>? Platforms
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockPlatformsBlock>>("platforms");
        set => SetArgument("platforms", value);
    }

    /// <summary>
    /// Users block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Users is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Users block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Users block(s) allowed")]
    public required TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlock> Users
    {
        get => GetRequiredArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlock>>("users");
        set => SetArgument("users", value);
    }

}

/// <summary>
/// Block type for applications in AzureadConditionalAccessPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "applications";

    /// <summary>
    /// The excluded_applications attribute.
    /// </summary>
    public TerraformList<string>? ExcludedApplications
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_applications").ResolveNodes(ctx));
        set => SetArgument("excluded_applications", value);
    }

    /// <summary>
    /// The included_applications attribute.
    /// </summary>
    public TerraformList<string>? IncludedApplications
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_applications").ResolveNodes(ctx));
        set => SetArgument("included_applications", value);
    }

    /// <summary>
    /// The included_user_actions attribute.
    /// </summary>
    public TerraformList<string>? IncludedUserActions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_user_actions").ResolveNodes(ctx));
        set => SetArgument("included_user_actions", value);
    }

}

/// <summary>
/// Block type for client_applications in AzureadConditionalAccessPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_applications";

    /// <summary>
    /// The excluded_service_principals attribute.
    /// </summary>
    public TerraformList<string>? ExcludedServicePrincipals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_service_principals").ResolveNodes(ctx));
        set => SetArgument("excluded_service_principals", value);
    }

    /// <summary>
    /// The included_service_principals attribute.
    /// </summary>
    public TerraformList<string>? IncludedServicePrincipals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_service_principals").ResolveNodes(ctx));
        set => SetArgument("included_service_principals", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockClientApplicationsBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => new TerraformReference<string>(this, "rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for devices in AzureadConditionalAccessPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockDevicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "devices";

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockDevicesBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockDevicesBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AzureadConditionalAccessPolicyConditionsBlockDevicesBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockDevicesBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => new TerraformReference<string>(this, "rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for locations in AzureadConditionalAccessPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "locations";

    /// <summary>
    /// The excluded_locations attribute.
    /// </summary>
    public TerraformList<string>? ExcludedLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_locations").ResolveNodes(ctx));
        set => SetArgument("excluded_locations", value);
    }

    /// <summary>
    /// The included_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludedLocations is required")]
    public TerraformList<string>? IncludedLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_locations").ResolveNodes(ctx));
        set => SetArgument("included_locations", value);
    }

}

/// <summary>
/// Block type for platforms in AzureadConditionalAccessPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockPlatformsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "platforms";

    /// <summary>
    /// The excluded_platforms attribute.
    /// </summary>
    public TerraformList<string>? ExcludedPlatforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_platforms").ResolveNodes(ctx));
        set => SetArgument("excluded_platforms", value);
    }

    /// <summary>
    /// The included_platforms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludedPlatforms is required")]
    public TerraformList<string>? IncludedPlatforms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_platforms").ResolveNodes(ctx));
        set => SetArgument("included_platforms", value);
    }

}

/// <summary>
/// Block type for users in AzureadConditionalAccessPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "users";

    /// <summary>
    /// The excluded_groups attribute.
    /// </summary>
    public TerraformList<string>? ExcludedGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_groups").ResolveNodes(ctx));
        set => SetArgument("excluded_groups", value);
    }

    /// <summary>
    /// The excluded_roles attribute.
    /// </summary>
    public TerraformList<string>? ExcludedRoles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_roles").ResolveNodes(ctx));
        set => SetArgument("excluded_roles", value);
    }

    /// <summary>
    /// The excluded_users attribute.
    /// </summary>
    public TerraformList<string>? ExcludedUsers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_users").ResolveNodes(ctx));
        set => SetArgument("excluded_users", value);
    }

    /// <summary>
    /// The included_groups attribute.
    /// </summary>
    public TerraformList<string>? IncludedGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_groups").ResolveNodes(ctx));
        set => SetArgument("included_groups", value);
    }

    /// <summary>
    /// The included_roles attribute.
    /// </summary>
    public TerraformList<string>? IncludedRoles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_roles").ResolveNodes(ctx));
        set => SetArgument("included_roles", value);
    }

    /// <summary>
    /// The included_users attribute.
    /// </summary>
    public TerraformList<string>? IncludedUsers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_users").ResolveNodes(ctx));
        set => SetArgument("included_users", value);
    }

    /// <summary>
    /// ExcludedGuestsOrExternalUsers block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlock>? ExcludedGuestsOrExternalUsers
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlock>>("excluded_guests_or_external_users");
        set => SetArgument("excluded_guests_or_external_users", value);
    }

    /// <summary>
    /// IncludedGuestsOrExternalUsers block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlock>? IncludedGuestsOrExternalUsers
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlock>>("included_guests_or_external_users");
        set => SetArgument("included_guests_or_external_users", value);
    }

}

/// <summary>
/// Block type for excluded_guests_or_external_users in AzureadConditionalAccessPolicyConditionsBlockUsersBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_guests_or_external_users";

    /// <summary>
    /// The guest_or_external_user_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuestOrExternalUserTypes is required")]
    public TerraformList<string>? GuestOrExternalUserTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "guest_or_external_user_types").ResolveNodes(ctx));
        set => SetArgument("guest_or_external_user_types", value);
    }

    /// <summary>
    /// ExternalTenants block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlockExternalTenantsBlock>? ExternalTenants
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlockExternalTenantsBlock>>("external_tenants");
        set => SetArgument("external_tenants", value);
    }

}

/// <summary>
/// Block type for external_tenants in AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockUsersBlockExcludedGuestsOrExternalUsersBlockExternalTenantsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_tenants";

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformList<string>? Members
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "members").ResolveNodes(ctx));
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The membership_kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipKind is required")]
    public required TerraformValue<string> MembershipKind
    {
        get => new TerraformReference<string>(this, "membership_kind");
        set => SetArgument("membership_kind", value);
    }

}

/// <summary>
/// Block type for included_guests_or_external_users in AzureadConditionalAccessPolicyConditionsBlockUsersBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_guests_or_external_users";

    /// <summary>
    /// The guest_or_external_user_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuestOrExternalUserTypes is required")]
    public TerraformList<string>? GuestOrExternalUserTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "guest_or_external_user_types").ResolveNodes(ctx));
        set => SetArgument("guest_or_external_user_types", value);
    }

    /// <summary>
    /// ExternalTenants block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlockExternalTenantsBlock>? ExternalTenants
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlockExternalTenantsBlock>>("external_tenants");
        set => SetArgument("external_tenants", value);
    }

}

/// <summary>
/// Block type for external_tenants in AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlock.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyConditionsBlockUsersBlockIncludedGuestsOrExternalUsersBlockExternalTenantsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_tenants";

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformList<string>? Members
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "members").ResolveNodes(ctx));
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The membership_kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipKind is required")]
    public required TerraformValue<string> MembershipKind
    {
        get => new TerraformReference<string>(this, "membership_kind");
        set => SetArgument("membership_kind", value);
    }

}


/// <summary>
/// Block type for grant_controls in AzureadConditionalAccessPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicyGrantControlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grant_controls";

    /// <summary>
    /// The authentication_strength_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationStrengthPolicyId
    {
        get => new TerraformReference<string>(this, "authentication_strength_policy_id");
        set => SetArgument("authentication_strength_policy_id", value);
    }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    public TerraformList<string>? BuiltInControls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "built_in_controls").ResolveNodes(ctx));
        set => SetArgument("built_in_controls", value);
    }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    public TerraformList<string>? CustomAuthenticationFactors
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_authentication_factors").ResolveNodes(ctx));
        set => SetArgument("custom_authentication_factors", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    public TerraformList<string>? TermsOfUse
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "terms_of_use").ResolveNodes(ctx));
        set => SetArgument("terms_of_use", value);
    }

}


/// <summary>
/// Block type for session_controls in AzureadConditionalAccessPolicy.
/// Nesting mode: list
/// </summary>
public class AzureadConditionalAccessPolicySessionControlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "session_controls";

    /// <summary>
    /// The application_enforced_restrictions_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ApplicationEnforcedRestrictionsEnabled
    {
        get => new TerraformReference<bool>(this, "application_enforced_restrictions_enabled");
        set => SetArgument("application_enforced_restrictions_enabled", value);
    }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    public TerraformValue<string>? CloudAppSecurityPolicy
    {
        get => new TerraformReference<string>(this, "cloud_app_security_policy");
        set => SetArgument("cloud_app_security_policy", value);
    }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    public TerraformValue<bool>? DisableResilienceDefaults
    {
        get => new TerraformReference<bool>(this, "disable_resilience_defaults");
        set => SetArgument("disable_resilience_defaults", value);
    }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    public TerraformValue<string>? PersistentBrowserMode
    {
        get => new TerraformReference<string>(this, "persistent_browser_mode");
        set => SetArgument("persistent_browser_mode", value);
    }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    public TerraformValue<double>? SignInFrequency
    {
        get => new TerraformReference<double>(this, "sign_in_frequency");
        set => SetArgument("sign_in_frequency", value);
    }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    public TerraformValue<string> SignInFrequencyAuthenticationType
    {
        get => new TerraformReference<string>(this, "sign_in_frequency_authentication_type");
        set => SetArgument("sign_in_frequency_authentication_type", value);
    }

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    public TerraformValue<string> SignInFrequencyInterval
    {
        get => new TerraformReference<string>(this, "sign_in_frequency_interval");
        set => SetArgument("sign_in_frequency_interval", value);
    }

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    public TerraformValue<string>? SignInFrequencyPeriod
    {
        get => new TerraformReference<string>(this, "sign_in_frequency_period");
        set => SetArgument("sign_in_frequency_period", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadConditionalAccessPolicy.
/// Nesting mode: single
/// </summary>
public class AzureadConditionalAccessPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_conditional_access_policy Terraform resource.
/// Manages a azuread_conditional_access_policy resource.
/// </summary>
public partial class AzureadConditionalAccessPolicy(string name) : TerraformResource("azuread_conditional_access_policy", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public required TerraformList<AzureadConditionalAccessPolicyConditionsBlock> Conditions
    {
        get => GetRequiredArgument<TerraformList<AzureadConditionalAccessPolicyConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// GrantControls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrantControls block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicyGrantControlsBlock>? GrantControls
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicyGrantControlsBlock>>("grant_controls");
        set => SetArgument("grant_controls", value);
    }

    /// <summary>
    /// SessionControls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SessionControls block(s) allowed")]
    public TerraformList<AzureadConditionalAccessPolicySessionControlsBlock>? SessionControls
    {
        get => GetArgument<TerraformList<AzureadConditionalAccessPolicySessionControlsBlock>>("session_controls");
        set => SetArgument("session_controls", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadConditionalAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadConditionalAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
