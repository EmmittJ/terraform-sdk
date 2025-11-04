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
    public string? EnclaveType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enclave_type")?.Value;
        set => this.WithProperty("enclave_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public string? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_name")?.Value;
        set => this.WithProperty("maintenance_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    public double? MaxSizeBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size_bytes")?.Value;
        set => this.WithProperty("max_size_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public double? MaxSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size_gb")?.Value;
        set => this.WithProperty("max_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public string? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name")?.Value;
        set => this.WithProperty("server_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The zone_redundant attribute.
    /// </summary>
    public bool? ZoneRedundant
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant")?.Value;
        set => this.WithProperty("zone_redundant", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
