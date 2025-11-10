using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_link_access in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointResourceId is required")]
    public required TerraformProperty<string> EndpointResourceId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_resource_id");
        set => WithProperty("endpoint_resource_id", value);
    }

    /// <summary>
    /// The endpoint_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointTenantId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_tenant_id");
        set => WithProperty("endpoint_tenant_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountNetworkRulesTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_account_network_rules resource.
/// </summary>
public class AzurermStorageAccountNetworkRules : TerraformResource
{
    public AzurermStorageAccountNetworkRules(string name) : base("azurerm_storage_account_network_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Bypass
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("bypass");
        set => this.WithProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => this.WithProperty("default_action", value);
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
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpRules
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_rules");
        set => this.WithProperty("ip_rules", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VirtualNetworkSubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("virtual_network_subnet_ids");
        set => this.WithProperty("virtual_network_subnet_ids", value);
    }

    /// <summary>
    /// Block for private_link_access.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock>? PrivateLinkAccess
    {
        get => GetProperty<List<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock>>("private_link_access");
        set => this.WithProperty("private_link_access", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountNetworkRulesTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageAccountNetworkRulesTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
