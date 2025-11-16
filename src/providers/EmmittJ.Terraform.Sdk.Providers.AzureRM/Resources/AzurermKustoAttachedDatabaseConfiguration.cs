using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformSet<string>? ExternalTablesToExclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "external_tables_to_exclude").ResolveNodes(ctx));
        set => SetArgument("external_tables_to_exclude", value);
    }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    public TerraformSet<string>? ExternalTablesToInclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "external_tables_to_include").ResolveNodes(ctx));
        set => SetArgument("external_tables_to_include", value);
    }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    public TerraformSet<string>? MaterializedViewsToExclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "materialized_views_to_exclude").ResolveNodes(ctx));
        set => SetArgument("materialized_views_to_exclude", value);
    }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    public TerraformSet<string>? MaterializedViewsToInclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "materialized_views_to_include").ResolveNodes(ctx));
        set => SetArgument("materialized_views_to_include", value);
    }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    public TerraformSet<string>? TablesToExclude
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tables_to_exclude").ResolveNodes(ctx));
        set => SetArgument("tables_to_exclude", value);
    }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_kusto_attached_database_configuration Terraform resource.
/// Manages a azurerm_kusto_attached_database_configuration resource.
/// </summary>
public partial class AzurermKustoAttachedDatabaseConfiguration(string name) : TerraformResource("azurerm_kusto_attached_database_configuration", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ClusterResourceId
    {
        get => new TerraformReference<string>(this, "cluster_resource_id");
        set => SetArgument("cluster_resource_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPrincipalModificationKind
    {
        get => new TerraformReference<string>(this, "default_principal_modification_kind");
        set => SetArgument("default_principal_modification_kind", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Sharing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    public AzurermKustoAttachedDatabaseConfigurationSharingBlock? Sharing
    {
        get => GetArgument<AzurermKustoAttachedDatabaseConfigurationSharingBlock>("sharing");
        set => SetArgument("sharing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
