using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for site in GoogleSiteVerificationWebResource.
/// Nesting mode: list
/// </summary>
public class GoogleSiteVerificationWebResourceSiteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site";

    /// <summary>
    /// The site identifier. If the type is set to SITE, the identifier is a URL. If the type is
    /// set to INET_DOMAIN, the identifier is a domain name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => GetArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The type of resource to be verified. Possible values: [&amp;quot;INET_DOMAIN&amp;quot;, &amp;quot;SITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSiteVerificationWebResource.
/// Nesting mode: single
/// </summary>
public class GoogleSiteVerificationWebResourceTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_site_verification_web_resource Terraform resource.
/// Manages a google_site_verification_web_resource resource.
/// </summary>
public partial class GoogleSiteVerificationWebResource(string name) : TerraformResource("google_site_verification_web_resource", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The verification method for the Site Verification system to use to verify
    /// this site or domain. Possible values: [&amp;quot;ANALYTICS&amp;quot;, &amp;quot;DNS_CNAME&amp;quot;, &amp;quot;DNS_TXT&amp;quot;, &amp;quot;FILE&amp;quot;, &amp;quot;META&amp;quot;, &amp;quot;TAG_MANAGER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerificationMethod is required")]
    public required TerraformValue<string> VerificationMethod
    {
        get => GetArgument<TerraformValue<string>>("verification_method");
        set => SetArgument("verification_method", value);
    }

    /// <summary>
    /// The email addresses of all direct, verified owners of this exact property. Indirect owners —
    /// for example verified owners of the containing domain—are not included in this list.
    /// </summary>
    public TerraformList<string> Owners
        => AsReference("owners");

    /// <summary>
    /// The string used to identify this web resource.
    /// </summary>
    public TerraformValue<string> WebResourceId
        => AsReference("web_resource_id");

    /// <summary>
    /// Site block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Site is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Site block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Site block(s) allowed")]
    public required TerraformList<GoogleSiteVerificationWebResourceSiteBlock> Site
    {
        get => GetRequiredArgument<TerraformList<GoogleSiteVerificationWebResourceSiteBlock>>("site");
        set => SetArgument("site", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSiteVerificationWebResourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSiteVerificationWebResourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
