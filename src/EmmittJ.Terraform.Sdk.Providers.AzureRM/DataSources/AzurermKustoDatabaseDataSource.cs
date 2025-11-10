using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoDatabaseDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_kusto_database.
/// </summary>
public class AzurermKustoDatabaseDataSource : TerraformDataSource
{
    public AzurermKustoDatabaseDataSource(string name) : base("azurerm_kusto_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hot_cache_period");
        this.DeclareOutput("location");
        this.DeclareOutput("size");
        this.DeclareOutput("soft_delete_period");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKustoDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The hot_cache_period attribute.
    /// </summary>
    public TerraformExpression HotCachePeriod => this["hot_cache_period"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformExpression Size => this["size"];

    /// <summary>
    /// The soft_delete_period attribute.
    /// </summary>
    public TerraformExpression SoftDeletePeriod => this["soft_delete_period"];

}
