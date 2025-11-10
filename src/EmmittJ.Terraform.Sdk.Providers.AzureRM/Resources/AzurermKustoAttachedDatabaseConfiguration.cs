using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sharing in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoAttachedDatabaseConfigurationSharingBlock : TerraformBlock
{
    /// <summary>
    /// The external_tables_to_exclude attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExternalTablesToExclude
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("external_tables_to_exclude");
        set => WithProperty("external_tables_to_exclude", value);
    }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExternalTablesToInclude
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("external_tables_to_include");
        set => WithProperty("external_tables_to_include", value);
    }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MaterializedViewsToExclude
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("materialized_views_to_exclude");
        set => WithProperty("materialized_views_to_exclude", value);
    }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MaterializedViewsToInclude
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("materialized_views_to_include");
        set => WithProperty("materialized_views_to_include", value);
    }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TablesToExclude
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tables_to_exclude");
        set => WithProperty("tables_to_exclude", value);
    }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TablesToInclude
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tables_to_include");
        set => WithProperty("tables_to_include", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_attached_database_configuration resource.
/// </summary>
public class AzurermKustoAttachedDatabaseConfiguration : TerraformResource
{
    public AzurermKustoAttachedDatabaseConfiguration(string name) : base("azurerm_kusto_attached_database_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attached_database_names");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? ClusterResourceId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_resource_id");
        set => this.WithProperty("cluster_resource_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultPrincipalModificationKind
    {
        get => GetProperty<TerraformProperty<string>>("default_principal_modification_kind");
        set => this.WithProperty("default_principal_modification_kind", value);
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
    /// Block for sharing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    public List<AzurermKustoAttachedDatabaseConfigurationSharingBlock>? Sharing
    {
        get => GetProperty<List<AzurermKustoAttachedDatabaseConfigurationSharingBlock>>("sharing");
        set => this.WithProperty("sharing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The attached_database_names attribute.
    /// </summary>
    public TerraformExpression AttachedDatabaseNames => this["attached_database_names"];

}
