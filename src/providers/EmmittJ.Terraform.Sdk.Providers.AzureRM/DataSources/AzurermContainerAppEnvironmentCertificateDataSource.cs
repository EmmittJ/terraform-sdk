using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_app_environment_certificate.
/// </summary>
public partial class AzurermContainerAppEnvironmentCertificateDataSource : TerraformDataSource
{
    public AzurermContainerAppEnvironmentCertificateDataSource(string name) : base("azurerm_container_app_environment_certificate", name)
    {
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Container Apps Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    [TerraformProperty("issue_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IssueDate { get; }

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    [TerraformProperty("issuer")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Issuer { get; }

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    [TerraformProperty("subject_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubjectName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Thumbprint { get; }

}
