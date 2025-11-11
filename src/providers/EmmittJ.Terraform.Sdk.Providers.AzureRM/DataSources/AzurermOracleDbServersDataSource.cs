using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleDbServersDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_db_servers.
/// </summary>
public partial class AzurermOracleDbServersDataSource : TerraformDataSource
{
    public AzurermOracleDbServersDataSource(string name) : base("azurerm_oracle_db_servers", name)
    {
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureName is required")]
    [TerraformProperty("cloud_exadata_infrastructure_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CloudExadataInfrastructureName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleDbServersDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [TerraformProperty("db_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DbServers { get; }

}
