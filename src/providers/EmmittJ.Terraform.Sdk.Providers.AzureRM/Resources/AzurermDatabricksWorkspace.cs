using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatabricksWorkspaceCustomParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [TerraformProperty("machine_learning_workspace_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MachineLearningWorkspaceId { get; set; }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    [TerraformProperty("nat_gateway_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NatGatewayName { get; set; }

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    [TerraformProperty("no_public_ip")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NoPublicIp { get; set; }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    [TerraformProperty("private_subnet_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateSubnetName { get; set; }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    [TerraformProperty("private_subnet_network_security_group_association_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    [TerraformProperty("public_ip_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PublicIpName { get; set; }

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    [TerraformProperty("public_subnet_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicSubnetName { get; set; }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    [TerraformProperty("public_subnet_network_security_group_association_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformProperty("storage_account_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageAccountName { get; set; }

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    [TerraformProperty("storage_account_sku_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageAccountSkuName { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualNetworkId { get; set; }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    [TerraformProperty("vnet_address_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VnetAddressPrefix { get; set; }

}

/// <summary>
/// Block type for enhanced_security_compliance in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock : TerraformBlockBase
{
    /// <summary>
    /// The automatic_cluster_update_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_cluster_update_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticClusterUpdateEnabled { get; set; }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    [TerraformProperty("compliance_security_profile_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ComplianceSecurityProfileEnabled { get; set; }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    [TerraformProperty("compliance_security_profile_standards")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ComplianceSecurityProfileStandards { get; set; }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("enhanced_security_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnhancedSecurityMonitoringEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatabricksWorkspaceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_databricks_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDatabricksWorkspace : TerraformResource
{
    public AzurermDatabricksWorkspace(string name) : base("azurerm_databricks_workspace", name)
    {
    }

    /// <summary>
    /// The access_connector_id attribute.
    /// </summary>
    [TerraformProperty("access_connector_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccessConnectorId { get; set; }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    [TerraformProperty("default_storage_firewall_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DefaultStorageFirewallEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("infrastructure_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    [TerraformProperty("load_balancer_backend_address_pool_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    [TerraformProperty("managed_disk_cmk_key_vault_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedDiskCmkKeyVaultId { get; set; }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_disk_cmk_key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    [TerraformProperty("managed_disk_cmk_rotation_to_latest_version_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    [TerraformProperty("managed_services_cmk_key_vault_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedServicesCmkKeyVaultId { get; set; }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_services_cmk_key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    [TerraformProperty("network_security_group_rules_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for custom_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    [TerraformProperty("custom_parameters")]
    public TerraformList<TerraformBlock<AzurermDatabricksWorkspaceCustomParametersBlock>>? CustomParameters { get; set; }

    /// <summary>
    /// Block for enhanced_security_compliance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    [TerraformProperty("enhanced_security_compliance")]
    public TerraformList<TerraformBlock<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>>? EnhancedSecurityCompliance { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DiskEncryptionSetId { get; }

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformProperty("managed_disk_identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedDiskIdentity { get; }

    /// <summary>
    /// The managed_resource_group_id attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ManagedResourceGroupId { get; }

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformProperty("storage_account_identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StorageAccountIdentity { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkspaceId { get; }

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformProperty("workspace_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkspaceUrl { get; }

}
