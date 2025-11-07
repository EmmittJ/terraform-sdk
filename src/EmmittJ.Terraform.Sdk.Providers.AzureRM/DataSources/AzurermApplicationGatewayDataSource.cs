using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("authentication_certificate");
        this.DeclareOutput("autoscale_configuration");
        this.DeclareOutput("backend_address_pool");
        this.DeclareOutput("backend_http_settings");
        this.DeclareOutput("custom_error_configuration");
        this.DeclareOutput("fips_enabled");
        this.DeclareOutput("firewall_policy_id");
        this.DeclareOutput("force_firewall_policy_association");
        this.DeclareOutput("frontend_ip_configuration");
        this.DeclareOutput("frontend_port");
        this.DeclareOutput("gateway_ip_configuration");
        this.DeclareOutput("global");
        this.DeclareOutput("http2_enabled");
        this.DeclareOutput("http_listener");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("private_endpoint_connection");
        this.DeclareOutput("private_link_configuration");
        this.DeclareOutput("probe");
        this.DeclareOutput("redirect_configuration");
        this.DeclareOutput("request_routing_rule");
        this.DeclareOutput("rewrite_rule_set");
        this.DeclareOutput("sku");
        this.DeclareOutput("ssl_certificate");
        this.DeclareOutput("ssl_policy");
        this.DeclareOutput("ssl_profile");
        this.DeclareOutput("tags");
        this.DeclareOutput("trusted_client_certificate");
        this.DeclareOutput("trusted_root_certificate");
        this.DeclareOutput("url_path_map");
        this.DeclareOutput("waf_configuration");
        this.DeclareOutput("zones");
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
