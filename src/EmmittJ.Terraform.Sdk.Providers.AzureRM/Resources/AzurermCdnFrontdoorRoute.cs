using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_frontdoor_route resource.
/// </summary>
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
    public TerraformProperty<HashSet<string>>? CdnFrontdoorCustomDomainIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("cdn_frontdoor_custom_domain_ids");
        set => this.WithProperty("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_endpoint_id");
        set => this.WithProperty("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_origin_group_id");
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? CdnFrontdoorOriginIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("cdn_frontdoor_origin_ids");
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
    public TerraformProperty<HashSet<string>>? CdnFrontdoorRuleSetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("cdn_frontdoor_rule_set_ids");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PatternsToMatch
    {
        get => GetProperty<TerraformProperty<List<string>>>("patterns_to_match");
        set => this.WithProperty("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SupportedProtocols
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("supported_protocols");
        set => this.WithProperty("supported_protocols", value);
    }

}
