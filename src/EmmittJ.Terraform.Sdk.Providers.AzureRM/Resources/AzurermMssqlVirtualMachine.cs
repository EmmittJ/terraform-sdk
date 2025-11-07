using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_virtual_machine resource.
/// </summary>
public class AzurermMssqlVirtualMachine : TerraformResource
{
    public AzurermMssqlVirtualMachine(string name) : base("azurerm_mssql_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The r_services_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RServicesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("r_services_enabled");
        set => this.WithProperty("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SqlConnectivityPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sql_connectivity_port");
        set => this.WithProperty("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlConnectivityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_connectivity_type");
        set => this.WithProperty("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlConnectivityUpdatePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_connectivity_update_password");
        set => this.WithProperty("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlConnectivityUpdateUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_connectivity_update_username");
        set => this.WithProperty("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlLicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_license_type");
        set => this.WithProperty("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlVirtualMachineGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_virtual_machine_group_id");
        set => this.WithProperty("sql_virtual_machine_group_id", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

}
