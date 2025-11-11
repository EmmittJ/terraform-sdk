using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sharing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKustoAttachedDatabaseConfigurationSharingBlock : TerraformBlockBase
{
    /// <summary>
    /// The external_tables_to_exclude attribute.
    /// </summary>
    [TerraformProperty("external_tables_to_exclude")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExternalTablesToExclude { get; set; }

    /// <summary>
    /// The external_tables_to_include attribute.
    /// </summary>
    [TerraformProperty("external_tables_to_include")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExternalTablesToInclude { get; set; }

    /// <summary>
    /// The materialized_views_to_exclude attribute.
    /// </summary>
    [TerraformProperty("materialized_views_to_exclude")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? MaterializedViewsToExclude { get; set; }

    /// <summary>
    /// The materialized_views_to_include attribute.
    /// </summary>
    [TerraformProperty("materialized_views_to_include")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? MaterializedViewsToInclude { get; set; }

    /// <summary>
    /// The tables_to_exclude attribute.
    /// </summary>
    [TerraformProperty("tables_to_exclude")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? TablesToExclude { get; set; }

    /// <summary>
    /// The tables_to_include attribute.
    /// </summary>
    [TerraformProperty("tables_to_include")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? TablesToInclude { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_attached_database_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKustoAttachedDatabaseConfiguration : TerraformResource
{
    public AzurermKustoAttachedDatabaseConfiguration(string name) : base("azurerm_kusto_attached_database_configuration", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [TerraformProperty("cluster_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("cluster_resource_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterResourceId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The default_principal_modification_kind attribute.
    /// </summary>
    [TerraformProperty("default_principal_modification_kind")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultPrincipalModificationKind { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for sharing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    [TerraformProperty("sharing")]
    public TerraformList<TerraformBlock<AzurermKustoAttachedDatabaseConfigurationSharingBlock>>? Sharing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKustoAttachedDatabaseConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The attached_database_names attribute.
    /// </summary>
    [TerraformProperty("attached_database_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AttachedDatabaseNames { get; }

}
