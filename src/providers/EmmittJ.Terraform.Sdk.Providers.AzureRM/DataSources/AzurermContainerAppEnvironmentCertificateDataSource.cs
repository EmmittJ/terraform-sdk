using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Container Apps Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    [TerraformPropertyName("issue_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IssueDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issue_date");

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Issuer => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issuer");

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    [TerraformPropertyName("subject_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubjectName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subject_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

}
