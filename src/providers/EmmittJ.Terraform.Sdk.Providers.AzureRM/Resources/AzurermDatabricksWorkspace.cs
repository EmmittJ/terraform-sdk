using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_parameters in .
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
        get => new TerraformReference<string>(this, "machine_learning_workspace_id");
        set => SetArgument("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    public TerraformValue<string> NatGatewayName
    {
        get => new TerraformReference<string>(this, "nat_gateway_name");
        set => SetArgument("nat_gateway_name", value);
    }

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? NoPublicIp
    {
        get => new TerraformReference<bool>(this, "no_public_ip");
        set => SetArgument("no_public_ip", value);
    }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateSubnetName
    {
        get => new TerraformReference<string>(this, "private_subnet_name");
        set => SetArgument("private_subnet_name", value);
    }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformValue<string>? PrivateSubnetNetworkSecurityGroupAssociationId
    {
        get => new TerraformReference<string>(this, "private_subnet_network_security_group_association_id");
        set => SetArgument("private_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    public TerraformValue<string> PublicIpName
    {
        get => new TerraformReference<string>(this, "public_ip_name");
        set => SetArgument("public_ip_name", value);
    }

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    public TerraformValue<string>? PublicSubnetName
    {
        get => new TerraformReference<string>(this, "public_subnet_name");
        set => SetArgument("public_subnet_name", value);
    }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicSubnetNetworkSecurityGroupAssociationId
    {
        get => new TerraformReference<string>(this, "public_subnet_network_security_group_association_id");
        set => SetArgument("public_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountSkuName
    {
        get => new TerraformReference<string>(this, "storage_account_sku_name");
        set => SetArgument("storage_account_sku_name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    public TerraformValue<string> VnetAddressPrefix
    {
        get => new TerraformReference<string>(this, "vnet_address_prefix");
        set => SetArgument("vnet_address_prefix", value);
    }

}

/// <summary>
/// Block type for enhanced_security_compliance in .
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
        get => new TerraformReference<bool>(this, "automatic_cluster_update_enabled");
        set => SetArgument("automatic_cluster_update_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ComplianceSecurityProfileEnabled
    {
        get => new TerraformReference<bool>(this, "compliance_security_profile_enabled");
        set => SetArgument("compliance_security_profile_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    public TerraformSet<string>? ComplianceSecurityProfileStandards
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "compliance_security_profile_standards").ResolveNodes(ctx));
        set => SetArgument("compliance_security_profile_standards", value);
    }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EnhancedSecurityMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "enhanced_security_monitoring_enabled");
        set => SetArgument("enhanced_security_monitoring_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "access_connector_id");
        set => SetArgument("access_connector_id", value);
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerManagedKeyEnabled
    {
        get => new TerraformReference<bool>(this, "customer_managed_key_enabled");
        set => SetArgument("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultStorageFirewallEnabled
    {
        get => new TerraformReference<bool>(this, "default_storage_firewall_enabled");
        set => SetArgument("default_storage_firewall_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InfrastructureEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "infrastructure_encryption_enabled");
        set => SetArgument("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerBackendAddressPoolId
    {
        get => new TerraformReference<string>(this, "load_balancer_backend_address_pool_id");
        set => SetArgument("load_balancer_backend_address_pool_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskCmkKeyVaultId
    {
        get => new TerraformReference<string>(this, "managed_disk_cmk_key_vault_id");
        set => SetArgument("managed_disk_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedDiskCmkKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "managed_disk_cmk_key_vault_key_id");
        set => SetArgument("managed_disk_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ManagedDiskCmkRotationToLatestVersionEnabled
    {
        get => new TerraformReference<bool>(this, "managed_disk_cmk_rotation_to_latest_version_enabled");
        set => SetArgument("managed_disk_cmk_rotation_to_latest_version_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedResourceGroupName
    {
        get => new TerraformReference<string>(this, "managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedServicesCmkKeyVaultId
    {
        get => new TerraformReference<string>(this, "managed_services_cmk_key_vault_id");
        set => SetArgument("managed_services_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagedServicesCmkKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "managed_services_cmk_key_vault_key_id");
        set => SetArgument("managed_services_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    public TerraformValue<string>? NetworkSecurityGroupRulesRequired
    {
        get => new TerraformReference<string>(this, "network_security_group_rules_required");
        set => SetArgument("network_security_group_rules_required", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// CustomParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    public AzurermDatabricksWorkspaceCustomParametersBlock? CustomParameters
    {
        get => GetArgument<AzurermDatabricksWorkspaceCustomParametersBlock>("custom_parameters");
        set => SetArgument("custom_parameters", value);
    }

    /// <summary>
    /// EnhancedSecurityCompliance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    public AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock? EnhancedSecurityCompliance
    {
        get => GetArgument<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>("enhanced_security_compliance");
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
