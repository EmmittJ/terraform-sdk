using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_sql_trigger resource.
/// </summary>
public class AzurermCosmosdbSqlTrigger : TerraformResource
{
    public AzurermCosmosdbSqlTrigger(string name) : base("azurerm_cosmosdb_sql_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerId
    {
        get => GetProperty<TerraformProperty<string>>("container_id");
        set => this.WithProperty("container_id", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformProperty<string>? Operation
    {
        get => GetProperty<TerraformProperty<string>>("operation");
        set => this.WithProperty("operation", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
