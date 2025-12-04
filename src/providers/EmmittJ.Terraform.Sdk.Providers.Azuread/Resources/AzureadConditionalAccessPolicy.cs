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
        get => GetArgument<TerraformList<string>>("client_app_types");
        set => SetArgument("client_app_types", value);
    }

    /// <summary>
    /// The insider_risk_levels attribute.
    /// </summary>
    public TerraformValue<string> InsiderRiskLevels
    {
        get => GetArgument<TerraformValue<string>>("insider_risk_levels") ?? AsReference("insider_risk_levels");
        set => SetArgument("insider_risk_levels", value);
    }

    /// <summary>
    /// The service_principal_risk_levels attribute.
    /// </summary>
    public TerraformList<string>? ServicePrincipalRiskLevels
    {
        get => GetArgument<TerraformList<string>>("service_principal_risk_levels");
        set => SetArgument("service_principal_risk_levels", value);
    }

    /// <summary>
    /// The sign_in_risk_levels attribute.
    /// </summary>
    public TerraformList<string>? SignInRiskLevels
    {
        get => GetArgument<TerraformList<string>>("sign_in_risk_levels");
        set => SetArgument("sign_in_risk_levels", value);
    }

    /// <summary>
    /// The user_risk_levels attribute.
    /// </summary>
    public TerraformList<string>? UserRiskLevels
    {
        get => GetArgument<TerraformList<string>>("user_risk_levels");
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
        get => GetArgument<TerraformList<string>>("excluded_applications");
        set => SetArgument("excluded_applications", value);
    }

    /// <summary>
    /// The included_applications attribute.
    /// </summary>
    public TerraformList<string>? IncludedApplications
    {
        get => GetArgument<TerraformList<string>>("included_applications");
        set => SetArgument("included_applications", value);
    }

    /// <summary>
    /// The included_user_actions attribute.
    /// </summary>
    public TerraformList<string>? IncludedUserActions
    {
        get => GetArgument<TerraformList<string>>("included_user_actions");
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
        get => GetArgument<TerraformList<string>>("excluded_service_principals");
        set => SetArgument("excluded_service_principals", value);
    }

    /// <summary>
    /// The included_service_principals attribute.
    /// </summary>
    public TerraformList<string>? IncludedServicePrincipals
    {
        get => GetArgument<TerraformList<string>>("included_service_principals");
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
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule");
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
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule");
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
        get => GetArgument<TerraformList<string>>("excluded_locations");
        set => SetArgument("excluded_locations", value);
    }

    /// <summary>
    /// The included_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludedLocations is required")]
    public TerraformList<string>? IncludedLocations
    {
        get => GetArgument<TerraformList<string>>("included_locations");
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
        get => GetArgument<TerraformList<string>>("excluded_platforms");
        set => SetArgument("excluded_platforms", value);
    }

    /// <summary>
    /// The included_platforms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludedPlatforms is required")]
    public TerraformList<string>? IncludedPlatforms
    {
        get => GetArgument<TerraformList<string>>("included_platforms");
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
        get => GetArgument<TerraformList<string>>("excluded_groups");
        set => SetArgument("excluded_groups", value);
    }

    /// <summary>
    /// The excluded_roles attribute.
    /// </summary>
    public TerraformList<string>? ExcludedRoles
    {
        get => GetArgument<TerraformList<string>>("excluded_roles");
        set => SetArgument("excluded_roles", value);
    }

    /// <summary>
    /// The excluded_users attribute.
    /// </summary>
    public TerraformList<string>? ExcludedUsers
    {
        get => GetArgument<TerraformList<string>>("excluded_users");
        set => SetArgument("excluded_users", value);
    }

    /// <summary>
    /// The included_groups attribute.
    /// </summary>
    public TerraformList<string>? IncludedGroups
    {
        get => GetArgument<TerraformList<string>>("included_groups");
        set => SetArgument("included_groups", value);
    }

    /// <summary>
    /// The included_roles attribute.
    /// </summary>
    public TerraformList<string>? IncludedRoles
    {
        get => GetArgument<TerraformList<string>>("included_roles");
        set => SetArgument("included_roles", value);
    }

    /// <summary>
    /// The included_users attribute.
    /// </summary>
    public TerraformList<string>? IncludedUsers
    {
        get => GetArgument<TerraformList<string>>("included_users");
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
        get => GetArgument<TerraformList<string>>("guest_or_external_user_types");
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
        get => GetArgument<TerraformList<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The membership_kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipKind is required")]
    public required TerraformValue<string> MembershipKind
    {
        get => GetRequiredArgument<TerraformValue<string>>("membership_kind");
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
        get => GetArgument<TerraformList<string>>("guest_or_external_user_types");
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
        get => GetArgument<TerraformList<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The membership_kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipKind is required")]
    public required TerraformValue<string> MembershipKind
    {
        get => GetRequiredArgument<TerraformValue<string>>("membership_kind");
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
        get => GetArgument<TerraformValue<string>>("authentication_strength_policy_id");
        set => SetArgument("authentication_strength_policy_id", value);
    }

    /// <summary>
    /// The built_in_controls attribute.
    /// </summary>
    public TerraformList<string>? BuiltInControls
    {
        get => GetArgument<TerraformList<string>>("built_in_controls");
        set => SetArgument("built_in_controls", value);
    }

    /// <summary>
    /// The custom_authentication_factors attribute.
    /// </summary>
    public TerraformList<string>? CustomAuthenticationFactors
    {
        get => GetArgument<TerraformList<string>>("custom_authentication_factors");
        set => SetArgument("custom_authentication_factors", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The terms_of_use attribute.
    /// </summary>
    public TerraformList<string>? TermsOfUse
    {
        get => GetArgument<TerraformList<string>>("terms_of_use");
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
        get => GetArgument<TerraformValue<bool>>("application_enforced_restrictions_enabled");
        set => SetArgument("application_enforced_restrictions_enabled", value);
    }

    /// <summary>
    /// The cloud_app_security_policy attribute.
    /// </summary>
    public TerraformValue<string>? CloudAppSecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("cloud_app_security_policy");
        set => SetArgument("cloud_app_security_policy", value);
    }

    /// <summary>
    /// The disable_resilience_defaults attribute.
    /// </summary>
    public TerraformValue<bool>? DisableResilienceDefaults
    {
        get => GetArgument<TerraformValue<bool>>("disable_resilience_defaults");
        set => SetArgument("disable_resilience_defaults", value);
    }

    /// <summary>
    /// The persistent_browser_mode attribute.
    /// </summary>
    public TerraformValue<string>? PersistentBrowserMode
    {
        get => GetArgument<TerraformValue<string>>("persistent_browser_mode");
        set => SetArgument("persistent_browser_mode", value);
    }

    /// <summary>
    /// The sign_in_frequency attribute.
    /// </summary>
    public TerraformValue<double>? SignInFrequency
    {
        get => GetArgument<TerraformValue<double>>("sign_in_frequency");
        set => SetArgument("sign_in_frequency", value);
    }

    /// <summary>
    /// The sign_in_frequency_authentication_type attribute.
    /// </summary>
    public TerraformValue<string> SignInFrequencyAuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("sign_in_frequency_authentication_type") ?? AsReference("sign_in_frequency_authentication_type");
        set => SetArgument("sign_in_frequency_authentication_type", value);
    }

    /// <summary>
    /// The sign_in_frequency_interval attribute.
    /// </summary>
    public TerraformValue<string> SignInFrequencyInterval
    {
        get => GetArgument<TerraformValue<string>>("sign_in_frequency_interval") ?? AsReference("sign_in_frequency_interval");
        set => SetArgument("sign_in_frequency_interval", value);
    }

    /// <summary>
    /// The sign_in_frequency_period attribute.
    /// </summary>
    public TerraformValue<string>? SignInFrequencyPeriod
    {
        get => GetArgument<TerraformValue<string>>("sign_in_frequency_period");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetRequiredArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The object ID of the policy
    /// </summary>
    public TerraformValue<string> ObjectId
        => AsReference("object_id");

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
