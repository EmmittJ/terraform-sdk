using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("allocation_policy");
        this.WithOutput("device_provisioning_host_name");
        this.WithOutput("id_scope");
        this.WithOutput("location");
        this.WithOutput("service_operations_host_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubDpsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermIothubDpsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
