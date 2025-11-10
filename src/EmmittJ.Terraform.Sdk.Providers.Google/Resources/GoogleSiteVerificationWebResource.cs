using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for site in .
/// Nesting mode: list
/// </summary>
public class GoogleSiteVerificationWebResourceSiteBlock : TerraformBlock
{
    /// <summary>
    /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is
    /// set to INET_DOMAIN, the identifier is a domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<string> Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => WithProperty("identifier", value);
    }

    /// <summary>
    /// The type of resource to be verified. Possible values: [&amp;quot;INET_DOMAIN&amp;quot;, &amp;quot;SITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSiteVerificationWebResourceTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_site_verification_web_resource resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSiteVerificationWebResource : TerraformResource
{
    public GoogleSiteVerificationWebResource(string name) : base("google_site_verification_web_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("owners");
        this.DeclareOutput("web_resource_id");
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
    /// The verification method for the Site Verification system to use to verify
    /// this site or domain. Possible values: [&amp;quot;ANALYTICS&amp;quot;, &amp;quot;DNS_CNAME&amp;quot;, &amp;quot;DNS_TXT&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;META&amp;quot;, &amp;quot;TAG_MANAGER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerificationMethod is required")]
    public required TerraformProperty<string> VerificationMethod
    {
        get => GetProperty<TerraformProperty<string>>("verification_method");
        set => this.WithProperty("verification_method", value);
    }

    /// <summary>
    /// Block for site.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Site block(s) allowed")]
    public List<GoogleSiteVerificationWebResourceSiteBlock>? Site
    {
        get => GetProperty<List<GoogleSiteVerificationWebResourceSiteBlock>>("site");
        set => this.WithProperty("site", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSiteVerificationWebResourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSiteVerificationWebResourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The email addresses of all direct, verified owners of this exact property. Indirect owners —
    /// for example verified owners of the containing domain—are not included in this list.
    /// </summary>
    public TerraformExpression Owners => this["owners"];

    /// <summary>
    /// The string used to identify this web resource.
    /// </summary>
    public TerraformExpression WebResourceId => this["web_resource_id"];

}
