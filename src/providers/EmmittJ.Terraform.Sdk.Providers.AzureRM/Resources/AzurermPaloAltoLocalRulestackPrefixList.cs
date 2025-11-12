using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPaloAltoLocalRulestackPrefixListTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_palo_alto_local_rulestack_prefix_list resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackPrefixList : TerraformResource
{
    public AzurermPaloAltoLocalRulestackPrefixList(string name) : base("azurerm_palo_alto_local_rulestack_prefix_list", name)
    {
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    [TerraformProperty("audit_comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuditComment { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

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
    /// The prefix_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixList is required")]
    [TerraformProperty("prefix_list")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PrefixList { get; set; }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformProperty("rulestack_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RulestackId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPaloAltoLocalRulestackPrefixListTimeoutsBlock Timeouts { get; set; } = new();

}
