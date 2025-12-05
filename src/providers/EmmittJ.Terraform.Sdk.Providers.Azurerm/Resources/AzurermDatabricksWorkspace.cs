using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_parameters in AzurermDatabricksWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceCustomParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_parameters";

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? MachineLearningWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("machine_learning_workspace_id");
        set => SetArgument("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    public TerraformValue<string> NatGatewayName
    {
        get => GetArgument<TerraformValue<string>>("nat_gateway_name") ?? CreateReference("nat_gateway_name");
        set => SetArgument("nat_gateway_name", value);
    }

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? NoPublicIp
    {
        get => GetArgument<TerraformValue<bool>>("no_public_ip");
        set => SetArgument("no_public_ip", value);
    }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateSubnetName
    {
        get => GetArgument<TerraformValue<string>>("private_subnet_name");
        set => SetArgument("private_subnet_name", value);
    }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformValue<string>? PrivateSubnetNetworkSecurityGroupAssociationId
    {
        get => GetArgument<TerraformValue<string>>("private_subnet_network_security_group_association_id");
        set => SetArgument("private_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    public TerraformValue<string> PublicIpName
    {
        get => GetArgument<TerraformValue<string>>("public_ip_name") ?? CreateReference("public_ip_name");
        set => SetArgument("public_ip_name", value);
    }

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? PublicSubnetName
    {
        get => GetArgument<TerraformValue<string>>("public_subnet_name");
        set => SetArgument("public_subnet_name", value);
    }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicSubnetNetworkSecurityGroupAssociationId
    {
        get => GetArgument<TerraformValue<string>>("public_subnet_network_security_group_association_id");
        set => SetArgument("public_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name") ?? CreateReference("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountSkuName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_sku_name") ?? CreateReference("storage_account_sku_name");
        set => SetArgument("storage_account_sku_name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    public TerraformValue<string> VnetAddressPrefix
    {
        get => GetArgument<TerraformValue<string>>("vnet_address_prefix") ?? CreateReference("vnet_address_prefix");
        set => SetArgument("vnet_address_prefix", value);
    }

}


/// <summary>
/// Block type for enhanced_security_compliance in AzurermDatabricksWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enhanced_security_compliance";

    /// <summary>
    /// The automatic_cluster_update_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticClusterUpdateEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_cluster_update_enabled");
        set => SetArgument("automatic_cluster_update_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ComplianceSecurityProfileEnabled
    {
        get => GetArgument<TerraformValue<bool>>("compliance_security_profile_enabled");
        set => SetArgument("compliance_security_profile_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    public TerraformSet<string>? ComplianceSecurityProfileStandards
    {
        get => GetArgument<TerraformSet<string>>("compliance_security_profile_standards");
        set => SetArgument("compliance_security_profile_standards", value);
    }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EnhancedSecurityMonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("enhanced_security_monitoring_enabled");
        set => SetArgument("enhanced_security_monitoring_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDatabricksWorkspace.
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_databricks_workspace Terraform resource.
/// Manages a azurerm_databricks_workspace resource.
/// </summary>
public partial class AzurermDatabricksWorkspace(string name) : TerraformResource("azurerm_databricks_workspace", name)
{
    /// <summary>
    /// The access_connector_id attribute.
    /// </summary>
    public TerraformValue<string>? AccessConnectorId
    {
        get => GetArgument<TerraformValue<string>>("access_connector_id");
        set => SetArgument("access_connector_id", value);
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerManagedKeyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("customer_managed_key_enabled");
        set => SetArgument("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultStorageFirewallEnabled
    {
        get => GetArgument<TerraformValue<bool>>("default_storage_firewall_enabled");
        set => SetArgument("default_storage_firewall_enabled", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerBackendAddressPoolId
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_backend_address_pool_id");
        set => SetArgument("load_balancer_backend_address_pool_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskCmkKeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_cmk_key_vault_id");
        set => SetArgument("managed_disk_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskCmkKeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_disk_cmk_key_vault_key_id");
        set => SetArgument("managed_disk_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ManagedDiskCmkRotationToLatestVersionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("managed_disk_cmk_rotation_to_latest_version_enabled");
        set => SetArgument("managed_disk_cmk_rotation_to_latest_version_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("managed_resource_group_name") ?? CreateReference("managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedServicesCmkKeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("managed_services_cmk_key_vault_id");
        set => SetArgument("managed_services_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedServicesCmkKeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_services_cmk_key_vault_key_id");
        set => SetArgument("managed_services_cmk_key_vault_key_id", value);
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
    /// The network_security_group_rules_required attribute.
    /// </summary>
    public TerraformValue<string>? NetworkSecurityGroupRulesRequired
    {
        get => GetArgument<TerraformValue<string>>("network_security_group_rules_required");
        set => SetArgument("network_security_group_rules_required", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformValue<string> DiskEncryptionSetId
        => CreateReference("disk_encryption_set_id");

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedDiskIdentity
        => CreateReference("managed_disk_identity");

    /// <summary>
    /// The managed_resource_group_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedResourceGroupId
        => CreateReference("managed_resource_group_id");

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageAccountIdentity
        => CreateReference("storage_account_identity");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
        => CreateReference("workspace_id");

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceUrl
        => CreateReference("workspace_url");

    /// <summary>
    /// CustomParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    public TerraformList<AzurermDatabricksWorkspaceCustomParametersBlock>? CustomParameters
    {
        get => GetArgument<TerraformList<AzurermDatabricksWorkspaceCustomParametersBlock>>("custom_parameters");
        set => SetArgument("custom_parameters", value);
    }

    /// <summary>
    /// EnhancedSecurityCompliance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    public TerraformList<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>? EnhancedSecurityCompliance
    {
        get => GetArgument<TerraformList<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>>("enhanced_security_compliance");
        set => SetArgument("enhanced_security_compliance", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatabricksWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatabricksWorkspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
