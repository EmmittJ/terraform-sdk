using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineSitemapTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_discovery_engine_sitemap resource.
/// </summary>
public class GoogleDiscoveryEngineSitemap : TerraformResource
{
    public GoogleDiscoveryEngineSitemap(string name) : base("google_discovery_engine_sitemap", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("name");
        this.WithOutput("sitemap_id");
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    public required TerraformProperty<string> DataStoreId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_store_id");
        set => this.WithProperty("data_store_id", value);
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Public URI for the sitemap, e.g. &amp;quot;www.example.com/sitemap.xml&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => this.WithProperty("uri", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineSitemapTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineSitemapTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Timestamp when the sitemap was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The unique full resource name of the sitemap. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/sitemaps/{sitemap_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The unique id of the sitemap.
    /// </summary>
    public TerraformExpression SitemapId => this["sitemap_id"];

}
