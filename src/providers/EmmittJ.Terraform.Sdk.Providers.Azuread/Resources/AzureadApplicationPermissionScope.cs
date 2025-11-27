using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationPermissionScope.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationPermissionScopeTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_application_permission_scope Terraform resource.
/// Manages a azuread_application_permission_scope resource.
/// </summary>
public partial class AzureadApplicationPermissionScope(string name) : TerraformResource("azuread_application_permission_scope", name)
{
    /// <summary>
    /// Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminConsentDescription is required")]
    public required TerraformValue<string> AdminConsentDescription
    {
        get => new TerraformReference<string>(this, "admin_consent_description");
        set => SetArgument("admin_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminConsentDisplayName is required")]
    public required TerraformValue<string> AdminConsentDisplayName
    {
        get => new TerraformReference<string>(this, "admin_consent_display_name");
        set => SetArgument("admin_consent_display_name", value);
    }

    /// <summary>
    /// The resource ID of the application to which this permission scope should be applied
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
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
    /// The unique identifier of the permission scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformValue<string> ScopeId
    {
        get => new TerraformReference<string>(this, "scope_id");
        set => SetArgument("scope_id", value);
    }

    /// <summary>
    /// Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf
    /// </summary>
    public TerraformValue<string>? UserConsentDescription
    {
        get => new TerraformReference<string>(this, "user_consent_description");
        set => SetArgument("user_consent_description", value);
    }

    /// <summary>
    /// Display name for the delegated permission that appears in the end user consent experience
    /// </summary>
    public TerraformValue<string>? UserConsentDisplayName
    {
        get => new TerraformReference<string>(this, "user_consent_display_name");
        set => SetArgument("user_consent_display_name", value);
    }

    /// <summary>
    /// The value that is used for the `scp` claim in OAuth access tokens
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationPermissionScopeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationPermissionScopeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
