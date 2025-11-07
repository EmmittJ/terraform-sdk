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
    public TerraformLiteralProperty<HashSet<string>>? CdnFrontdoorCustomDomainIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cdn_frontdoor_custom_domain_ids");
        set => this.WithProperty("cdn_frontdoor_custom_domain_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CdnFrontdoorEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_endpoint_id");
        set => this.WithProperty("cdn_frontdoor_endpoint_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CdnFrontdoorOriginGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_origin_group_id");
        set => this.WithProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? CdnFrontdoorOriginIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cdn_frontdoor_origin_ids");
        set => this.WithProperty("cdn_frontdoor_origin_ids", value);
    }

    /// <summary>
    /// The cdn_frontdoor_origin_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CdnFrontdoorOriginPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_origin_path");
        set => this.WithProperty("cdn_frontdoor_origin_path", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CdnFrontdoorRuleSetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cdn_frontdoor_rule_set_ids");
        set => this.WithProperty("cdn_frontdoor_rule_set_ids", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ForwardingProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forwarding_protocol");
        set => this.WithProperty("forwarding_protocol", value);
    }

    /// <summary>
    /// The https_redirect_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HttpsRedirectEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_redirect_enabled");
        set => this.WithProperty("https_redirect_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The link_to_default_domain attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LinkToDefaultDomain
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("link_to_default_domain");
        set => this.WithProperty("link_to_default_domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PatternsToMatch
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("patterns_to_match");
        set => this.WithProperty("patterns_to_match", value);
    }

    /// <summary>
    /// The supported_protocols attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SupportedProtocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_protocols");
        set => this.WithProperty("supported_protocols", value);
    }

}
