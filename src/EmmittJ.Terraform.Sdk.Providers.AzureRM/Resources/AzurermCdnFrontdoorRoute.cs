using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorRouteCacheBlock : TerraformBlock
{
    /// <summary>
    /// The compression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CompressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("compression_enabled");
        set => WithProperty("compression_enabled", value);
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ContentTypesToCompress
    {
        get => GetProperty<List<TerraformProperty<string>>>("content_types_to_compress");
        set => WithProperty("content_types_to_compress", value);
    }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? QueryStringCachingBehavior
    {
        get => GetProperty<TerraformProperty<string>>("query_string_caching_behavior");
        set => WithProperty("query_string_caching_behavior", value);
    }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
    public List<TerraformProperty<string>>? QueryStrings
    {
        get => GetProperty<List<TerraformProperty<string>>>("query_strings");
        set => WithProperty("query_strings", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorRouteTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorRoute : TerraformResource
{
    public AzurermCdnFrontdoorRoute(string name) : base("azurerm_cdn_frontdoor_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CdnFrontdoorCustomDomainIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cdn_frontdoor_custom_domain_ids");
        set => this.WithProperty("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    public required TerraformProperty<string> CdnFrontdoorEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_endpoint_id");
        set => this.WithProperty("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    public required TerraformProperty<string> CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_origin_group_id");
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    public List<TerraformProperty<string>>? CdnFrontdoorOriginIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("cdn_frontdoor_origin_ids");
        set => this.WithProperty("cdn_frontdoor_origin_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorOriginPath
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_origin_path");
        set => this.WithProperty("cdn_frontdoor_origin_path", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CdnFrontdoorRuleSetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cdn_frontdoor_rule_set_ids");
        set => this.WithProperty("cdn_frontdoor_rule_set_ids", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ForwardingProtocol
    {
        get => GetProperty<TerraformProperty<string>>("forwarding_protocol");
        set => this.WithProperty("forwarding_protocol", value);
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsRedirectEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("https_redirect_enabled");
        set => this.WithProperty("https_redirect_enabled", value);
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
    /// The link_to_default_domain attribute.
    /// </summary>
    public TerraformProperty<bool>? LinkToDefaultDomain
    {
        get => GetProperty<TerraformProperty<bool>>("link_to_default_domain");
        set => this.WithProperty("link_to_default_domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public List<TerraformProperty<string>>? PatternsToMatch
    {
        get => GetProperty<List<TerraformProperty<string>>>("patterns_to_match");
        set => this.WithProperty("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    public HashSet<TerraformProperty<string>>? SupportedProtocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("supported_protocols");
        set => this.WithProperty("supported_protocols", value);
    }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    public List<AzurermCdnFrontdoorRouteCacheBlock>? Cache
    {
        get => GetProperty<List<AzurermCdnFrontdoorRouteCacheBlock>>("cache");
        set => this.WithProperty("cache", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorRouteTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnFrontdoorRouteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
