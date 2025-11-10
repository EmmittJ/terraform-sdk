using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_parameters in .
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceCustomParametersBlock : ITerraformBlock
{
    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("machine_learning_workspace_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MachineLearningWorkspaceId { get; set; }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    [TerraformPropertyName("nat_gateway_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NatGatewayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "nat_gateway_name");

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("no_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoPublicIp { get; set; }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("private_subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateSubnetName { get; set; }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    [TerraformPropertyName("private_subnet_network_security_group_association_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicIpName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "public_ip_name");

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    [TerraformPropertyName("public_subnet_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicSubnetName { get; set; }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    [TerraformPropertyName("public_subnet_network_security_group_association_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageAccountName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "storage_account_name");

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_sku_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageAccountSkuName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "storage_account_sku_name");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualNetworkId { get; set; }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("vnet_address_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VnetAddressPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "vnet_address_prefix");

}

/// <summary>
/// Block type for enhanced_security_compliance in .
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock : ITerraformBlock
{
    /// <summary>
    /// The automatic_cluster_update_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_cluster_update_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticClusterUpdateEnabled { get; set; }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    [TerraformPropertyName("compliance_security_profile_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ComplianceSecurityProfileEnabled { get; set; }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    [TerraformPropertyName("compliance_security_profile_standards")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ComplianceSecurityProfileStandards { get; set; }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_security_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnhancedSecurityMonitoringEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? AccessConnectorId { get; set; }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    [TerraformPropertyName("default_storage_firewall_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultStorageFirewallEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_backend_address_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_cmk_key_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedDiskCmkKeyVaultId { get; set; }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_cmk_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_cmk_rotation_to_latest_version_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedResourceGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_resource_group_name");

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_services_cmk_key_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedServicesCmkKeyVaultId { get; set; }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_services_cmk_key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_rules_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for custom_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    [TerraformPropertyName("custom_parameters")]
    public TerraformList<TerraformBlock<AzurermDatabricksWorkspaceCustomParametersBlock>>? CustomParameters { get; set; } = new();

    /// <summary>
    /// Block for enhanced_security_compliance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    [TerraformPropertyName("enhanced_security_compliance")]
    public TerraformList<TerraformBlock<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>>? EnhancedSecurityCompliance { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspaceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskEncryptionSetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_encryption_set_id");

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagedDiskIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "managed_disk_identity");

    /// <summary>
    /// The managed_resource_group_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagedResourceGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "managed_resource_group_id");

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageAccountIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_account_identity");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_id");

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformPropertyName("workspace_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_url");

}
