using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRolesDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_directory_roles.
/// </summary>
public class AzureadDirectoryRolesDataSource : TerraformDataSource
{
    public AzureadDirectoryRolesDataSource(string name) : base("azuread_directory_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadDirectoryRolesDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The object IDs of the roles
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ObjectIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "object_ids");

    /// <summary>
    /// A list of roles
    /// </summary>
    [TerraformPropertyName("roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Roles => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "roles");

    /// <summary>
    /// The template IDs of the roles
    /// </summary>
    [TerraformPropertyName("template_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> TemplateIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "template_ids");

}
