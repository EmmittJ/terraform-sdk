using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_tiers Terraform data source.
/// Retrieves information about a google_sql_tiers.
/// </summary>
public partial class GoogleSqlTiersDataSource(string name) : TerraformDataSource("google_sql_tiers", name)
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
    /// Project ID of the project for which to list tiers.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The tiers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Tiers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "tiers").ResolveNodes(ctx));
    }

}
