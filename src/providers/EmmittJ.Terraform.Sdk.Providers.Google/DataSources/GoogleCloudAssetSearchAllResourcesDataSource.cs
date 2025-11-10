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
        this.WithOutput("results");
    }

    /// <summary>
    /// The asset_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AssetTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("asset_types");
        set => this.WithProperty("asset_types", value);
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
    /// The query attribute.
    /// </summary>
    public TerraformProperty<string>? Query
    {
        get => GetProperty<TerraformProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The results attribute.
    /// </summary>
    public TerraformExpression Results => this["results"];

}
