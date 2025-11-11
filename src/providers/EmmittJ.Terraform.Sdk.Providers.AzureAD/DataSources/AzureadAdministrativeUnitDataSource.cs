using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAdministrativeUnitDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_administrative_unit.
/// </summary>
public partial class AzureadAdministrativeUnitDataSource : TerraformDataSource
{
    public AzureadAdministrativeUnitDataSource(string name) : base("azuread_administrative_unit", name)
    {
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadAdministrativeUnitDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// A list of object IDs of members who are be present in this administrative unit.
    /// </summary>
    [TerraformProperty("members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Members { get; }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    [TerraformProperty("visibility")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Visibility { get; }

}
