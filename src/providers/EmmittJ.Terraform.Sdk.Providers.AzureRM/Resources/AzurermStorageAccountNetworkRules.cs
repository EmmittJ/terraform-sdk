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
        set => SetProperty("endpoint_resource_id", value);
    }

    /// <summary>
    /// The endpoint_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointTenantId
    {
        set => SetProperty("endpoint_tenant_id", value);
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
        SetOutput("bypass");
        SetOutput("default_action");
        SetOutput("id");
        SetOutput("ip_rules");
        SetOutput("storage_account_id");
        SetOutput("virtual_network_subnet_ids");
    }

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Bypass
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("bypass");
        set => SetProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_action");
        set => SetProperty("default_action", value);
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
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IpRules
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ip_rules");
        set => SetProperty("ip_rules", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VirtualNetworkSubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("virtual_network_subnet_ids");
        set => SetProperty("virtual_network_subnet_ids", value);
    }

    /// <summary>
    /// Block for private_link_access.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock>? PrivateLinkAccess
    {
        set => SetProperty("private_link_access", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountNetworkRulesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
