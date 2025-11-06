using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_identity_platform_oauth_idp_config resource.
/// </summary>
public class GoogleIdentityPlatformOauthIdpConfig : TerraformResource
{
    public GoogleIdentityPlatformOauthIdpConfig(string name) : base("google_identity_platform_oauth_idp_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The client id of an OAuth client.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client secret of the OAuth client, to enable OIDC code flow.
    /// </summary>
    public string? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret")?.Value;
        set => this.WithProperty("client_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
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
    /// For OIDC Idps, the issuer identifier.
    /// </summary>
    public string? Issuer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("issuer")?.Value;
        set => this.WithProperty("issuer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the OauthIdpConfig. Must start with &#39;oidc.&#39;.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
