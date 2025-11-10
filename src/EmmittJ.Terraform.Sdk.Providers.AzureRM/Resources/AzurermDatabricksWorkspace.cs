using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_parameters in .
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceCustomParametersBlock : TerraformBlock
{
    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? MachineLearningWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("machine_learning_workspace_id");
        set => WithProperty("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    public TerraformProperty<string>? NatGatewayName
    {
        get => GetProperty<TerraformProperty<string>>("nat_gateway_name");
        set => WithProperty("nat_gateway_name", value);
    }

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    public TerraformProperty<bool>? NoPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("no_public_ip");
        set => WithProperty("no_public_ip", value);
    }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateSubnetName
    {
        get => GetProperty<TerraformProperty<string>>("private_subnet_name");
        set => WithProperty("private_subnet_name", value);
    }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateSubnetNetworkSecurityGroupAssociationId
    {
        get => GetProperty<TerraformProperty<string>>("private_subnet_network_security_group_association_id");
        set => WithProperty("private_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpName
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_name");
        set => WithProperty("public_ip_name", value);
    }

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? PublicSubnetName
    {
        get => GetProperty<TerraformProperty<string>>("public_subnet_name");
        set => WithProperty("public_subnet_name", value);
    }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicSubnetNetworkSecurityGroupAssociationId
    {
        get => GetProperty<TerraformProperty<string>>("public_subnet_network_security_group_association_id");
        set => WithProperty("public_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountSkuName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_sku_name");
        set => WithProperty("storage_account_sku_name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => WithProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? VnetAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("vnet_address_prefix");
        set => WithProperty("vnet_address_prefix", value);
    }

}

/// <summary>
/// Block type for enhanced_security_compliance in .
/// Nesting mode: list
/// </summary>
public class AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock : TerraformBlock
{
    /// <summary>
    /// The automatic_cluster_update_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticClusterUpdateEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_cluster_update_enabled");
        set => WithProperty("automatic_cluster_update_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ComplianceSecurityProfileEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("compliance_security_profile_enabled");
        set => WithProperty("compliance_security_profile_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ComplianceSecurityProfileStandards
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("compliance_security_profile_standards");
        set => WithProperty("compliance_security_profile_standards", value);
    }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EnhancedSecurityMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("enhanced_security_monitoring_enabled");
        set => WithProperty("enhanced_security_monitoring_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_databricks_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDatabricksWorkspace : TerraformResource
{
    public AzurermDatabricksWorkspace(string name) : base("azurerm_databricks_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("disk_encryption_set_id");
        this.DeclareOutput("managed_disk_identity");
        this.DeclareOutput("managed_resource_group_id");
        this.DeclareOutput("storage_account_identity");
        this.DeclareOutput("workspace_id");
        this.DeclareOutput("workspace_url");
    }

    /// <summary>
    /// The access_connector_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccessConnectorId
    {
        get => GetProperty<TerraformProperty<string>>("access_connector_id");
        set => this.WithProperty("access_connector_id", value);
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomerManagedKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => this.WithProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultStorageFirewallEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("default_storage_firewall_enabled");
        set => this.WithProperty("default_storage_firewall_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => this.WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerBackendAddressPoolId
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_backend_address_pool_id");
        set => this.WithProperty("load_balancer_backend_address_pool_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskCmkKeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_cmk_key_vault_id");
        set => this.WithProperty("managed_disk_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDiskCmkKeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_disk_cmk_key_vault_key_id");
        set => this.WithProperty("managed_disk_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ManagedDiskCmkRotationToLatestVersionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("managed_disk_cmk_rotation_to_latest_version_enabled");
        set => this.WithProperty("managed_disk_cmk_rotation_to_latest_version_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedServicesCmkKeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("managed_services_cmk_key_vault_id");
        set => this.WithProperty("managed_services_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedServicesCmkKeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_services_cmk_key_vault_key_id");
        set => this.WithProperty("managed_services_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupRulesRequired
    {
        get => GetProperty<TerraformProperty<string>>("network_security_group_rules_required");
        set => this.WithProperty("network_security_group_rules_required", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for custom_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    public List<AzurermDatabricksWorkspaceCustomParametersBlock>? CustomParameters
    {
        get => GetProperty<List<AzurermDatabricksWorkspaceCustomParametersBlock>>("custom_parameters");
        set => this.WithProperty("custom_parameters", value);
    }

    /// <summary>
    /// Block for enhanced_security_compliance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    public List<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>? EnhancedSecurityCompliance
    {
        get => GetProperty<List<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>>("enhanced_security_compliance");
        set => this.WithProperty("enhanced_security_compliance", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatabricksWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDatabricksWorkspaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformExpression DiskEncryptionSetId => this["disk_encryption_set_id"];

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    public TerraformExpression ManagedDiskIdentity => this["managed_disk_identity"];

    /// <summary>
    /// The managed_resource_group_id attribute.
    /// </summary>
    public TerraformExpression ManagedResourceGroupId => this["managed_resource_group_id"];

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    public TerraformExpression StorageAccountIdentity => this["storage_account_identity"];

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceId => this["workspace_id"];

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    public TerraformExpression WorkspaceUrl => this["workspace_url"];

}
