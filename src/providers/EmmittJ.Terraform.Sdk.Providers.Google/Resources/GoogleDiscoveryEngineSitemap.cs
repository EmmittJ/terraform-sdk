using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineSitemap.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineSitemapTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_discovery_engine_sitemap Terraform resource.
/// Manages a google_discovery_engine_sitemap resource.
/// </summary>
public partial class GoogleDiscoveryEngineSitemap(string name) : TerraformResource("google_discovery_engine_sitemap", name)
{
    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    public required TerraformValue<string> DataStoreId
    {
        get => new TerraformReference<string>(this, "data_store_id");
        set => SetArgument("data_store_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Public URI for the sitemap, e.g. &amp;quot;www.example.com/sitemap.xml&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// Timestamp when the sitemap was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The unique full resource name of the sitemap. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/sitemaps/{sitemap_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The unique id of the sitemap.
    /// </summary>
    public TerraformValue<string> SitemapId
    {
        get => new TerraformReference<string>(this, "sitemap_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineSitemapTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineSitemapTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
