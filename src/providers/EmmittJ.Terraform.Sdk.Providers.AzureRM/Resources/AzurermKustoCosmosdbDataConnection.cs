using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoCosmosdbDataConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_cosmosdb_data_connection resource.
/// </summary>
public class AzurermKustoCosmosdbDataConnection : TerraformResource
{
    public AzurermKustoCosmosdbDataConnection(string name) : base("azurerm_kusto_cosmosdb_data_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cosmosdb_container_id");
        SetOutput("id");
        SetOutput("kusto_database_id");
        SetOutput("location");
        SetOutput("managed_identity_id");
        SetOutput("mapping_rule_name");
        SetOutput("name");
        SetOutput("retrieval_start_date");
        SetOutput("table_name");
    }

    /// <summary>
    /// The cosmosdb_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosdbContainerId is required")]
    public required TerraformProperty<string> CosmosdbContainerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmosdb_container_id");
        set => SetProperty("cosmosdb_container_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kusto_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseId is required")]
    public required TerraformProperty<string> KustoDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_database_id");
        set => SetProperty("kusto_database_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityId is required")]
    public required TerraformProperty<string> ManagedIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_identity_id");
        set => SetProperty("managed_identity_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformProperty<string> MappingRuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mapping_rule_name");
        set => SetProperty("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The retrieval_start_date attribute.
    /// </summary>
    public TerraformProperty<string> RetrievalStartDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("retrieval_start_date");
        set => SetProperty("retrieval_start_date", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoCosmosdbDataConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
