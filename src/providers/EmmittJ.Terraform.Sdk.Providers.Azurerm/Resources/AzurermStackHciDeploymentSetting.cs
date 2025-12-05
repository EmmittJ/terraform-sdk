using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for scale_unit in AzurermStackHciDeploymentSetting.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_unit";

    /// <summary>
    /// The active_directory_organizational_unit_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActiveDirectoryOrganizationalUnitPath is required")]
    public required TerraformValue<string> ActiveDirectoryOrganizationalUnitPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("active_directory_organizational_unit_path");
        set => SetArgument("active_directory_organizational_unit_path", value);
    }

    /// <summary>
    /// The bitlocker_boot_volume_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BitlockerBootVolumeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("bitlocker_boot_volume_enabled");
        set => SetArgument("bitlocker_boot_volume_enabled", value);
    }

    /// <summary>
    /// The bitlocker_data_volume_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BitlockerDataVolumeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("bitlocker_data_volume_enabled");
        set => SetArgument("bitlocker_data_volume_enabled", value);
    }

    /// <summary>
    /// The credential_guard_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CredentialGuardEnabled
    {
        get => GetArgument<TerraformValue<bool>>("credential_guard_enabled");
        set => SetArgument("credential_guard_enabled", value);
    }

    /// <summary>
    /// The domain_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainFqdn is required")]
    public required TerraformValue<string> DomainFqdn
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_fqdn");
        set => SetArgument("domain_fqdn", value);
    }

    /// <summary>
    /// The drift_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DriftControlEnabled
    {
        get => GetArgument<TerraformValue<bool>>("drift_control_enabled");
        set => SetArgument("drift_control_enabled", value);
    }

    /// <summary>
    /// The drtm_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DrtmProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("drtm_protection_enabled");
        set => SetArgument("drtm_protection_enabled", value);
    }

    /// <summary>
    /// The episodic_data_upload_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EpisodicDataUploadEnabled
    {
        get => GetArgument<TerraformValue<bool>>("episodic_data_upload_enabled");
        set => SetArgument("episodic_data_upload_enabled", value);
    }

    /// <summary>
    /// The eu_location_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EuLocationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("eu_location_enabled");
        set => SetArgument("eu_location_enabled", value);
    }

    /// <summary>
    /// The hvci_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HvciProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("hvci_protection_enabled");
        set => SetArgument("hvci_protection_enabled", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    public required TerraformValue<string> NamePrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The secrets_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretsLocation is required")]
    public required TerraformValue<string> SecretsLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("secrets_location");
        set => SetArgument("secrets_location", value);
    }

    /// <summary>
    /// The side_channel_mitigation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SideChannelMitigationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("side_channel_mitigation_enabled");
        set => SetArgument("side_channel_mitigation_enabled", value);
    }

    /// <summary>
    /// The smb_cluster_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SmbClusterEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smb_cluster_encryption_enabled");
        set => SetArgument("smb_cluster_encryption_enabled", value);
    }

    /// <summary>
    /// The smb_signing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SmbSigningEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smb_signing_enabled");
        set => SetArgument("smb_signing_enabled", value);
    }

    /// <summary>
    /// The streaming_data_client_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StreamingDataClientEnabled
    {
        get => GetArgument<TerraformValue<bool>>("streaming_data_client_enabled");
        set => SetArgument("streaming_data_client_enabled", value);
    }

    /// <summary>
    /// The wdac_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WdacEnabled
    {
        get => GetArgument<TerraformValue<bool>>("wdac_enabled");
        set => SetArgument("wdac_enabled", value);
    }

    /// <summary>
    /// Cluster block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Cluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cluster block(s) allowed")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockClusterBlock> Cluster
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockClusterBlock>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// HostNetwork block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HostNetwork block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostNetwork block(s) allowed")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlock> HostNetwork
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlock>>("host_network");
        set => SetArgument("host_network", value);
    }

    /// <summary>
    /// InfrastructureNetwork block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfrastructureNetwork block(s) required")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlock> InfrastructureNetwork
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlock>>("infrastructure_network");
        set => SetArgument("infrastructure_network", value);
    }

    /// <summary>
    /// OptionalService block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptionalService is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OptionalService block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptionalService block(s) allowed")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockOptionalServiceBlock> OptionalService
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockOptionalServiceBlock>>("optional_service");
        set => SetArgument("optional_service", value);
    }

    /// <summary>
    /// PhysicalNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhysicalNode block(s) required")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockPhysicalNodeBlock> PhysicalNode
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockPhysicalNodeBlock>>("physical_node");
        set => SetArgument("physical_node", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Storage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Storage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockStorageBlock> Storage
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

}

/// <summary>
/// Block type for cluster in AzurermStackHciDeploymentSettingScaleUnitBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster";

    /// <summary>
    /// The azure_service_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureServiceEndpoint is required")]
    public required TerraformValue<string> AzureServiceEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("azure_service_endpoint");
        set => SetArgument("azure_service_endpoint", value);
    }

    /// <summary>
    /// The cloud_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudAccountName is required")]
    public required TerraformValue<string> CloudAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_account_name");
        set => SetArgument("cloud_account_name", value);
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
    /// The witness_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WitnessPath is required")]
    public required TerraformValue<string> WitnessPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("witness_path");
        set => SetArgument("witness_path", value);
    }

    /// <summary>
    /// The witness_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WitnessType is required")]
    public required TerraformValue<string> WitnessType
    {
        get => GetRequiredArgument<TerraformValue<string>>("witness_type");
        set => SetArgument("witness_type", value);
    }

}

/// <summary>
/// Block type for host_network in AzurermStackHciDeploymentSettingScaleUnitBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_network";

    /// <summary>
    /// The storage_auto_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StorageAutoIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("storage_auto_ip_enabled");
        set => SetArgument("storage_auto_ip_enabled", value);
    }

    /// <summary>
    /// The storage_connectivity_switchless_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StorageConnectivitySwitchlessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("storage_connectivity_switchless_enabled");
        set => SetArgument("storage_connectivity_switchless_enabled", value);
    }

    /// <summary>
    /// Intent block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlock> Intent
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlock>>("intent");
        set => SetArgument("intent", value);
    }

    /// <summary>
    /// StorageNetwork block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageNetwork is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageNetwork block(s) required")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockStorageNetworkBlock> StorageNetwork
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockStorageNetworkBlock>>("storage_network");
        set => SetArgument("storage_network", value);
    }

}

/// <summary>
/// Block type for intent in AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intent";

    /// <summary>
    /// The adapter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Adapter is required")]
    public TerraformList<string>? Adapter
    {
        get => GetArgument<TerraformList<string>>("adapter");
        set => SetArgument("adapter", value);
    }

    /// <summary>
    /// The adapter_property_override_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AdapterPropertyOverrideEnabled
    {
        get => GetArgument<TerraformValue<bool>>("adapter_property_override_enabled");
        set => SetArgument("adapter_property_override_enabled", value);
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
    /// The qos_policy_override_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? QosPolicyOverrideEnabled
    {
        get => GetArgument<TerraformValue<bool>>("qos_policy_override_enabled");
        set => SetArgument("qos_policy_override_enabled", value);
    }

    /// <summary>
    /// The traffic_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficType is required")]
    public TerraformList<string>? TrafficType
    {
        get => GetArgument<TerraformList<string>>("traffic_type");
        set => SetArgument("traffic_type", value);
    }

    /// <summary>
    /// The virtual_switch_configuration_override_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualSwitchConfigurationOverrideEnabled
    {
        get => GetArgument<TerraformValue<bool>>("virtual_switch_configuration_override_enabled");
        set => SetArgument("virtual_switch_configuration_override_enabled", value);
    }

    /// <summary>
    /// AdapterPropertyOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdapterPropertyOverride block(s) allowed")]
    public TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockAdapterPropertyOverrideBlock>? AdapterPropertyOverride
    {
        get => GetArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockAdapterPropertyOverrideBlock>>("adapter_property_override");
        set => SetArgument("adapter_property_override", value);
    }

    /// <summary>
    /// QosPolicyOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QosPolicyOverride block(s) allowed")]
    public TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockQosPolicyOverrideBlock>? QosPolicyOverride
    {
        get => GetArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockQosPolicyOverrideBlock>>("qos_policy_override");
        set => SetArgument("qos_policy_override", value);
    }

    /// <summary>
    /// VirtualSwitchConfigurationOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualSwitchConfigurationOverride block(s) allowed")]
    public TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockVirtualSwitchConfigurationOverrideBlock>? VirtualSwitchConfigurationOverride
    {
        get => GetArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockVirtualSwitchConfigurationOverrideBlock>>("virtual_switch_configuration_override");
        set => SetArgument("virtual_switch_configuration_override", value);
    }

}

/// <summary>
/// Block type for adapter_property_override in AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockAdapterPropertyOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "adapter_property_override";

    /// <summary>
    /// The jumbo_packet attribute.
    /// </summary>
    public TerraformValue<string>? JumboPacket
    {
        get => GetArgument<TerraformValue<string>>("jumbo_packet");
        set => SetArgument("jumbo_packet", value);
    }

    /// <summary>
    /// The network_direct attribute.
    /// </summary>
    public TerraformValue<string>? NetworkDirect
    {
        get => GetArgument<TerraformValue<string>>("network_direct");
        set => SetArgument("network_direct", value);
    }

    /// <summary>
    /// The network_direct_technology attribute.
    /// </summary>
    public TerraformValue<string>? NetworkDirectTechnology
    {
        get => GetArgument<TerraformValue<string>>("network_direct_technology");
        set => SetArgument("network_direct_technology", value);
    }

}

/// <summary>
/// Block type for qos_policy_override in AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockQosPolicyOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "qos_policy_override";

    /// <summary>
    /// The bandwidth_percentage_smb attribute.
    /// </summary>
    public TerraformValue<string>? BandwidthPercentageSmb
    {
        get => GetArgument<TerraformValue<string>>("bandwidth_percentage_smb");
        set => SetArgument("bandwidth_percentage_smb", value);
    }

    /// <summary>
    /// The priority_value8021_action_cluster attribute.
    /// </summary>
    public TerraformValue<string>? PriorityValue8021ActionCluster
    {
        get => GetArgument<TerraformValue<string>>("priority_value8021_action_cluster");
        set => SetArgument("priority_value8021_action_cluster", value);
    }

    /// <summary>
    /// The priority_value8021_action_smb attribute.
    /// </summary>
    public TerraformValue<string>? PriorityValue8021ActionSmb
    {
        get => GetArgument<TerraformValue<string>>("priority_value8021_action_smb");
        set => SetArgument("priority_value8021_action_smb", value);
    }

}

/// <summary>
/// Block type for virtual_switch_configuration_override in AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockIntentBlockVirtualSwitchConfigurationOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_switch_configuration_override";

    /// <summary>
    /// The enable_iov attribute.
    /// </summary>
    public TerraformValue<string>? EnableIov
    {
        get => GetArgument<TerraformValue<string>>("enable_iov");
        set => SetArgument("enable_iov", value);
    }

    /// <summary>
    /// The load_balancing_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancingAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_algorithm");
        set => SetArgument("load_balancing_algorithm", value);
    }

}

/// <summary>
/// Block type for storage_network in AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockHostNetworkBlockStorageNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_network";

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
    /// The network_adapter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAdapterName is required")]
    public required TerraformValue<string> NetworkAdapterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_adapter_name");
        set => SetArgument("network_adapter_name", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    public required TerraformValue<string> VlanId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vlan_id");
        set => SetArgument("vlan_id", value);
    }

}

/// <summary>
/// Block type for infrastructure_network in AzurermStackHciDeploymentSettingScaleUnitBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infrastructure_network";

    /// <summary>
    /// The dhcp_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DhcpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dhcp_enabled");
        set => SetArgument("dhcp_enabled", value);
    }

    /// <summary>
    /// The dns_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsServer is required")]
    public TerraformList<string>? DnsServer
    {
        get => GetArgument<TerraformList<string>>("dns_server");
        set => SetArgument("dns_server", value);
    }

    /// <summary>
    /// The gateway attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    public required TerraformValue<string> Gateway
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// The subnet_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetMask is required")]
    public required TerraformValue<string> SubnetMask
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_mask");
        set => SetArgument("subnet_mask", value);
    }

    /// <summary>
    /// IpPool block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpPool block(s) required")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlockIpPoolBlock> IpPool
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlockIpPoolBlock>>("ip_pool");
        set => SetArgument("ip_pool", value);
    }

}

/// <summary>
/// Block type for ip_pool in AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockInfrastructureNetworkBlockIpPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_pool";

    /// <summary>
    /// The ending_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndingAddress is required")]
    public required TerraformValue<string> EndingAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ending_address");
        set => SetArgument("ending_address", value);
    }

    /// <summary>
    /// The starting_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartingAddress is required")]
    public required TerraformValue<string> StartingAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("starting_address");
        set => SetArgument("starting_address", value);
    }

}

/// <summary>
/// Block type for optional_service in AzurermStackHciDeploymentSettingScaleUnitBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockOptionalServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "optional_service";

    /// <summary>
    /// The custom_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocation is required")]
    public required TerraformValue<string> CustomLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_location");
        set => SetArgument("custom_location", value);
    }

}

/// <summary>
/// Block type for physical_node in AzurermStackHciDeploymentSettingScaleUnitBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockPhysicalNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "physical_node";

    /// <summary>
    /// The ipv4_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4Address is required")]
    public required TerraformValue<string> Ipv4Address
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipv4_address");
        set => SetArgument("ipv4_address", value);
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

}

/// <summary>
/// Block type for storage in AzurermStackHciDeploymentSettingScaleUnitBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStackHciDeploymentSettingScaleUnitBlockStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// The configuration_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationMode is required")]
    public required TerraformValue<string> ConfigurationMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_mode");
        set => SetArgument("configuration_mode", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStackHciDeploymentSetting.
/// Nesting mode: single
/// </summary>
public class AzurermStackHciDeploymentSettingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_stack_hci_deployment_setting Terraform resource.
/// Manages a azurerm_stack_hci_deployment_setting resource.
/// </summary>
public partial class AzurermStackHciDeploymentSetting(string name) : TerraformResource("azurerm_stack_hci_deployment_setting", name)
{
    /// <summary>
    /// The arc_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcResourceIds is required")]
    public TerraformList<string>? ArcResourceIds
    {
        get => GetArgument<TerraformList<string>>("arc_resource_ids");
        set => SetArgument("arc_resource_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackHciClusterId is required")]
    public required TerraformValue<string> StackHciClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("stack_hci_cluster_id");
        set => SetArgument("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// ScaleUnit block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleUnit block(s) required")]
    public required TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlock> ScaleUnit
    {
        get => GetRequiredArgument<TerraformList<AzurermStackHciDeploymentSettingScaleUnitBlock>>("scale_unit");
        set => SetArgument("scale_unit", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStackHciDeploymentSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStackHciDeploymentSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
