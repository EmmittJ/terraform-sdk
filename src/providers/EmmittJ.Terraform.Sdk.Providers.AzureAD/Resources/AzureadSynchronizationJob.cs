using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadSynchronizationJobTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azuread_synchronization_job resource.
/// </summary>
public partial class AzureadSynchronizationJob : TerraformResource
{
    public AzureadSynchronizationJob(string name) : base("azuread_synchronization_job", name)
    {
    }

    /// <summary>
    /// Whether or not the synchronization job is enabled
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the service principal for which this synchronization job should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformProperty("service_principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServicePrincipalId { get; set; }

    /// <summary>
    /// Identifier of the synchronization template this job is based on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformProperty("template_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadSynchronizationJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformProperty("schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Schedule { get; }

}
