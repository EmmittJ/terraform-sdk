using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineTargetSite.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineTargetSiteTimeoutsBlock : TerraformBlock
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
/// Represents a google_discovery_engine_target_site Terraform resource.
/// Manages a google_discovery_engine_target_site resource.
/// </summary>
public partial class GoogleDiscoveryEngineTargetSite(string name) : TerraformResource("google_discovery_engine_target_site", name)
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
    /// If set to false, a uri_pattern is generated to include all pages whose
    /// address contains the provided_uri_pattern. If set to true, an uri_pattern
    /// is generated to try to be an exact match of the provided_uri_pattern or
    /// just the specific page if the provided_uri_pattern is a specific one.
    /// provided_uri_pattern is always normalized to generate the URI pattern to
    /// be used by the search engine.
    /// </summary>
    public TerraformValue<bool>? ExactMatch
    {
        get => new TerraformReference<bool>(this, "exact_match");
        set => SetArgument("exact_match", value);
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
    /// The user provided URI pattern from which the &#39;generated_uri_pattern&#39; is
    /// generated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvidedUriPattern is required")]
    public required TerraformValue<string> ProvidedUriPattern
    {
        get => new TerraformReference<string>(this, "provided_uri_pattern");
        set => SetArgument("provided_uri_pattern", value);
    }

    /// <summary>
    /// The possible target site types. Possible values: [&amp;quot;INCLUDE&amp;quot;, &amp;quot;EXCLUDE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Site search indexing failure reasons.
    /// </summary>
    public TerraformList<TerraformMap<object>> FailureReason
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "failure_reason").ResolveNodes(ctx));
    }

    /// <summary>
    /// This is system-generated based on the &#39;provided_uri_pattern&#39;.
    /// </summary>
    public TerraformValue<string> GeneratedUriPattern
    {
        get => new TerraformReference<string>(this, "generated_uri_pattern");
    }

    /// <summary>
    /// The indexing status.
    /// </summary>
    public TerraformValue<string> IndexingStatus
    {
        get => new TerraformReference<string>(this, "indexing_status");
    }

    /// <summary>
    /// The unique full resource name of the target site. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/targetSites/{target_site_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Root domain of the &#39;provided_uri_pattern&#39;.
    /// </summary>
    public TerraformValue<string> RootDomainUri
    {
        get => new TerraformReference<string>(this, "root_domain_uri");
    }

    /// <summary>
    /// Site ownership and validity verification status.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteVerificationInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "site_verification_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique id of the target site.
    /// </summary>
    public TerraformValue<string> TargetSiteId
    {
        get => new TerraformReference<string>(this, "target_site_id");
    }

    /// <summary>
    /// The target site&#39;s last updated time.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineTargetSiteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineTargetSiteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
