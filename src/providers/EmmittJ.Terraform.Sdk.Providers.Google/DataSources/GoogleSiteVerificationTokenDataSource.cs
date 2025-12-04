using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSiteVerificationTokenDataSource.
/// Nesting mode: single
/// </summary>
public class GoogleSiteVerificationTokenDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a google_site_verification_token Terraform data source.
/// Retrieves information about a google_site_verification_token.
/// </summary>
public partial class GoogleSiteVerificationTokenDataSource(string name) : TerraformDataSource("google_site_verification_token", name)
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
    /// The type of resource to be verified, either a domain or a web site. Possible values: [&amp;quot;INET_DOMAIN&amp;quot;, &amp;quot;SITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
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
    /// The returned token for use in subsequent verification steps.
    /// </summary>
    public TerraformValue<string> Token
        => AsReference("token");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSiteVerificationTokenDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSiteVerificationTokenDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
