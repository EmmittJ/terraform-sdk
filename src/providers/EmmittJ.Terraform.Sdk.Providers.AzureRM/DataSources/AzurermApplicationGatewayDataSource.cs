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
        set => SetProperty("read", value);
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
        SetOutput("authentication_certificate");
        SetOutput("autoscale_configuration");
        SetOutput("backend_address_pool");
        SetOutput("backend_http_settings");
        SetOutput("custom_error_configuration");
        SetOutput("fips_enabled");
        SetOutput("firewall_policy_id");
        SetOutput("force_firewall_policy_association");
        SetOutput("frontend_ip_configuration");
        SetOutput("frontend_port");
        SetOutput("gateway_ip_configuration");
        SetOutput("global");
        SetOutput("http2_enabled");
        SetOutput("http_listener");
        SetOutput("identity");
        SetOutput("location");
        SetOutput("private_endpoint_connection");
        SetOutput("private_link_configuration");
        SetOutput("probe");
        SetOutput("redirect_configuration");
        SetOutput("request_routing_rule");
        SetOutput("rewrite_rule_set");
        SetOutput("sku");
        SetOutput("ssl_certificate");
        SetOutput("ssl_policy");
        SetOutput("ssl_profile");
        SetOutput("tags");
        SetOutput("trusted_client_certificate");
        SetOutput("trusted_root_certificate");
        SetOutput("url_path_map");
        SetOutput("waf_configuration");
        SetOutput("zones");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationGatewayDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
