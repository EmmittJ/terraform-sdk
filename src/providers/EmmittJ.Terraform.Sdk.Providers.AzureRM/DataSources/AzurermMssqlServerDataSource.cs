using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlServerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_server.
/// </summary>
public partial class AzurermMssqlServerDataSource : TerraformDataSource
{
    public AzurermMssqlServerDataSource(string name) : base("azurerm_mssql_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlServerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdministratorLogin { get; }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    [TerraformProperty("express_vulnerability_assessment_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExpressVulnerabilityAssessmentEnabled { get; }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    [TerraformProperty("fully_qualified_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FullyQualifiedDomainName { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    [TerraformProperty("restorable_dropped_database_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> RestorableDroppedDatabaseIds { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_key_vault_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
