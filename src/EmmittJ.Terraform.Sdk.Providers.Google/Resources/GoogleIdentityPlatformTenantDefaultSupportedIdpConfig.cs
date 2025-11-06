using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
    }

    /// <summary>
    /// OAuth client ID
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// OAuth client secret
    /// </summary>
    public string? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret")?.Value;
        set => this.WithProperty("client_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If this IDP allows the user to sign in
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    public string? IdpId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_id")?.Value;
        set => this.WithProperty("idp_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the tenant where this DefaultSupportedIdpConfig resource exists
    /// </summary>
    public string? Tenant
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant")?.Value;
        set => this.WithProperty("tenant", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the default supported IDP config resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
