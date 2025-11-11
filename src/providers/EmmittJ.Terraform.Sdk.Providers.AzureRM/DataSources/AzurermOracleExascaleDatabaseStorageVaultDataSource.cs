using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_exascale_database_storage_vault.
/// </summary>
public class AzurermOracleExascaleDatabaseStorageVaultDataSource : TerraformDataSource
{
    public AzurermOracleExascaleDatabaseStorageVaultDataSource(string name) : base("azurerm_oracle_exascale_database_storage_vault", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The additional_flash_cache_percentage attribute.
    /// </summary>
    [TerraformPropertyName("additional_flash_cache_percentage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AdditionalFlashCachePercentage => new TerraformReference(this, "additional_flash_cache_percentage");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The high_capacity_database_storage attribute.
    /// </summary>
    [TerraformPropertyName("high_capacity_database_storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HighCapacityDatabaseStorage => new TerraformReference(this, "high_capacity_database_storage");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleDetails => new TerraformReference(this, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeZone => new TerraformReference(this, "time_zone");

    /// <summary>
    /// The virtual_machine_cluster_count attribute.
    /// </summary>
    [TerraformPropertyName("virtual_machine_cluster_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VirtualMachineClusterCount => new TerraformReference(this, "virtual_machine_cluster_count");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
