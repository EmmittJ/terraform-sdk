using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_databricks_workspace resource.
/// </summary>
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
    public TerraformLiteralProperty<string>? AccessConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_connector_id");
        set => this.WithProperty("access_connector_id", value);
    }

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CustomerManagedKeyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("customer_managed_key_enabled");
        set => this.WithProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The default_storage_firewall_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DefaultStorageFirewallEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_storage_firewall_enabled");
        set => this.WithProperty("default_storage_firewall_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("infrastructure_encryption_enabled");
        set => this.WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The load_balancer_backend_address_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancerBackendAddressPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_backend_address_pool_id");
        set => this.WithProperty("load_balancer_backend_address_pool_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedDiskCmkKeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_cmk_key_vault_id");
        set => this.WithProperty("managed_disk_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedDiskCmkKeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_disk_cmk_key_vault_key_id");
        set => this.WithProperty("managed_disk_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_disk_cmk_rotation_to_latest_version_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ManagedDiskCmkRotationToLatestVersionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed_disk_cmk_rotation_to_latest_version_enabled");
        set => this.WithProperty("managed_disk_cmk_rotation_to_latest_version_enabled", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedServicesCmkKeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_services_cmk_key_vault_id");
        set => this.WithProperty("managed_services_cmk_key_vault_id", value);
    }

    /// <summary>
    /// The managed_services_cmk_key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedServicesCmkKeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_services_cmk_key_vault_key_id");
        set => this.WithProperty("managed_services_cmk_key_vault_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_rules_required attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkSecurityGroupRulesRequired
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_security_group_rules_required");
        set => this.WithProperty("network_security_group_rules_required", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
