using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadDirectoryRolesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_directory_roles.
/// </summary>
public partial class AzureadDirectoryRolesDataSource : TerraformDataSource
{
    public AzureadDirectoryRolesDataSource(string name) : base("azuread_directory_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadDirectoryRolesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The object IDs of the roles
    /// </summary>
    [TerraformProperty("object_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ObjectIds { get; }

    /// <summary>
    /// A list of roles
    /// </summary>
    [TerraformProperty("roles")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Roles { get; }

    /// <summary>
    /// The template IDs of the roles
    /// </summary>
    [TerraformProperty("template_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> TemplateIds { get; }

}
