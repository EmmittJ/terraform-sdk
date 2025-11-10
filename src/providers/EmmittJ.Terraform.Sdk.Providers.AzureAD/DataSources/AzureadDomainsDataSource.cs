using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDomainsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? AdminManaged { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    [TerraformPropertyName("include_unverified")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeUnverified { get; set; }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    [TerraformPropertyName("only_default")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OnlyDefault { get; set; }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    [TerraformPropertyName("only_initial")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OnlyInitial { get; set; }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    [TerraformPropertyName("only_root")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OnlyRoot { get; set; }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    [TerraformPropertyName("supports_services")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SupportsServices { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadDomainsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    [TerraformPropertyName("domains")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Domains => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "domains");

}
