using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformTenantDefaultSupportedIdpConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_identity_platform_tenant_default_supported_idp_config resource.
/// </summary>
public class GoogleIdentityPlatformTenantDefaultSupportedIdpConfig : TerraformResource
{
    public GoogleIdentityPlatformTenantDefaultSupportedIdpConfig(string name) : base("google_identity_platform_tenant_default_supported_idp_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// OAuth client ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// OAuth client secret
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
    }

    /// <summary>
    /// If this IDP allows the user to sign in
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
    /// ID of the IDP. Possible values include:
    /// 
    /// * &#39;apple.com&#39;
    /// 
    /// * &#39;facebook.com&#39;
    /// 
    /// * &#39;gc.apple.com&#39;
    /// 
    /// * &#39;github.com&#39;
    /// 
    /// * &#39;google.com&#39;
    /// 
    /// * &#39;linkedin.com&#39;
    /// 
    /// * &#39;microsoft.com&#39;
    /// 
    /// * &#39;playgames.google.com&#39;
    /// 
    /// * &#39;twitter.com&#39;
    /// 
    /// * &#39;yahoo.com&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpId is required")]
    public required TerraformProperty<string> IdpId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("idp_id");
        set => this.WithProperty("idp_id", value);
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
    /// The name of the tenant where this DefaultSupportedIdpConfig resource exists
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformProperty<string> Tenant
    {
        get => GetRequiredProperty<TerraformProperty<string>>("tenant");
        set => this.WithProperty("tenant", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIdentityPlatformTenantDefaultSupportedIdpConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIdentityPlatformTenantDefaultSupportedIdpConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the default supported IDP config resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
