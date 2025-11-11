using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_service.
/// </summary>
public partial class GoogleProjectServiceDataSource : TerraformDataSource
{
    public GoogleProjectServiceDataSource(string name) : base("google_project_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    [TerraformProperty("disable_dependent_services")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DisableDependentServices { get; }

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    [TerraformProperty("disable_on_destroy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DisableOnDestroy { get; }

}
