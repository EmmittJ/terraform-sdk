using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineTargetSiteTimeoutsBlock : TerraformBlock
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
/// Manages a google_discovery_engine_target_site resource.
/// </summary>
public class GoogleDiscoveryEngineTargetSite : TerraformResource
{
    public GoogleDiscoveryEngineTargetSite(string name) : base("google_discovery_engine_target_site", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("failure_reason");
        this.WithOutput("generated_uri_pattern");
        this.WithOutput("indexing_status");
        this.WithOutput("name");
        this.WithOutput("root_domain_uri");
        this.WithOutput("site_verification_info");
        this.WithOutput("target_site_id");
        this.WithOutput("update_time");
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
    /// If set to false, a uri_pattern is generated to include all pages whose
    /// address contains the provided_uri_pattern. If set to true, an uri_pattern
    /// is generated to try to be an exact match of the provided_uri_pattern or
    /// just the specific page if the provided_uri_pattern is a specific one.
    /// provided_uri_pattern is always normalized to generate the URI pattern to
    /// be used by the search engine.
    /// </summary>
    public TerraformProperty<bool>? ExactMatch
    {
        get => GetProperty<TerraformProperty<bool>>("exact_match");
        set => this.WithProperty("exact_match", value);
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
    /// The user provided URI pattern from which the &#39;generated_uri_pattern&#39; is
    /// generated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvidedUriPattern is required")]
    public required TerraformProperty<string> ProvidedUriPattern
    {
        get => GetRequiredProperty<TerraformProperty<string>>("provided_uri_pattern");
        set => this.WithProperty("provided_uri_pattern", value);
    }

    /// <summary>
    /// The possible target site types. Possible values: [&amp;quot;INCLUDE&amp;quot;, &amp;quot;EXCLUDE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineTargetSiteTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineTargetSiteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Site search indexing failure reasons.
    /// </summary>
    public TerraformExpression FailureReason => this["failure_reason"];

    /// <summary>
    /// This is system-generated based on the &#39;provided_uri_pattern&#39;.
    /// </summary>
    public TerraformExpression GeneratedUriPattern => this["generated_uri_pattern"];

    /// <summary>
    /// The indexing status.
    /// </summary>
    public TerraformExpression IndexingStatus => this["indexing_status"];

    /// <summary>
    /// The unique full resource name of the target site. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/targetSites/{target_site_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Root domain of the &#39;provided_uri_pattern&#39;.
    /// </summary>
    public TerraformExpression RootDomainUri => this["root_domain_uri"];

    /// <summary>
    /// Site ownership and validity verification status.
    /// </summary>
    public TerraformExpression SiteVerificationInfo => this["site_verification_info"];

    /// <summary>
    /// The unique id of the target site.
    /// </summary>
    public TerraformExpression TargetSiteId => this["target_site_id"];

    /// <summary>
    /// The target site&#39;s last updated time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
