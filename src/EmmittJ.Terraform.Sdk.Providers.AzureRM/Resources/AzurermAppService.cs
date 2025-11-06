using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAppService : TerraformResource
{
    public AzurermAppService(string name) : base("azurerm_app_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_site_hostname");
        this.DeclareOutput("outbound_ip_address_list");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_address_list");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_credential");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public string? AppServicePlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_plan_id")?.Value;
        set => this.WithProperty("app_service_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, string>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings")?.Value;
        set => this.WithProperty("app_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public bool? ClientAffinityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_affinity_enabled")?.Value;
        set => this.WithProperty("client_affinity_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_cert_enabled attribute.
    /// </summary>
    public bool? ClientCertEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_cert_enabled")?.Value;
        set => this.WithProperty("client_cert_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    public string? ClientCertMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_cert_mode")?.Value;
        set => this.WithProperty("client_cert_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The https_only attribute.
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public string? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_reference_identity_id")?.Value;
        set => this.WithProperty("key_vault_reference_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultSiteHostname => this["default_site_hostname"];

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddressList => this["outbound_ip_address_list"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddressList => this["possible_outbound_ip_address_list"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}
