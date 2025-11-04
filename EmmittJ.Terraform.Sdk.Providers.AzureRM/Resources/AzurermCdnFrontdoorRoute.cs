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
    public HashSet<string>? CdnFrontdoorCustomDomainIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cdn_frontdoor_custom_domain_ids")?.Value;
        set => this.WithProperty("cdn_frontdoor_custom_domain_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    public string? CdnFrontdoorEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_endpoint_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    public string? CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_origin_group_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    public List<string>? CdnFrontdoorOriginIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cdn_frontdoor_origin_ids")?.Value;
        set => this.WithProperty("cdn_frontdoor_origin_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    public string? CdnFrontdoorOriginPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_origin_path")?.Value;
        set => this.WithProperty("cdn_frontdoor_origin_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    public HashSet<string>? CdnFrontdoorRuleSetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cdn_frontdoor_rule_set_ids")?.Value;
        set => this.WithProperty("cdn_frontdoor_rule_set_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public string? ForwardingProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forwarding_protocol")?.Value;
        set => this.WithProperty("forwarding_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    public bool? HttpsRedirectEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_redirect_enabled")?.Value;
        set => this.WithProperty("https_redirect_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The link_to_default_domain attribute.
    /// </summary>
    public bool? LinkToDefaultDomain
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("link_to_default_domain")?.Value;
        set => this.WithProperty("link_to_default_domain", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    public List<string>? PatternsToMatch
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("patterns_to_match")?.Value;
        set => this.WithProperty("patterns_to_match", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    public HashSet<string>? SupportedProtocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_protocols")?.Value;
        set => this.WithProperty("supported_protocols", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
