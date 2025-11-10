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
        set => SetProperty("read", value);
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
        SetOutput("domains");
        SetOutput("admin_managed");
        SetOutput("id");
        SetOutput("include_unverified");
        SetOutput("only_default");
        SetOutput("only_initial");
        SetOutput("only_root");
        SetOutput("supports_services");
    }

    /// <summary>
    /// Set to `true` to only return domains whose DNS is managed by Microsoft 365
    /// </summary>
    public TerraformProperty<bool> AdminManaged
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("admin_managed");
        set => SetProperty("admin_managed", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    public TerraformProperty<bool> IncludeUnverified
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_unverified");
        set => SetProperty("include_unverified", value);
    }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    public TerraformProperty<bool> OnlyDefault
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("only_default");
        set => SetProperty("only_default", value);
    }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    public TerraformProperty<bool> OnlyInitial
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("only_initial");
        set => SetProperty("only_initial", value);
    }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    public TerraformProperty<bool> OnlyRoot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("only_root");
        set => SetProperty("only_root", value);
    }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    public List<TerraformProperty<string>> SupportsServices
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("supports_services");
        set => SetProperty("supports_services", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDomainsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    public TerraformExpression Domains => this["domains"];

}
