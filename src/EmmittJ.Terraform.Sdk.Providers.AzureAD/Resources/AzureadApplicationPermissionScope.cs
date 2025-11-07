using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    }

    /// <summary>
    /// Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    public TerraformProperty<string>? AdminConsentDescription
    {
        get => GetProperty<TerraformProperty<string>>("admin_consent_description");
        set => this.WithProperty("admin_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    public TerraformProperty<string>? AdminConsentDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("admin_consent_display_name");
        set => this.WithProperty("admin_consent_display_name", value);
    }

    /// <summary>
    /// The resource ID of the application to which this permission scope should be applied
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// The unique identifier of the permission scope
    /// </summary>
    public TerraformProperty<string>? ScopeId
    {
        get => GetProperty<TerraformProperty<string>>("scope_id");
        set => this.WithProperty("scope_id", value);
    }

    /// <summary>
    /// Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf
    /// </summary>
    public TerraformProperty<string>? UserConsentDescription
    {
        get => GetProperty<TerraformProperty<string>>("user_consent_description");
        set => this.WithProperty("user_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission that appears in the end user consent experience
    /// </summary>
    public TerraformProperty<string>? UserConsentDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("user_consent_display_name");
        set => this.WithProperty("user_consent_display_name", value);
    }

    /// <summary>
    /// The value that is used for the `scp` claim in OAuth access tokens
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

}
