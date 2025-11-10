using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDomainsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azuread_domains.
/// </summary>
public class AzureadDomainsDataSource : TerraformDataSource
{
    public AzureadDomainsDataSource(string name) : base("azuread_domains", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("domains");
    }

    /// <summary>
    /// Set to `true` to only return domains whose DNS is managed by Microsoft 365
    /// </summary>
    public TerraformProperty<bool>? AdminManaged
    {
        get => GetProperty<TerraformProperty<bool>>("admin_managed");
        set => this.WithProperty("admin_managed", value);
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
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    public TerraformProperty<bool>? IncludeUnverified
    {
        get => GetProperty<TerraformProperty<bool>>("include_unverified");
        set => this.WithProperty("include_unverified", value);
    }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    public TerraformProperty<bool>? OnlyDefault
    {
        get => GetProperty<TerraformProperty<bool>>("only_default");
        set => this.WithProperty("only_default", value);
    }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    public TerraformProperty<bool>? OnlyInitial
    {
        get => GetProperty<TerraformProperty<bool>>("only_initial");
        set => this.WithProperty("only_initial", value);
    }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    public TerraformProperty<bool>? OnlyRoot
    {
        get => GetProperty<TerraformProperty<bool>>("only_root");
        set => this.WithProperty("only_root", value);
    }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    public List<TerraformProperty<string>>? SupportsServices
    {
        get => GetProperty<List<TerraformProperty<string>>>("supports_services");
        set => this.WithProperty("supports_services", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDomainsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadDomainsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    public TerraformExpression Domains => this["domains"];

}
