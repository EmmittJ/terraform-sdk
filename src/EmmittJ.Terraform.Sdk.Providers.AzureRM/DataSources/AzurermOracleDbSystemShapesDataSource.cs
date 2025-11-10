using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbSystemShapesDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_oracle_db_system_shapes.
/// </summary>
public class AzurermOracleDbSystemShapesDataSource : TerraformDataSource
{
    public AzurermOracleDbSystemShapesDataSource(string name) : base("azurerm_oracle_db_system_shapes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_system_shapes");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Filter the versions by zone
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleDbSystemShapesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleDbSystemShapesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The db_system_shapes attribute.
    /// </summary>
    public TerraformExpression DbSystemShapes => this["db_system_shapes"];

}
