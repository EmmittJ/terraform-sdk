using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_postgresql_flexible_server.
/// </summary>
public class AzurermPostgresqlFlexibleServerDataSource : TerraformDataSource
{
    public AzurermPostgresqlFlexibleServerDataSource(string name) : base("azurerm_postgresql_flexible_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("administrator_login");
        SetOutput("auto_grow_enabled");
        SetOutput("backup_retention_days");
        SetOutput("delegated_subnet_id");
        SetOutput("fqdn");
        SetOutput("location");
        SetOutput("public_network_access_enabled");
        SetOutput("sku_name");
        SetOutput("storage_mb");
        SetOutput("tags");
        SetOutput("version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPostgresqlFlexibleServerDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformExpression AdministratorLogin => this["administrator_login"];

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformExpression AutoGrowEnabled => this["auto_grow_enabled"];

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformExpression BackupRetentionDays => this["backup_retention_days"];

    /// <summary>
    /// The delegated_subnet_id attribute.
    /// </summary>
    public TerraformExpression DelegatedSubnetId => this["delegated_subnet_id"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public TerraformExpression StorageMb => this["storage_mb"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
