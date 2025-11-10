using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for site in .
/// Nesting mode: list
/// </summary>
public class GoogleSiteVerificationWebResourceSiteBlock : ITerraformBlock
{
    /// <summary>
    /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is
    /// set to INET_DOMAIN, the identifier is a domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Identifier { get; set; }

    /// <summary>
    /// The type of resource to be verified. Possible values: [&amp;quot;INET_DOMAIN&amp;quot;, &amp;quot;SITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSiteVerificationWebResourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_site_verification_web_resource resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSiteVerificationWebResource : TerraformResource
{
    public GoogleSiteVerificationWebResource(string name) : base("google_site_verification_web_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The verification method for the Site Verification system to use to verify
    /// this site or domain. Possible values: [&amp;quot;ANALYTICS&amp;quot;, &amp;quot;DNS_CNAME&amp;quot;, &amp;quot;DNS_TXT&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;META&amp;quot;, &amp;quot;TAG_MANAGER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerificationMethod is required")]
    [TerraformPropertyName("verification_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VerificationMethod { get; set; }

    /// <summary>
    /// Block for site.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Site block(s) allowed")]
    [TerraformPropertyName("site")]
    public TerraformList<TerraformBlock<GoogleSiteVerificationWebResourceSiteBlock>>? Site { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSiteVerificationWebResourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The email addresses of all direct, verified owners of this exact property. Indirect owners —
    /// for example verified owners of the containing domain—are not included in this list.
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Owners => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "owners");

    /// <summary>
    /// The string used to identify this web resource.
    /// </summary>
    [TerraformPropertyName("web_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "web_resource_id");

}
