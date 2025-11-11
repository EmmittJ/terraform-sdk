using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineTargetSiteTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_target_site resource.
/// </summary>
public partial class GoogleDiscoveryEngineTargetSite : TerraformResource
{
    public GoogleDiscoveryEngineTargetSite(string name) : base("google_discovery_engine_target_site", name)
    {
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    [TerraformProperty("data_store_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataStoreId { get; set; }

    /// <summary>
    /// If set to false, a uri_pattern is generated to include all pages whose
    /// address contains the provided_uri_pattern. If set to true, an uri_pattern
    /// is generated to try to be an exact match of the provided_uri_pattern or
    /// just the specific page if the provided_uri_pattern is a specific one.
    /// provided_uri_pattern is always normalized to generate the URI pattern to
    /// be used by the search engine.
    /// </summary>
    [TerraformProperty("exact_match")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ExactMatch { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The user provided URI pattern from which the &#39;generated_uri_pattern&#39; is
    /// generated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvidedUriPattern is required")]
    [TerraformProperty("provided_uri_pattern")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProvidedUriPattern { get; set; }

    /// <summary>
    /// The possible target site types. Possible values: [&amp;quot;INCLUDE&amp;quot;, &amp;quot;EXCLUDE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineTargetSiteTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Site search indexing failure reasons.
    /// </summary>
    [TerraformProperty("failure_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> FailureReason { get; }

    /// <summary>
    /// This is system-generated based on the &#39;provided_uri_pattern&#39;.
    /// </summary>
    [TerraformProperty("generated_uri_pattern")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GeneratedUriPattern { get; }

    /// <summary>
    /// The indexing status.
    /// </summary>
    [TerraformProperty("indexing_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IndexingStatus { get; }

    /// <summary>
    /// The unique full resource name of the target site. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/targetSites/{target_site_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Root domain of the &#39;provided_uri_pattern&#39;.
    /// </summary>
    [TerraformProperty("root_domain_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RootDomainUri { get; }

    /// <summary>
    /// Site ownership and validity verification status.
    /// </summary>
    [TerraformProperty("site_verification_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SiteVerificationInfo { get; }

    /// <summary>
    /// The unique id of the target site.
    /// </summary>
    [TerraformProperty("target_site_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TargetSiteId { get; }

    /// <summary>
    /// The target site&#39;s last updated time.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
