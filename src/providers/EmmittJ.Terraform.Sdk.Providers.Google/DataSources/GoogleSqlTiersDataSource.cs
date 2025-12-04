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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Project ID of the project for which to list tiers.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The tiers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Tiers
        => AsReference("tiers");

}
