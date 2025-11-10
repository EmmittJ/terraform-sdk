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
        set => SetProperty("compression_enabled", value);
    }

    /// <summary>
    /// The content_types_to_compress attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ContentTypesToCompress
    {
        set => SetProperty("content_types_to_compress", value);
    }

    /// <summary>
    /// The query_string_caching_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? QueryStringCachingBehavior
    {
        set => SetProperty("query_string_caching_behavior", value);
    }

    /// <summary>
    /// The query_strings attribute.
    /// </summary>
    public List<TerraformProperty<string>>? QueryStrings
    {
        set => SetProperty("query_strings", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("cdn_frontdoor_custom_domain_ids");
        SetOutput("cdn_frontdoor_endpoint_id");
        SetOutput("cdn_frontdoor_origin_group_id");
        SetOutput("cdn_frontdoor_origin_ids");
        SetOutput("cdn_frontdoor_origin_path");
        SetOutput("cdn_frontdoor_rule_set_ids");
        SetOutput("enabled");
        SetOutput("forwarding_protocol");
        SetOutput("https_redirect_enabled");
        SetOutput("id");
        SetOutput("link_to_default_domain");
        SetOutput("name");
        SetOutput("patterns_to_match");
        SetOutput("supported_protocols");
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CdnFrontdoorCustomDomainIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cdn_frontdoor_custom_domain_ids");
        set => SetProperty("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorEndpointId is required")]
    public required TerraformProperty<string> CdnFrontdoorEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_endpoint_id");
        set => SetProperty("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    public required TerraformProperty<string> CdnFrontdoorOriginGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_origin_group_id");
        set => SetProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginIds is required")]
    public List<TerraformProperty<string>> CdnFrontdoorOriginIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cdn_frontdoor_origin_ids");
        set => SetProperty("cdn_frontdoor_origin_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    public TerraformProperty<string> CdnFrontdoorOriginPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_origin_path");
        set => SetProperty("cdn_frontdoor_origin_path", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CdnFrontdoorRuleSetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cdn_frontdoor_rule_set_ids");
        set => SetProperty("cdn_frontdoor_rule_set_ids", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public TerraformProperty<string> ForwardingProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("forwarding_protocol");
        set => SetProperty("forwarding_protocol", value);
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HttpsRedirectEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_redirect_enabled");
        set => SetProperty("https_redirect_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The link_to_default_domain attribute.
    /// </summary>
    public TerraformProperty<bool> LinkToDefaultDomain
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("link_to_default_domain");
        set => SetProperty("link_to_default_domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public List<TerraformProperty<string>> PatternsToMatch
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("patterns_to_match");
        set => SetProperty("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedProtocols is required")]
    public HashSet<TerraformProperty<string>> SupportedProtocols
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("supported_protocols");
        set => SetProperty("supported_protocols", value);
    }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    public List<AzurermCdnFrontdoorRouteCacheBlock>? Cache
    {
        set => SetProperty("cache", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
