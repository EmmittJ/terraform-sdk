using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_server.
/// </summary>
public class AzurermMssqlServerDataSource : TerraformDataSource
{
    public AzurermMssqlServerDataSource(string name) : base("azurerm_mssql_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlServerDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdministratorLogin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "administrator_login");

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    [TerraformPropertyName("express_vulnerability_assessment_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExpressVulnerabilityAssessmentEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "express_vulnerability_assessment_enabled");

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("fully_qualified_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FullyQualifiedDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fully_qualified_domain_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    [TerraformPropertyName("restorable_dropped_database_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> RestorableDroppedDatabaseIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "restorable_dropped_database_ids");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("transparent_data_encryption_key_vault_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransparentDataEncryptionKeyVaultKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transparent_data_encryption_key_vault_key_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
