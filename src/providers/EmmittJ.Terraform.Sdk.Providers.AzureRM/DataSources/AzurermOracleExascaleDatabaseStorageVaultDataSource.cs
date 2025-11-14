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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The additional_flash_cache_percentage attribute.
    /// </summary>
    [TerraformArgument("additional_flash_cache_percentage")]
    public TerraformValue<double> AdditionalFlashCachePercentage
    {
        get => new TerraformReference<double>(this, "additional_flash_cache_percentage");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The high_capacity_database_storage attribute.
    /// </summary>
    [TerraformArgument("high_capacity_database_storage")]
    public TerraformList<object> HighCapacityDatabaseStorage
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "high_capacity_database_storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformArgument("lifecycle_details")]
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformArgument("lifecycle_state")]
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformArgument("oci_url")]
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformArgument("ocid")]
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
    }

    /// <summary>
    /// The virtual_machine_cluster_count attribute.
    /// </summary>
    [TerraformArgument("virtual_machine_cluster_count")]
    public TerraformValue<double> VirtualMachineClusterCount
    {
        get => new TerraformReference<double>(this, "virtual_machine_cluster_count");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
