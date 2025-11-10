using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_directory_role_templates.
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSource : TerraformDataSource
{
    public AzureadDirectoryRoleTemplatesDataSource(string name) : base("azuread_directory_role_templates", name)
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
    public TerraformBlock<AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The object IDs of the role templates
    /// </summary>
    [TerraformPropertyName("object_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ObjectIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "object_ids");

    /// <summary>
    /// A list of role templates
    /// </summary>
    [TerraformPropertyName("role_templates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RoleTemplates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "role_templates");

}
