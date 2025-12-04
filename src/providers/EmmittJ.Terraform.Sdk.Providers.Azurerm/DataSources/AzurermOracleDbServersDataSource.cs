using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleDbServersDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbServersDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_oracle_db_servers Terraform data source.
/// Retrieves information about a azurerm_oracle_db_servers.
/// </summary>
public partial class AzurermOracleDbServersDataSource(string name) : TerraformDataSource("azurerm_oracle_db_servers", name)
{
    /// <summary>
    /// The cloud_exadata_infrastructure_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureName is required")]
    public required TerraformValue<string> CloudExadataInfrastructureName
    {
        get => GetArgument<TerraformValue<string>>("cloud_exadata_infrastructure_name");
        set => SetArgument("cloud_exadata_infrastructure_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbServers
        => AsReference("db_servers");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleDbServersDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleDbServersDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
