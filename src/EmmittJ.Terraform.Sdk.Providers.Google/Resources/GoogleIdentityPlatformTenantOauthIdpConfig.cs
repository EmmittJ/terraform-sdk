using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformTenantOauthIdpConfigTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_identity_platform_tenant_oauth_idp_config resource.
/// </summary>
public class GoogleIdentityPlatformTenantOauthIdpConfig : TerraformResource
{
    public GoogleIdentityPlatformTenantOauthIdpConfig(string name) : base("google_identity_platform_tenant_oauth_idp_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The client id of an OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client secret of the OAuth client, to enable OIDC code flow.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// For OIDC Idps, the issuer identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => this.WithProperty("issuer", value);
    }

    /// <summary>
    /// The name of the OauthIdpConfig. Must start with &#39;oidc.&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the tenant where this OIDC IDP configuration resource exists
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformProperty<string> Tenant
    {
        get => GetProperty<TerraformProperty<string>>("tenant");
        set => this.WithProperty("tenant", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIdentityPlatformTenantOauthIdpConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIdentityPlatformTenantOauthIdpConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
