using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("failure_reason");
        this.DeclareOutput("generated_uri_pattern");
        this.DeclareOutput("indexing_status");
        this.DeclareOutput("name");
        this.DeclareOutput("root_domain_uri");
        this.DeclareOutput("site_verification_info");
        this.DeclareOutput("target_site_id");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    public string? DataStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_store_id")?.Value;
        set => this.WithProperty("data_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to false, a uri_pattern is generated to include all pages whose
    /// address contains the provided_uri_pattern. If set to true, an uri_pattern
    /// is generated to try to be an exact match of the provided_uri_pattern or
    /// just the specific page if the provided_uri_pattern is a specific one.
    /// provided_uri_pattern is always normalized to generate the URI pattern to
    /// be used by the search engine.
    /// </summary>
    public bool? ExactMatch
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exact_match")?.Value;
        set => this.WithProperty("exact_match", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user provided URI pattern from which the &#39;generated_uri_pattern&#39; is
    /// generated.
    /// </summary>
    public string? ProvidedUriPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provided_uri_pattern")?.Value;
        set => this.WithProperty("provided_uri_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The possible target site types. Possible values: [&amp;quot;INCLUDE&amp;quot;, &amp;quot;EXCLUDE&amp;quot;]
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
