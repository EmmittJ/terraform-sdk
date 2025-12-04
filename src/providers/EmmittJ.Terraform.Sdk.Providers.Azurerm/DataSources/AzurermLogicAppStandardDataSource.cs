using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogicAppStandardDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppStandardDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_logic_app_standard Terraform data source.
/// Retrieves information about a azurerm_logic_app_standard.
/// </summary>
public partial class AzurermLogicAppStandardDataSource(string name) : TerraformDataSource("azurerm_logic_app_standard", name)
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
    /// The bundle_version attribute.
    /// </summary>
    public TerraformValue<string> BundleVersion
        => AsReference("bundle_version");

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientAffinityEnabled
        => AsReference("client_affinity_enabled");

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformValue<string> ClientCertificateMode
        => AsReference("client_certificate_mode");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ConnectionString
        => AsReference("connection_string");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => AsReference("custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
        => AsReference("default_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled
        => AsReference("ftp_publish_basic_authentication_enabled");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
        => AsReference("https_only");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => AsReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => AsReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string> PublicNetworkAccess
        => AsReference("public_network_access");

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ScmPublishBasicAuthenticationEnabled
        => AsReference("scm_publish_basic_authentication_enabled");

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
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountAccessKey
        => AsReference("storage_account_access_key");

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountName
        => AsReference("storage_account_name");

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountShareName
        => AsReference("storage_account_share_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    public TerraformValue<bool> UseExtensionBundle
        => AsReference("use_extension_bundle");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkSubnetId
        => AsReference("virtual_network_subnet_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppStandardDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppStandardDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
