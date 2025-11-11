using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_parameters in .
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceCustomParametersBlock
{
    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("machine_learning_workspace_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MachineLearningWorkspaceId { get; set; }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    [TerraformPropertyName("nat_gateway_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NatGatewayName { get; set; } = default!;

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("no_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NoPublicIp { get; set; }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("private_subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateSubnetName { get; set; }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    [TerraformPropertyName("private_subnet_network_security_group_association_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PublicIpName { get; set; } = default!;

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("public_subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicSubnetName { get; set; }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    [TerraformPropertyName("public_subnet_network_security_group_association_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageAccountName { get; set; } = default!;

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_sku_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageAccountSkuName { get; set; } = default!;

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualNetworkId { get; set; }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("vnet_address_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VnetAddressPrefix { get; set; } = default!;

}

/// <summary>
/// Block type for enhanced_security_compliance in .
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock
{
    /// <summary>
    /// The automatic_cluster_update_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_cluster_update_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticClusterUpdateEnabled { get; set; }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    [TerraformPropertyName("compliance_security_profile_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ComplianceSecurityProfileEnabled { get; set; }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    [TerraformPropertyName("compliance_security_profile_standards")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ComplianceSecurityProfileStandards { get; set; }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_security_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnhancedSecurityMonitoringEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_databricks_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDatabricksWorkspace : TerraformResource
{
    public AzurermDatabricksWorkspace(string name) : base("azurerm_databricks_workspace", name)
    {
    }

    /// <summary>
    /// The access_connector_id attribute.
    /// </summary>
    [TerraformPropertyName("access_connector_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessConnectorId { get; set; }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    [TerraformPropertyName("default_storage_firewall_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefaultStorageFirewallEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_backend_address_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_cmk_key_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedDiskCmkKeyVaultId { get; set; }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_cmk_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_cmk_rotation_to_latest_version_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedResourceGroupName { get; set; } = default!;

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_services_cmk_key_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedServicesCmkKeyVaultId { get; set; }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_services_cmk_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_rules_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for custom_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    [TerraformPropertyName("custom_parameters")]
    public TerraformList<TerraformBlock<AzurermDatabricksWorkspaceCustomParametersBlock>>? CustomParameters { get; set; }

    /// <summary>
    /// Block for enhanced_security_compliance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    [TerraformPropertyName("enhanced_security_compliance")]
    public TerraformList<TerraformBlock<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>>? EnhancedSecurityCompliance { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskEncryptionSetId => new TerraformReference(this, "disk_encryption_set_id");

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedDiskIdentity => new TerraformReference(this, "managed_disk_identity");

    /// <summary>
    /// The managed_resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedResourceGroupId => new TerraformReference(this, "managed_resource_group_id");

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StorageAccountIdentity => new TerraformReference(this, "storage_account_identity");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceId => new TerraformReference(this, "workspace_id");

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformPropertyName("workspace_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceUrl => new TerraformReference(this, "workspace_url");

}
