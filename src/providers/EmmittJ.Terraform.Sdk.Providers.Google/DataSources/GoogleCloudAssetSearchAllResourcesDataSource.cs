using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloud_asset_search_all_resources Terraform data source.
/// Retrieves information about a google_cloud_asset_search_all_resources.
/// </summary>
public partial class GoogleCloudAssetSearchAllResourcesDataSource(string name) : TerraformDataSource("google_cloud_asset_search_all_resources", name)
{
    /// <summary>
    /// The asset_types attribute.
    /// </summary>
    public TerraformList<string>? AssetTypes
    {
        get => GetArgument<TerraformList<string>>("asset_types");
        set => SetArgument("asset_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    public TerraformValue<string>? Query
    {
        get => GetArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The results attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Results
        => AsReference("results");

}
