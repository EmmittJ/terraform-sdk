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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The r_services_enabled attribute.
    /// </summary>
    public bool? RServicesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("r_services_enabled")?.Value;
        set => this.WithProperty("r_services_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sql_connectivity_port attribute.
    /// </summary>
    public double? SqlConnectivityPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sql_connectivity_port")?.Value;
        set => this.WithProperty("sql_connectivity_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sql_connectivity_type attribute.
    /// </summary>
    public string? SqlConnectivityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_connectivity_type")?.Value;
        set => this.WithProperty("sql_connectivity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_connectivity_update_password attribute.
    /// </summary>
    public string? SqlConnectivityUpdatePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_connectivity_update_password")?.Value;
        set => this.WithProperty("sql_connectivity_update_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_connectivity_update_username attribute.
    /// </summary>
    public string? SqlConnectivityUpdateUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_connectivity_update_username")?.Value;
        set => this.WithProperty("sql_connectivity_update_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_license_type attribute.
    /// </summary>
    public string? SqlLicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_license_type")?.Value;
        set => this.WithProperty("sql_license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    public string? SqlVirtualMachineGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_virtual_machine_group_id")?.Value;
        set => this.WithProperty("sql_virtual_machine_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
