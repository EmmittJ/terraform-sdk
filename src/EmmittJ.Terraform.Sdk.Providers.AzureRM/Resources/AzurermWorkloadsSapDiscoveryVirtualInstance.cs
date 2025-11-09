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
    public TerraformProperty<string>? CentralServerVirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("central_server_virtual_machine_id");
        set => this.WithProperty("central_server_virtual_machine_id", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourcesNetworkAccessType
    {
        get => GetProperty<TerraformProperty<string>>("managed_resources_network_access_type");
        set => this.WithProperty("managed_resources_network_access_type", value);
    }

    /// <summary>
    /// The managed_storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedStorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("managed_storage_account_name");
        set => this.WithProperty("managed_storage_account_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    public TerraformProperty<string>? SapProduct
    {
        get => GetProperty<TerraformProperty<string>>("sap_product");
        set => this.WithProperty("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
