using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_asset_search_all_resources.
/// </summary>
public class GoogleCloudAssetSearchAllResourcesDataSource : TerraformDataSource
{
    public GoogleCloudAssetSearchAllResourcesDataSource(string name) : base("google_cloud_asset_search_all_resources", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("results");
        SetOutput("asset_types");
        SetOutput("id");
        SetOutput("query");
        SetOutput("scope");
    }

    /// <summary>
    /// The asset_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> AssetTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("asset_types");
        set => SetProperty("asset_types", value);
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
    /// The query attribute.
    /// </summary>
    public TerraformProperty<string> Query
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query");
        set => SetProperty("query", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The results attribute.
    /// </summary>
    public TerraformExpression Results => this["results"];

}
