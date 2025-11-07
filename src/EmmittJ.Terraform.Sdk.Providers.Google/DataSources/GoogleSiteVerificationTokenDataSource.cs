using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_site_verification_token.
/// </summary>
public class GoogleSiteVerificationTokenDataSource : TerraformDataSource
{
    public GoogleSiteVerificationTokenDataSource(string name) : base("google_site_verification_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("token");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is
    /// set to INET_DOMAIN, the identifier is a domain name.
    /// </summary>
    public TerraformLiteralProperty<string>? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// The type of resource to be verified, either a domain or a web site. Possible values: [&amp;quot;INET_DOMAIN&amp;quot;, &amp;quot;SITE&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The verification method for the Site Verification system to use to verify
    /// this site or domain. Possible values: [&amp;quot;ANALYTICS&amp;quot;, &amp;quot;DNS_CNAME&amp;quot;, &amp;quot;DNS_TXT&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;META&amp;quot;, &amp;quot;TAG_MANAGER&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? VerificationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("verification_method");
        set => this.WithProperty("verification_method", value);
    }

    /// <summary>
    /// The returned token for use in subsequent verification steps.
    /// </summary>
    public TerraformExpression Token => this["token"];

}
