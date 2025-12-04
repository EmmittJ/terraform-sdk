using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIdentityPlatformTenantOauthIdpConfig.
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformTenantOauthIdpConfigTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_identity_platform_tenant_oauth_idp_config Terraform resource.
/// Manages a google_identity_platform_tenant_oauth_idp_config resource.
/// </summary>
public partial class GoogleIdentityPlatformTenantOauthIdpConfig(string name) : TerraformResource("google_identity_platform_tenant_oauth_idp_config", name)
{
    /// <summary>
    /// The client id of an OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client secret of the OAuth client, to enable OIDC code flow.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// For OIDC Idps, the issuer identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The name of the OauthIdpConfig. Must start with &#39;oidc.&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the tenant where this OIDC IDP configuration resource exists
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformValue<string> Tenant
    {
        get => GetArgument<TerraformValue<string>>("tenant");
        set => SetArgument("tenant", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIdentityPlatformTenantOauthIdpConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIdentityPlatformTenantOauthIdpConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
