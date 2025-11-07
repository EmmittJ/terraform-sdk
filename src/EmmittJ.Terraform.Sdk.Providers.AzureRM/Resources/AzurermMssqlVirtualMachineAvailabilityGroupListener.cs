using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_virtual_machine_availability_group_listener resource.
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListener : TerraformResource
{
    public AzurermMssqlVirtualMachineAvailabilityGroupListener(string name) : base("azurerm_mssql_virtual_machine_availability_group_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The availability_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityGroupName
    {
        get => GetProperty<TerraformProperty<string>>("availability_group_name");
        set => this.WithProperty("availability_group_name", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? SqlVirtualMachineGroupId
    {
        get => GetProperty<TerraformProperty<string>>("sql_virtual_machine_group_id");
        set => this.WithProperty("sql_virtual_machine_group_id", value);
    }

}
