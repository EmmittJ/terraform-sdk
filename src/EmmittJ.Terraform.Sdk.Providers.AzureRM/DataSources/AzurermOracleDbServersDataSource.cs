using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbServersDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_oracle_db_servers.
/// </summary>
public class AzurermOracleDbServersDataSource : TerraformDataSource
{
    public AzurermOracleDbServersDataSource(string name) : base("azurerm_oracle_db_servers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_servers");
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureName is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureName
    {
        get => GetProperty<TerraformProperty<string>>("cloud_exadata_infrastructure_name");
        set => this.WithProperty("cloud_exadata_infrastructure_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleDbServersDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleDbServersDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

}
