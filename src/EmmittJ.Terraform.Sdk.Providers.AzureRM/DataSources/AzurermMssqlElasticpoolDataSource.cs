using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlElasticpoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_mssql_elasticpool.
/// </summary>
public class AzurermMssqlElasticpoolDataSource : TerraformDataSource
{
    public AzurermMssqlElasticpoolDataSource(string name) : base("azurerm_mssql_elasticpool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("enclave_type");
        this.DeclareOutput("license_type");
        this.DeclareOutput("location");
        this.DeclareOutput("max_size_bytes");
        this.DeclareOutput("max_size_gb");
        this.DeclareOutput("per_db_max_capacity");
        this.DeclareOutput("per_db_min_capacity");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("zone_redundant");
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlElasticpoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlElasticpoolDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformExpression EnclaveType => this["enclave_type"];

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformExpression LicenseType => this["license_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    public TerraformExpression MaxSizeBytes => this["max_size_bytes"];

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformExpression MaxSizeGb => this["max_size_gb"];

    /// <summary>
    /// The per_db_max_capacity attribute.
    /// </summary>
    public TerraformExpression PerDbMaxCapacity => this["per_db_max_capacity"];

    /// <summary>
    /// The per_db_min_capacity attribute.
    /// </summary>
    public TerraformExpression PerDbMinCapacity => this["per_db_min_capacity"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformExpression ZoneRedundant => this["zone_redundant"];

}
