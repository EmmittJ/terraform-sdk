using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for site in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSiteVerificationWebResourceSiteBlock : TerraformBlockBase
{
    /// <summary>
    /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is
    /// set to INET_DOMAIN, the identifier is a domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The type of resource to be verified. Possible values: [&amp;quot;INET_DOMAIN&amp;quot;, &amp;quot;SITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSiteVerificationWebResourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_site_verification_web_resource resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSiteVerificationWebResource : TerraformResource
{
    public GoogleSiteVerificationWebResource(string name) : base("google_site_verification_web_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The verification method for the Site Verification system to use to verify
    /// this site or domain. Possible values: [&amp;quot;ANALYTICS&amp;quot;, &amp;quot;DNS_CNAME&amp;quot;, &amp;quot;DNS_TXT&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;META&amp;quot;, &amp;quot;TAG_MANAGER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerificationMethod is required")]
    [TerraformProperty("verification_method")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VerificationMethod { get; set; }

    /// <summary>
    /// Block for site.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Site block(s) allowed")]
    [TerraformProperty("site")]
    public TerraformList<TerraformBlock<GoogleSiteVerificationWebResourceSiteBlock>>? Site { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleSiteVerificationWebResourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The email addresses of all direct, verified owners of this exact property. Indirect owners —
    /// for example verified owners of the containing domain—are not included in this list.
    /// </summary>
    [TerraformProperty("owners")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Owners { get; }

    /// <summary>
    /// The string used to identify this web resource.
    /// </summary>
    [TerraformProperty("web_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebResourceId { get; }

}
