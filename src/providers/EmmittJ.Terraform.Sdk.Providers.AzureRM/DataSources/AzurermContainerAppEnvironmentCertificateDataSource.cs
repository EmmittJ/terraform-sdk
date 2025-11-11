using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_app_environment_certificate.
/// </summary>
public class AzurermContainerAppEnvironmentCertificateDataSource : TerraformDataSource
{
    public AzurermContainerAppEnvironmentCertificateDataSource(string name) : base("azurerm_container_app_environment_certificate", name)
    {
    }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformPropertyName("container_app_environment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the Container Apps Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationDate => new TerraformReference(this, "expiration_date");

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    [TerraformPropertyName("issue_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IssueDate => new TerraformReference(this, "issue_date");

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Issuer => new TerraformReference(this, "issuer");

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    [TerraformPropertyName("subject_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubjectName => new TerraformReference(this, "subject_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Thumbprint => new TerraformReference(this, "thumbprint");

}
