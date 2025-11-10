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
        set => SetProperty("external_tables_to_exclude", value);
    }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExternalTablesToInclude
    {
        set => SetProperty("external_tables_to_include", value);
    }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MaterializedViewsToExclude
    {
        set => SetProperty("materialized_views_to_exclude", value);
    }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MaterializedViewsToInclude
    {
        set => SetProperty("materialized_views_to_include", value);
    }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TablesToExclude
    {
        set => SetProperty("tables_to_exclude", value);
    }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TablesToInclude
    {
        set => SetProperty("tables_to_include", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_attached_database_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKustoAttachedDatabaseConfiguration : TerraformResource
{
    public AzurermKustoAttachedDatabaseConfiguration(string name) : base("azurerm_kusto_attached_database_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("attached_database_names");
        SetOutput("cluster_id");
        SetOutput("cluster_name");
        SetOutput("cluster_resource_id");
        SetOutput("database_name");
        SetOutput("default_principal_modification_kind");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> ClusterResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_resource_id");
        set => SetProperty("cluster_resource_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    public TerraformProperty<string> DefaultPrincipalModificationKind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_principal_modification_kind");
        set => SetProperty("default_principal_modification_kind", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for sharing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    public List<AzurermKustoAttachedDatabaseConfigurationSharingBlock>? Sharing
    {
        set => SetProperty("sharing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The attached_database_names attribute.
    /// </summary>
    public TerraformExpression AttachedDatabaseNames => this["attached_database_names"];

}
