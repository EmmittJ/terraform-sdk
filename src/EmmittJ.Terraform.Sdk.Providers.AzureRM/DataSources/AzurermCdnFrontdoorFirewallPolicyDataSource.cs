using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_firewall_policy.
/// </summary>
public class AzurermCdnFrontdoorFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorFirewallPolicyDataSource(string name) : base("azurerm_cdn_frontdoor_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("captcha_cookie_expiration_in_minutes");
        this.DeclareOutput("enabled");
        this.DeclareOutput("frontend_endpoint_ids");
        this.DeclareOutput("js_challenge_cookie_expiration_in_minutes");
        this.DeclareOutput("mode");
        this.DeclareOutput("redirect_url");
        this.DeclareOutput("sku_name");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The captcha_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformExpression CaptchaCookieExpirationInMinutes => this["captcha_cookie_expiration_in_minutes"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformExpression FrontendEndpointIds => this["frontend_endpoint_ids"];

    /// <summary>
    /// The js_challenge_cookie_expiration_in_minutes attribute.
    /// </summary>
    public TerraformExpression JsChallengeCookieExpirationInMinutes => this["js_challenge_cookie_expiration_in_minutes"];

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformExpression Mode => this["mode"];

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformExpression RedirectUrl => this["redirect_url"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

}
