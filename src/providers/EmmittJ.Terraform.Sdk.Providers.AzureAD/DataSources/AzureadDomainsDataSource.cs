using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDomainsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_domains.
/// </summary>
public class AzureadDomainsDataSource : TerraformDataSource
{
    public AzureadDomainsDataSource(string name) : base("azuread_domains", name)
    {
    }

    /// <summary>
    /// Set to `true` to only return domains whose DNS is managed by Microsoft 365
    /// </summary>
    [TerraformPropertyName("admin_managed")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AdminManaged { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    [TerraformPropertyName("include_unverified")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeUnverified { get; set; }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    [TerraformPropertyName("only_default")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OnlyDefault { get; set; }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    [TerraformPropertyName("only_initial")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OnlyInitial { get; set; }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    [TerraformPropertyName("only_root")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OnlyRoot { get; set; }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    [TerraformPropertyName("supports_services")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SupportsServices { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadDomainsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    [TerraformPropertyName("domains")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Domains => new TerraformReference(this, "domains");

}
