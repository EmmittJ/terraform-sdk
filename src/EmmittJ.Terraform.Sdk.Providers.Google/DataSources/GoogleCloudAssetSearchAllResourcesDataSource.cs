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
        this.DeclareOutput("results");
    }

    /// <summary>
    /// The asset_types attribute.
    /// </summary>
    public List<string>? AssetTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("asset_types")?.Value;
        set => this.WithProperty("asset_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The query attribute.
    /// </summary>
    public string? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query")?.Value;
        set => this.WithProperty("query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The results attribute.
    /// </summary>
    public TerraformExpression Results => this["results"];

}
