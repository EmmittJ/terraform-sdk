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
    public string? AvailabilityGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_group_name")?.Value;
        set => this.WithProperty("availability_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public string? SqlVirtualMachineGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_virtual_machine_group_id")?.Value;
        set => this.WithProperty("sql_virtual_machine_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
