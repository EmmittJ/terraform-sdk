using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceCertificateDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_certificate.
/// </summary>
public partial class AzurermAppServiceCertificateDataSource : TerraformDataSource
{
    public AzurermAppServiceCertificateDataSource(string name) : base("azurerm_app_service_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAppServiceCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FriendlyName { get; }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformProperty("host_names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> HostNames { get; }

    /// <summary>
    /// The issue_date attribute.
    /// </summary>
    [TerraformProperty("issue_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IssueDate { get; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformProperty("issuer")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Issuer { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The subject_name attribute.
    /// </summary>
    [TerraformProperty("subject_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubjectName { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Thumbprint { get; }

}
