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
/// Block type for sharing in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoAttachedDatabaseConfigurationSharingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sharing";

    /// <summary>
    /// The external_tables_to_exclude attribute.
    /// </summary>
    [TerraformArgument("external_tables_to_exclude")]
    public TerraformSet<string>? ExternalTablesToExclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "external_tables_to_exclude").ResolveNodes(ctx));
        set => SetArgument("external_tables_to_exclude", value);
    }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    [TerraformArgument("external_tables_to_include")]
    public TerraformSet<string>? ExternalTablesToInclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "external_tables_to_include").ResolveNodes(ctx));
        set => SetArgument("external_tables_to_include", value);
    }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    [TerraformArgument("materialized_views_to_exclude")]
    public TerraformSet<string>? MaterializedViewsToExclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "materialized_views_to_exclude").ResolveNodes(ctx));
        set => SetArgument("materialized_views_to_exclude", value);
    }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    [TerraformArgument("materialized_views_to_include")]
    public TerraformSet<string>? MaterializedViewsToInclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "materialized_views_to_include").ResolveNodes(ctx));
        set => SetArgument("materialized_views_to_include", value);
    }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    [TerraformArgument("tables_to_exclude")]
    public TerraformSet<string>? TablesToExclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tables_to_exclude").ResolveNodes(ctx));
        set => SetArgument("tables_to_exclude", value);
    }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
    [TerraformArgument("tables_to_include")]
    public TerraformSet<string>? TablesToInclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tables_to_include").ResolveNodes(ctx));
        set => SetArgument("tables_to_include", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformArgument("cluster_id")]
    public TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformArgument("cluster_name")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("cluster_resource_id")]
    public TerraformValue<string> ClusterResourceId
    {
        get => new TerraformReference<string>(this, "cluster_resource_id");
        set => SetArgument("cluster_resource_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformArgument("database_name")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    [TerraformArgument("default_principal_modification_kind")]
    public TerraformValue<string>? DefaultPrincipalModificationKind
    {
        get => new TerraformReference<string>(this, "default_principal_modification_kind");
        set => SetArgument("default_principal_modification_kind", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for sharing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    [TerraformArgument("sharing")]
    public TerraformList<AzurermKustoAttachedDatabaseConfigurationSharingBlock> Sharing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The attached_database_names attribute.
    /// </summary>
    [TerraformArgument("attached_database_names")]
    public TerraformList<string> AttachedDatabaseNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "attached_database_names").ResolveNodes(ctx));
    }

}
