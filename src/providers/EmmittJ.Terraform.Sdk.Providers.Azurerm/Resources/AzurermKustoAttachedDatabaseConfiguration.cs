using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sharing in AzurermKustoAttachedDatabaseConfiguration.
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
        get => GetArgument<TerraformSet<string>>("external_tables_to_exclude");
        set => SetArgument("external_tables_to_exclude", value);
    }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    public TerraformSet<string>? ExternalTablesToInclude
    {
        get => GetArgument<TerraformSet<string>>("external_tables_to_include");
        set => SetArgument("external_tables_to_include", value);
    }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    public TerraformSet<string>? MaterializedViewsToExclude
    {
        get => GetArgument<TerraformSet<string>>("materialized_views_to_exclude");
        set => SetArgument("materialized_views_to_exclude", value);
    }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    public TerraformSet<string>? MaterializedViewsToInclude
    {
        get => GetArgument<TerraformSet<string>>("materialized_views_to_include");
        set => SetArgument("materialized_views_to_include", value);
    }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    public TerraformSet<string>? TablesToExclude
    {
        get => GetArgument<TerraformSet<string>>("tables_to_exclude");
        set => SetArgument("tables_to_exclude", value);
    }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
    public TerraformSet<string>? TablesToInclude
    {
        get => GetArgument<TerraformSet<string>>("tables_to_include");
        set => SetArgument("tables_to_include", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKustoAttachedDatabaseConfiguration.
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformValue<string>? ClusterId
    {
        get => GetArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ClusterResourceId
    {
        get => GetArgument<TerraformValue<string>>("cluster_resource_id");
        set => SetArgument("cluster_resource_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPrincipalModificationKind
    {
        get => GetArgument<TerraformValue<string>>("default_principal_modification_kind");
        set => SetArgument("default_principal_modification_kind", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The attached_database_names attribute.
    /// </summary>
    public TerraformList<string> AttachedDatabaseNames
        => AsReference("attached_database_names");

    /// <summary>
    /// Sharing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    public TerraformList<AzurermKustoAttachedDatabaseConfigurationSharingBlock>? Sharing
    {
        get => GetArgument<TerraformList<AzurermKustoAttachedDatabaseConfigurationSharingBlock>>("sharing");
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
