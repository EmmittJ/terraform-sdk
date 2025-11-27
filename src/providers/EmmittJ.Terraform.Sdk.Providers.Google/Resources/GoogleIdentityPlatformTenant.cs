using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client in GoogleIdentityPlatformTenant.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantClientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client";

    /// <summary>
    /// Permissions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformTenantClientBlockPermissionsBlock>? Permissions
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformTenantClientBlockPermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

}

/// <summary>
/// Block type for permissions in GoogleIdentityPlatformTenantClientBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantClientBlockPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// When true, end users cannot delete their account on the associated project through any of our API methods.
    /// </summary>
    public TerraformValue<bool>? DisabledUserDeletion
    {
        get => new TerraformReference<bool>(this, "disabled_user_deletion");
        set => SetArgument("disabled_user_deletion", value);
    }

    /// <summary>
    /// When true, end users cannot sign up for a new account on the associated project through any of our API methods.
    /// </summary>
    public TerraformValue<bool>? DisabledUserSignup
    {
        get => new TerraformReference<bool>(this, "disabled_user_signup");
        set => SetArgument("disabled_user_signup", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIdentityPlatformTenant.
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformTenantTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_identity_platform_tenant Terraform resource.
/// Manages a google_identity_platform_tenant resource.
/// </summary>
public partial class GoogleIdentityPlatformTenant(string name) : TerraformResource("google_identity_platform_tenant", name)
{
    /// <summary>
    /// Whether to allow email/password user authentication.
    /// </summary>
    public TerraformValue<bool>? AllowPasswordSignup
    {
        get => new TerraformReference<bool>(this, "allow_password_signup");
        set => SetArgument("allow_password_signup", value);
    }

    /// <summary>
    /// Whether authentication is disabled for the tenant. If true, the users under
    /// the disabled tenant are not allowed to sign-in. Admins of the disabled tenant
    /// are not able to manage its users.
    /// </summary>
    public TerraformValue<bool>? DisableAuth
    {
        get => new TerraformReference<bool>(this, "disable_auth");
        set => SetArgument("disable_auth", value);
    }

    /// <summary>
    /// Human friendly display name of the tenant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether to enable email link user authentication.
    /// </summary>
    public TerraformValue<bool>? EnableEmailLinkSignin
    {
        get => new TerraformReference<bool>(this, "enable_email_link_signin");
        set => SetArgument("enable_email_link_signin", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the tenant that is generated by the server
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Client block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Client block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformTenantClientBlock>? Client
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformTenantClientBlock>>("client");
        set => SetArgument("client", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIdentityPlatformTenantTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIdentityPlatformTenantTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
