using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_workloads_sap_discovery_virtual_instance resource.
/// </summary>
public class AzurermWorkloadsSapDiscoveryVirtualInstance : TerraformResource
{
    public AzurermWorkloadsSapDiscoveryVirtualInstance(string name) : base("azurerm_workloads_sap_discovery_virtual_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The central_server_virtual_machine_id attribute.
    /// </summary>
    public string? CentralServerVirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("central_server_virtual_machine_id")?.Value;
        set => this.WithProperty("central_server_virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public string? ManagedResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resource_group_name")?.Value;
        set => this.WithProperty("managed_resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public string? ManagedResourcesNetworkAccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resources_network_access_type")?.Value;
        set => this.WithProperty("managed_resources_network_access_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_storage_account_name attribute.
    /// </summary>
    public string? ManagedStorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_storage_account_name")?.Value;
        set => this.WithProperty("managed_storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    public string? SapProduct
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sap_product")?.Value;
        set => this.WithProperty("sap_product", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
