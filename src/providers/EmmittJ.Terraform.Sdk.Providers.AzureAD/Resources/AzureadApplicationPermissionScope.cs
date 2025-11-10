using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationPermissionScopeTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_application_permission_scope resource.
/// </summary>
public class AzureadApplicationPermissionScope : TerraformResource
{
    public AzureadApplicationPermissionScope(string name) : base("azuread_application_permission_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("admin_consent_description");
        SetOutput("admin_consent_display_name");
        SetOutput("application_id");
        SetOutput("id");
        SetOutput("scope_id");
        SetOutput("type");
        SetOutput("user_consent_description");
        SetOutput("user_consent_display_name");
        SetOutput("value");
    }

    /// <summary>
    /// Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminConsentDescription is required")]
    public required TerraformProperty<string> AdminConsentDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_consent_description");
        set => SetProperty("admin_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminConsentDisplayName is required")]
    public required TerraformProperty<string> AdminConsentDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_consent_display_name");
        set => SetProperty("admin_consent_display_name", value);
    }

    /// <summary>
    /// The resource ID of the application to which this permission scope should be applied
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
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
    /// The unique identifier of the permission scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformProperty<string> ScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope_id");
        set => SetProperty("scope_id", value);
    }

    /// <summary>
    /// Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf
    /// </summary>
    public TerraformProperty<string> UserConsentDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_consent_description");
        set => SetProperty("user_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission that appears in the end user consent experience
    /// </summary>
    public TerraformProperty<string> UserConsentDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_consent_display_name");
        set => SetProperty("user_consent_display_name", value);
    }

    /// <summary>
    /// The value that is used for the `scp` claim in OAuth access tokens
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetRequiredOutput<TerraformProperty<string>>("value");
        set => SetProperty("value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationPermissionScopeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
