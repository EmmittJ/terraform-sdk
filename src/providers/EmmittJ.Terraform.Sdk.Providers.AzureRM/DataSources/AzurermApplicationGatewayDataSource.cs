using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_application_gateway.
/// </summary>
public class AzurermApplicationGatewayDataSource : TerraformDataSource
{
    public AzurermApplicationGatewayDataSource(string name) : base("azurerm_application_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("authentication_certificate");
        this.WithOutput("autoscale_configuration");
        this.WithOutput("backend_address_pool");
        this.WithOutput("backend_http_settings");
        this.WithOutput("custom_error_configuration");
        this.WithOutput("fips_enabled");
        this.WithOutput("firewall_policy_id");
        this.WithOutput("force_firewall_policy_association");
        this.WithOutput("frontend_ip_configuration");
        this.WithOutput("frontend_port");
        this.WithOutput("gateway_ip_configuration");
        this.WithOutput("global");
        this.WithOutput("http2_enabled");
        this.WithOutput("http_listener");
        this.WithOutput("identity");
        this.WithOutput("location");
        this.WithOutput("private_endpoint_connection");
        this.WithOutput("private_link_configuration");
        this.WithOutput("probe");
        this.WithOutput("redirect_configuration");
        this.WithOutput("request_routing_rule");
        this.WithOutput("rewrite_rule_set");
        this.WithOutput("sku");
        this.WithOutput("ssl_certificate");
        this.WithOutput("ssl_policy");
        this.WithOutput("ssl_profile");
        this.WithOutput("tags");
        this.WithOutput("trusted_client_certificate");
        this.WithOutput("trusted_root_certificate");
        this.WithOutput("url_path_map");
        this.WithOutput("waf_configuration");
        this.WithOutput("zones");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApplicationGatewayDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The authentication_certificate attribute.
    /// </summary>
    public TerraformExpression AuthenticationCertificate => this["authentication_certificate"];

    /// <summary>
    /// The autoscale_configuration attribute.
    /// </summary>
    public TerraformExpression AutoscaleConfiguration => this["autoscale_configuration"];

    /// <summary>
    /// The backend_address_pool attribute.
    /// </summary>
    public TerraformExpression BackendAddressPool => this["backend_address_pool"];

    /// <summary>
    /// The backend_http_settings attribute.
    /// </summary>
    public TerraformExpression BackendHttpSettings => this["backend_http_settings"];

    /// <summary>
    /// The custom_error_configuration attribute.
    /// </summary>
    public TerraformExpression CustomErrorConfiguration => this["custom_error_configuration"];

    /// <summary>
    /// The fips_enabled attribute.
    /// </summary>
    public TerraformExpression FipsEnabled => this["fips_enabled"];

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    public TerraformExpression FirewallPolicyId => this["firewall_policy_id"];

    /// <summary>
    /// The force_firewall_policy_association attribute.
    /// </summary>
    public TerraformExpression ForceFirewallPolicyAssociation => this["force_firewall_policy_association"];

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfiguration => this["frontend_ip_configuration"];

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformExpression FrontendPort => this["frontend_port"];

    /// <summary>
    /// The gateway_ip_configuration attribute.
    /// </summary>
    public TerraformExpression GatewayIpConfiguration => this["gateway_ip_configuration"];

    /// <summary>
    /// The global attribute.
    /// </summary>
    public TerraformExpression Global => this["global"];

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformExpression Http2Enabled => this["http2_enabled"];

    /// <summary>
    /// The http_listener attribute.
    /// </summary>
    public TerraformExpression HttpListener => this["http_listener"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The private_endpoint_connection attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointConnection => this["private_endpoint_connection"];

    /// <summary>
    /// The private_link_configuration attribute.
    /// </summary>
    public TerraformExpression PrivateLinkConfiguration => this["private_link_configuration"];

    /// <summary>
    /// The probe attribute.
    /// </summary>
    public TerraformExpression Probe => this["probe"];

    /// <summary>
    /// The redirect_configuration attribute.
    /// </summary>
    public TerraformExpression RedirectConfiguration => this["redirect_configuration"];

    /// <summary>
    /// The request_routing_rule attribute.
    /// </summary>
    public TerraformExpression RequestRoutingRule => this["request_routing_rule"];

    /// <summary>
    /// The rewrite_rule_set attribute.
    /// </summary>
    public TerraformExpression RewriteRuleSet => this["rewrite_rule_set"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The ssl_certificate attribute.
    /// </summary>
    public TerraformExpression SslCertificate => this["ssl_certificate"];

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformExpression SslPolicy => this["ssl_policy"];

    /// <summary>
    /// The ssl_profile attribute.
    /// </summary>
    public TerraformExpression SslProfile => this["ssl_profile"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The trusted_client_certificate attribute.
    /// </summary>
    public TerraformExpression TrustedClientCertificate => this["trusted_client_certificate"];

    /// <summary>
    /// The trusted_root_certificate attribute.
    /// </summary>
    public TerraformExpression TrustedRootCertificate => this["trusted_root_certificate"];

    /// <summary>
    /// The url_path_map attribute.
    /// </summary>
    public TerraformExpression UrlPathMap => this["url_path_map"];

    /// <summary>
    /// The waf_configuration attribute.
    /// </summary>
    public TerraformExpression WafConfiguration => this["waf_configuration"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
