using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadDomainsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_domains.
/// </summary>
public partial class AzureadDomainsDataSource : TerraformDataSource
{
    public AzureadDomainsDataSource(string name) : base("azuread_domains", name)
    {
    }

    /// <summary>
    /// Set to `true` to only return domains whose DNS is managed by Microsoft 365
    /// </summary>
    [TerraformProperty("admin_managed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdminManaged { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    [TerraformProperty("include_unverified")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeUnverified { get; set; }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    [TerraformProperty("only_default")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OnlyDefault { get; set; }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    [TerraformProperty("only_initial")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OnlyInitial { get; set; }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    [TerraformProperty("only_root")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OnlyRoot { get; set; }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    [TerraformProperty("supports_services")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SupportsServices { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadDomainsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    [TerraformProperty("domains")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Domains { get; }

}
