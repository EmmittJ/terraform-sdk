using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
        this.DeclareOutput("domains");
    }

    /// <summary>
    /// Set to `true` to only return domains whose DNS is managed by Microsoft 365
    /// </summary>
    public TerraformLiteralProperty<bool>? AdminManaged
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("admin_managed");
        set => this.WithProperty("admin_managed", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeUnverified
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_unverified");
        set => this.WithProperty("include_unverified", value);
    }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    public TerraformLiteralProperty<bool>? OnlyDefault
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_default");
        set => this.WithProperty("only_default", value);
    }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    public TerraformLiteralProperty<bool>? OnlyInitial
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_initial");
        set => this.WithProperty("only_initial", value);
    }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    public TerraformLiteralProperty<bool>? OnlyRoot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_root");
        set => this.WithProperty("only_root", value);
    }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SupportsServices
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supports_services");
        set => this.WithProperty("supports_services", value);
    }

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    public TerraformExpression Domains => this["domains"];

}
