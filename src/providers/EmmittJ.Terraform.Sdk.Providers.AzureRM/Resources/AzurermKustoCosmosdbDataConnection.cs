using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_cosmosdb_data_connection resource.
/// </summary>
public class AzurermKustoCosmosdbDataConnection : TerraformResource
{
    public AzurermKustoCosmosdbDataConnection(string name) : base("azurerm_kusto_cosmosdb_data_connection", name)
    {
    }

    /// <summary>
    /// The cosmosdb_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbContainerId is required")]
    [TerraformArgument("cosmosdb_container_id")]
    public required TerraformValue<string> CosmosdbContainerId
    {
        get => new TerraformReference<string>(this, "cosmosdb_container_id");
        set => SetArgument("cosmosdb_container_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kusto_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseId is required")]
    [TerraformArgument("kusto_database_id")]
    public required TerraformValue<string> KustoDatabaseId
    {
        get => new TerraformReference<string>(this, "kusto_database_id");
        set => SetArgument("kusto_database_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityId is required")]
    [TerraformArgument("managed_identity_id")]
    public required TerraformValue<string> ManagedIdentityId
    {
        get => new TerraformReference<string>(this, "managed_identity_id");
        set => SetArgument("managed_identity_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    [TerraformArgument("mapping_rule_name")]
    public TerraformValue<string>? MappingRuleName
    {
        get => new TerraformReference<string>(this, "mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The retrieval_start_date attribute.
    /// </summary>
    [TerraformArgument("retrieval_start_date")]
    public TerraformValue<string>? RetrievalStartDate
    {
        get => new TerraformReference<string>(this, "retrieval_start_date");
        set => SetArgument("retrieval_start_date", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformArgument("table_name")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKustoCosmosdbDataConnectionTimeoutsBlock Timeouts { get; set; } = new();

}
