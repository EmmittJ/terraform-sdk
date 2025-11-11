using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadUserFlowAttributeTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_user_flow_attribute resource.
/// </summary>
public partial class AzureadUserFlowAttribute : TerraformResource
{
    public AzureadUserFlowAttribute(string name) : base("azuread_user_flow_attribute", name)
    {
    }

    /// <summary>
    /// The data type of the user flow attribute
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataType is required")]
    [TerraformProperty("data_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataType { get; set; }

    /// <summary>
    /// The description of the user flow attribute that is shown to the user at the time of sign-up
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display name of the user flow attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadUserFlowAttributeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The type of the user flow attribute
    /// </summary>
    [TerraformProperty("attribute_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AttributeType { get; }

}
