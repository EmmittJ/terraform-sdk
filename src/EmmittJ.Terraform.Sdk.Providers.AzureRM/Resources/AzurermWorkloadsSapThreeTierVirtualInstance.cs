using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_workloads_sap_three_tier_virtual_instance resource.
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstance : TerraformResource
{
    public AzurermWorkloadsSapThreeTierVirtualInstance(string name) : base("azurerm_workloads_sap_three_tier_virtual_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The app_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AppLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_location");
        set => this.WithProperty("app_location", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedResourcesNetworkAccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resources_network_access_type");
        set => this.WithProperty("managed_resources_network_access_type", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sap_fqdn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SapFqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sap_fqdn");
        set => this.WithProperty("sap_fqdn", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SapProduct
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sap_product");
        set => this.WithProperty("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
