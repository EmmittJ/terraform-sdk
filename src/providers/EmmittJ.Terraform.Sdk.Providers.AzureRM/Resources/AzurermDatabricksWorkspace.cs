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
        set => SetProperty("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The nat_gateway_name attribute.
    /// </summary>
    public TerraformProperty<string>? NatGatewayName
    {
        set => SetProperty("nat_gateway_name", value);
    }

    /// <summary>
    /// The no_public_ip attribute.
    /// </summary>
    public TerraformProperty<bool>? NoPublicIp
    {
        set => SetProperty("no_public_ip", value);
    }

    /// <summary>
    /// The private_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateSubnetName
    {
        set => SetProperty("private_subnet_name", value);
    }

    /// <summary>
    /// The private_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateSubnetNetworkSecurityGroupAssociationId
    {
        set => SetProperty("private_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The public_ip_name attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpName
    {
        set => SetProperty("public_ip_name", value);
    }

    /// <summary>
    /// The public_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? PublicSubnetName
    {
        set => SetProperty("public_subnet_name", value);
    }

    /// <summary>
    /// The public_subnet_network_security_group_association_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicSubnetNetworkSecurityGroupAssociationId
    {
        set => SetProperty("public_subnet_network_security_group_association_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        set => SetProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_account_sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountSkuName
    {
        set => SetProperty("storage_account_sku_name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The vnet_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? VnetAddressPrefix
    {
        set => SetProperty("vnet_address_prefix", value);
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
        set => SetProperty("automatic_cluster_update_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ComplianceSecurityProfileEnabled
    {
        set => SetProperty("compliance_security_profile_enabled", value);
    }

    /// <summary>
    /// The compliance_security_profile_standards attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ComplianceSecurityProfileStandards
    {
        set => SetProperty("compliance_security_profile_standards", value);
    }

    /// <summary>
    /// The enhanced_security_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EnhancedSecurityMonitoringEnabled
    {
        set => SetProperty("enhanced_security_monitoring_enabled", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("disk_encryption_set_id");
        SetOutput("managed_disk_identity");
        SetOutput("managed_resource_group_id");
        SetOutput("storage_account_identity");
        SetOutput("workspace_id");
        SetOutput("workspace_url");
        SetOutput("access_connector_id");
        SetOutput("customer_managed_key_enabled");
        SetOutput("default_storage_firewall_enabled");
        SetOutput("id");
        SetOutput("infrastructure_encryption_enabled");
        SetOutput("load_balancer_backend_address_pool_id");
        SetOutput("location");
        SetOutput("managed_disk_cmk_key_vault_id");
        SetOutput("managed_disk_cmk_key_vault_key_id");
        SetOutput("managed_disk_cmk_rotation_to_latest_version_enabled");
        SetOutput("managed_resource_group_name");
        SetOutput("managed_services_cmk_key_vault_id");
        SetOutput("managed_services_cmk_key_vault_key_id");
        SetOutput("name");
        SetOutput("network_security_group_rules_required");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The access_connector_id attribute.
    /// </summary>
    public TerraformProperty<string> AccessConnectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_connector_id");
        set => SetProperty("access_connector_id", value);
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CustomerManagedKeyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => SetProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultStorageFirewallEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_storage_firewall_enabled");
        set => SetProperty("default_storage_firewall_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InfrastructureEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => SetProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancerBackendAddressPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_backend_address_pool_id");
        set => SetProperty("load_balancer_backend_address_pool_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedDiskCmkKeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_disk_cmk_key_vault_id");
        set => SetProperty("managed_disk_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedDiskCmkKeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_disk_cmk_key_vault_key_id");
        set => SetProperty("managed_disk_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ManagedDiskCmkRotationToLatestVersionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("managed_disk_cmk_rotation_to_latest_version_enabled");
        set => SetProperty("managed_disk_cmk_rotation_to_latest_version_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ManagedResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_resource_group_name");
        set => SetProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedServicesCmkKeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_services_cmk_key_vault_id");
        set => SetProperty("managed_services_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedServicesCmkKeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_services_cmk_key_vault_key_id");
        set => SetProperty("managed_services_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    public TerraformProperty<string> NetworkSecurityGroupRulesRequired
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_security_group_rules_required");
        set => SetProperty("network_security_group_rules_required", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for custom_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomParameters block(s) allowed")]
    public List<AzurermDatabricksWorkspaceCustomParametersBlock>? CustomParameters
    {
        set => SetProperty("custom_parameters", value);
    }

    /// <summary>
    /// Block for enhanced_security_compliance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnhancedSecurityCompliance block(s) allowed")]
    public List<AzurermDatabricksWorkspaceEnhancedSecurityComplianceBlock>? EnhancedSecurityCompliance
    {
        set => SetProperty("enhanced_security_compliance", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatabricksWorkspaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
