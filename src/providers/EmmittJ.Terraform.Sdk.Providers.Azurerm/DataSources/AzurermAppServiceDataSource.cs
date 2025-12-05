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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        => CreateReference("app_service_plan_id");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
        => CreateReference("app_settings");

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientAffinityEnabled
        => CreateReference("client_affinity_enabled");

    /// <summary>
    /// The client_cert_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientCertEnabled
        => CreateReference("client_cert_enabled");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionString
        => CreateReference("connection_string");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => CreateReference("custom_domain_verification_id");

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultSiteHostname
        => CreateReference("default_site_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => CreateReference("enabled");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
        => CreateReference("https_only");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
        => CreateReference("outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => CreateReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
        => CreateReference("possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => CreateReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteConfig
        => CreateReference("site_config");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => CreateReference("site_credential");

    /// <summary>
    /// The source_control attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceControl
        => CreateReference("source_control");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
