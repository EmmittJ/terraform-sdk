using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKustoCosmosdbDataConnection.
/// Nesting mode: single
/// </summary>
public class AzurermKustoCosmosdbDataConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_kusto_cosmosdb_data_connection Terraform resource.
/// Manages a azurerm_kusto_cosmosdb_data_connection resource.
/// </summary>
public partial class AzurermKustoCosmosdbDataConnection(string name) : TerraformResource("azurerm_kusto_cosmosdb_data_connection", name)
{
    /// <summary>
    /// The cosmosdb_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbContainerId is required")]
    public required TerraformValue<string> CosmosdbContainerId
    {
        get => GetArgument<TerraformValue<string>>("cosmosdb_container_id");
        set => SetArgument("cosmosdb_container_id", value);
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
    /// The kusto_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseId is required")]
    public required TerraformValue<string> KustoDatabaseId
    {
        get => GetArgument<TerraformValue<string>>("kusto_database_id");
        set => SetArgument("kusto_database_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityId is required")]
    public required TerraformValue<string> ManagedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("managed_identity_id");
        set => SetArgument("managed_identity_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformValue<string>? MappingRuleName
    {
        get => GetArgument<TerraformValue<string>>("mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The retrieval_start_date attribute.
    /// </summary>
    public TerraformValue<string>? RetrievalStartDate
    {
        get => GetArgument<TerraformValue<string>>("retrieval_start_date");
        set => SetArgument("retrieval_start_date", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoCosmosdbDataConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoCosmosdbDataConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
