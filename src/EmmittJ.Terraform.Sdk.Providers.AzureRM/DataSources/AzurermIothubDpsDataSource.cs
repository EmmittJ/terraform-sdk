using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_iothub_dps.
/// </summary>
public class AzurermIothubDpsDataSource : TerraformDataSource
{
    public AzurermIothubDpsDataSource(string name) : base("azurerm_iothub_dps", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocation_policy");
        this.DeclareOutput("device_provisioning_host_name");
        this.DeclareOutput("id_scope");
        this.DeclareOutput("location");
        this.DeclareOutput("service_operations_host_name");
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    public TerraformExpression AllocationPolicy => this["allocation_policy"];

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    public TerraformExpression DeviceProvisioningHostName => this["device_provisioning_host_name"];

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    public TerraformExpression IdScope => this["id_scope"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    public TerraformExpression ServiceOperationsHostName => this["service_operations_host_name"];

}
