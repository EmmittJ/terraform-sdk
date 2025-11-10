using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_api_version_set.
/// </summary>
public class AzurermApiManagementApiVersionSetDataSource : TerraformDataSource
{
    public AzurermApiManagementApiVersionSetDataSource(string name) : base("azurerm_api_management_api_version_set", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformPropertyName("api_management_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiManagementName { get; set; }

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
    public TerraformBlock<AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The version_header_name attribute.
    /// </summary>
    [TerraformPropertyName("version_header_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionHeaderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_header_name");

    /// <summary>
    /// The version_query_name attribute.
    /// </summary>
    [TerraformPropertyName("version_query_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionQueryName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_query_name");

    /// <summary>
    /// The versioning_scheme attribute.
    /// </summary>
    [TerraformPropertyName("versioning_scheme")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersioningScheme => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versioning_scheme");

}
