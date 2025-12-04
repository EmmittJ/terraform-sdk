using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service Terraform data source.
/// Retrieves information about a azurerm_app_service.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppServiceDataSource(string name) : TerraformDataSource("azurerm_app_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformValue<string> AppServicePlanId
        => AsReference("app_service_plan_id");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
        => AsReference("app_settings");

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientAffinityEnabled
        => AsReference("client_affinity_enabled");

    /// <summary>
    /// The client_cert_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientCertEnabled
        => AsReference("client_cert_enabled");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionString
        => AsReference("connection_string");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => AsReference("custom_domain_verification_id");

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultSiteHostname
        => AsReference("default_site_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
        => AsReference("https_only");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
        => AsReference("outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => AsReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
        => AsReference("possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => AsReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteConfig
        => AsReference("site_config");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => AsReference("site_credential");

    /// <summary>
    /// The source_control attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceControl
        => AsReference("source_control");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
