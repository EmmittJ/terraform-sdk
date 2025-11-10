using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineTargetSiteTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_target_site resource.
/// </summary>
public class GoogleDiscoveryEngineTargetSite : TerraformResource
{
    public GoogleDiscoveryEngineTargetSite(string name) : base("google_discovery_engine_target_site", name)
    {
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    [TerraformPropertyName("data_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataStoreId { get; set; }

    /// <summary>
    /// If set to false, a uri_pattern is generated to include all pages whose
    /// address contains the provided_uri_pattern. If set to true, an uri_pattern
    /// is generated to try to be an exact match of the provided_uri_pattern or
    /// just the specific page if the provided_uri_pattern is a specific one.
    /// provided_uri_pattern is always normalized to generate the URI pattern to
    /// be used by the search engine.
    /// </summary>
    [TerraformPropertyName("exact_match")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExactMatch { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The user provided URI pattern from which the &#39;generated_uri_pattern&#39; is
    /// generated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvidedUriPattern is required")]
    [TerraformPropertyName("provided_uri_pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProvidedUriPattern { get; set; }

    /// <summary>
    /// The possible target site types. Possible values: [&amp;quot;INCLUDE&amp;quot;, &amp;quot;EXCLUDE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineTargetSiteTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Site search indexing failure reasons.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FailureReason => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "failure_reason");

    /// <summary>
    /// This is system-generated based on the &#39;provided_uri_pattern&#39;.
    /// </summary>
    [TerraformPropertyName("generated_uri_pattern")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GeneratedUriPattern => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "generated_uri_pattern");

    /// <summary>
    /// The indexing status.
    /// </summary>
    [TerraformPropertyName("indexing_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IndexingStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "indexing_status");

    /// <summary>
    /// The unique full resource name of the target site. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/targetSites/{target_site_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Root domain of the &#39;provided_uri_pattern&#39;.
    /// </summary>
    [TerraformPropertyName("root_domain_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootDomainUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_domain_uri");

    /// <summary>
    /// Site ownership and validity verification status.
    /// </summary>
    [TerraformPropertyName("site_verification_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SiteVerificationInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "site_verification_info");

    /// <summary>
    /// The unique id of the target site.
    /// </summary>
    [TerraformPropertyName("target_site_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetSiteId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_site_id");

    /// <summary>
    /// The target site&#39;s last updated time.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
