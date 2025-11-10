using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sharing in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoAttachedDatabaseConfigurationSharingBlock : ITerraformBlock
{
    /// <summary>
    /// The external_tables_to_exclude attribute.
    /// </summary>
    [TerraformPropertyName("external_tables_to_exclude")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExternalTablesToExclude { get; set; }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    [TerraformPropertyName("external_tables_to_include")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExternalTablesToInclude { get; set; }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    [TerraformPropertyName("materialized_views_to_exclude")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? MaterializedViewsToExclude { get; set; }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    [TerraformPropertyName("materialized_views_to_include")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? MaterializedViewsToInclude { get; set; }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    [TerraformPropertyName("tables_to_exclude")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TablesToExclude { get; set; }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
    [TerraformPropertyName("tables_to_include")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TablesToInclude { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("cluster_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_id");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("cluster_resource_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterResourceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_resource_id");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    [TerraformPropertyName("default_principal_modification_kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultPrincipalModificationKind { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for sharing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    [TerraformPropertyName("sharing")]
    public TerraformList<TerraformBlock<AzurermKustoAttachedDatabaseConfigurationSharingBlock>>? Sharing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The attached_database_names attribute.
    /// </summary>
    [TerraformPropertyName("attached_database_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AttachedDatabaseNames => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "attached_database_names");

}
