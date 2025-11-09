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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RServicesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("r_services_enabled");
        set => this.WithProperty("r_services_enabled", value);
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public TerraformProperty<double>? SqlConnectivityPort
    {
        get => GetProperty<TerraformProperty<double>>("sql_connectivity_port");
        set => this.WithProperty("sql_connectivity_port", value);
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public TerraformProperty<string>? SqlConnectivityType
    {
        get => GetProperty<TerraformProperty<string>>("sql_connectivity_type");
        set => this.WithProperty("sql_connectivity_type", value);
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public TerraformProperty<string>? SqlConnectivityUpdatePassword
    {
        get => GetProperty<TerraformProperty<string>>("sql_connectivity_update_password");
        set => this.WithProperty("sql_connectivity_update_password", value);
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public TerraformProperty<string>? SqlConnectivityUpdateUsername
    {
        get => GetProperty<TerraformProperty<string>>("sql_connectivity_update_username");
        set => this.WithProperty("sql_connectivity_update_username", value);
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public TerraformProperty<string>? SqlLicenseType
    {
        get => GetProperty<TerraformProperty<string>>("sql_license_type");
        set => this.WithProperty("sql_license_type", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? SqlVirtualMachineGroupId
    {
        get => GetProperty<TerraformProperty<string>>("sql_virtual_machine_group_id");
        set => this.WithProperty("sql_virtual_machine_group_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

}
