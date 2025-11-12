using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadDirectoryRoleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_directory_role resource.
/// </summary>
public partial class AzureadDirectoryRole : TerraformResource
{
    public AzureadDirectoryRole(string name) : base("azuread_directory_role", name)
    {
    }

    /// <summary>
    /// The display name of the directory role
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the template associated with the directory role
    /// </summary>
    [TerraformProperty("template_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadDirectoryRoleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description of the directory role
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

}
