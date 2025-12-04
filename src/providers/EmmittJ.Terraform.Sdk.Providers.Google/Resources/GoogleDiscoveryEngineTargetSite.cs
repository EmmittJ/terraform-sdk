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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
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
        get => GetArgument<TerraformValue<string>>("data_store_id");
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
        get => GetArgument<TerraformValue<bool>>("exact_match");
        set => SetArgument("exact_match", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user provided URI pattern from which the &#39;generated_uri_pattern&#39; is
    /// generated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvidedUriPattern is required")]
    public required TerraformValue<string> ProvidedUriPattern
    {
        get => GetArgument<TerraformValue<string>>("provided_uri_pattern");
        set => SetArgument("provided_uri_pattern", value);
    }

    /// <summary>
    /// The possible target site types. Possible values: [&amp;quot;INCLUDE&amp;quot;, &amp;quot;EXCLUDE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Site search indexing failure reasons.
    /// </summary>
    public TerraformList<TerraformMap<object>> FailureReason
        => AsReference("failure_reason");

    /// <summary>
    /// This is system-generated based on the &#39;provided_uri_pattern&#39;.
    /// </summary>
    public TerraformValue<string> GeneratedUriPattern
        => AsReference("generated_uri_pattern");

    /// <summary>
    /// The indexing status.
    /// </summary>
    public TerraformValue<string> IndexingStatus
        => AsReference("indexing_status");

    /// <summary>
    /// The unique full resource name of the target site. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/siteSearchEngine/targetSites/{target_site_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Root domain of the &#39;provided_uri_pattern&#39;.
    /// </summary>
    public TerraformValue<string> RootDomainUri
        => AsReference("root_domain_uri");

    /// <summary>
    /// Site ownership and validity verification status.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteVerificationInfo
        => AsReference("site_verification_info");

    /// <summary>
    /// The unique id of the target site.
    /// </summary>
    public TerraformValue<string> TargetSiteId
        => AsReference("target_site_id");

    /// <summary>
    /// The target site&#39;s last updated time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineTargetSiteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineTargetSiteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
