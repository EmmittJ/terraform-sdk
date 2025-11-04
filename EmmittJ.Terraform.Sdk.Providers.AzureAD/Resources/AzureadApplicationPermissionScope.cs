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
    public string? AdminConsentDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_consent_description")?.Value;
        set => this.WithProperty("admin_consent_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    public string? AdminConsentDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_consent_display_name")?.Value;
        set => this.WithProperty("admin_consent_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource ID of the application to which this permission scope should be applied
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique identifier of the permission scope
    /// </summary>
    public string? ScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope_id")?.Value;
        set => this.WithProperty("scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf
    /// </summary>
    public string? UserConsentDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_consent_description")?.Value;
        set => this.WithProperty("user_consent_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Display name for the delegated permission that appears in the end user consent experience
    /// </summary>
    public string? UserConsentDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_consent_display_name")?.Value;
        set => this.WithProperty("user_consent_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value that is used for the `scp` claim in OAuth access tokens
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
