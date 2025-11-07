using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_elasticpool resource.
/// </summary>
public class AzurermMssqlElasticpool : TerraformResource
{
    public AzurermMssqlElasticpool(string name) : base("azurerm_mssql_elasticpool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformProperty<string>? EnclaveType
    {
        get => GetProperty<TerraformProperty<string>>("enclave_type");
        set => this.WithProperty("enclave_type", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
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
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_name");
        set => this.WithProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSizeBytes
    {
        get => GetProperty<TerraformProperty<double>>("max_size_bytes");
        set => this.WithProperty("max_size_bytes", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("max_size_gb");
        set => this.WithProperty("max_size_gb", value);
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
    /// The server_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
    }

}
