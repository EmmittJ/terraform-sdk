using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDomainsDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadDomainsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_domains Terraform data source.
/// Retrieves information about a azuread_domains.
/// </summary>
public partial class AzureadDomainsDataSource(string name) : TerraformDataSource("azuread_domains", name)
{
    /// <summary>
    /// Set to `true` to only return domains whose DNS is managed by Microsoft 365
    /// </summary>
    public TerraformValue<bool>? AdminManaged
    {
        get => GetArgument<TerraformValue<bool>>("admin_managed");
        set => SetArgument("admin_managed", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set to `true` if unverified Azure AD domains should be included
    /// </summary>
    public TerraformValue<bool>? IncludeUnverified
    {
        get => GetArgument<TerraformValue<bool>>("include_unverified");
        set => SetArgument("include_unverified", value);
    }

    /// <summary>
    /// Set to `true` to only return the default domain
    /// </summary>
    public TerraformValue<bool>? OnlyDefault
    {
        get => GetArgument<TerraformValue<bool>>("only_default");
        set => SetArgument("only_default", value);
    }

    /// <summary>
    /// Set to `true` to only return the initial domain, which is your primary Azure Active Directory tenant domain
    /// </summary>
    public TerraformValue<bool>? OnlyInitial
    {
        get => GetArgument<TerraformValue<bool>>("only_initial");
        set => SetArgument("only_initial", value);
    }

    /// <summary>
    /// Set to `true` to only return verified root domains. Excludes subdomains and unverified domains
    /// </summary>
    public TerraformValue<bool>? OnlyRoot
    {
        get => GetArgument<TerraformValue<bool>>("only_root");
        set => SetArgument("only_root", value);
    }

    /// <summary>
    /// A list of supported services that must be supported by a domain
    /// </summary>
    public TerraformList<string>? SupportsServices
    {
        get => GetArgument<TerraformList<string>>("supports_services");
        set => SetArgument("supports_services", value);
    }

    /// <summary>
    /// A list of tenant domains
    /// </summary>
    public TerraformList<TerraformMap<object>> Domains
        => AsReference("domains");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDomainsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDomainsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
