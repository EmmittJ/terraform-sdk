using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_service_accounts Terraform data source.
/// Retrieves information about a google_service_accounts.
/// </summary>
public partial class GoogleServiceAccountsDataSource(string name) : TerraformDataSource("google_service_accounts", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformValue<string>? Regex
    {
        get => new TerraformReference<string>(this, "regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Accounts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "accounts").ResolveNodes(ctx));
    }

}
