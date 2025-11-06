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
    public bool? AdminManaged
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("admin_managed")?.Value;
        set => this.WithProperty("admin_managed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    public bool? IncludeUnverified
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_unverified")?.Value;
        set => this.WithProperty("include_unverified", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    public bool? OnlyDefault
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_default")?.Value;
        set => this.WithProperty("only_default", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    public bool? OnlyInitial
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_initial")?.Value;
        set => this.WithProperty("only_initial", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    public bool? OnlyRoot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_root")?.Value;
        set => this.WithProperty("only_root", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    public List<string>? SupportsServices
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supports_services")?.Value;
        set => this.WithProperty("supports_services", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    public TerraformExpression Domains => this["domains"];

}
