using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentCertificateTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_environment_certificate resource.
/// </summary>
public class AzurermContainerAppEnvironmentCertificate : TerraformResource
{
    public AzurermContainerAppEnvironmentCertificate(string name) : base("azurerm_container_app_environment_certificate", name)
    {
    }

    /// <summary>
    /// The Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBlobBase64 is required")]
    [TerraformPropertyName("certificate_blob_base64")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CertificateBlobBase64 { get; set; }

    /// <summary>
    /// The password for the Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificatePassword is required")]
    [TerraformPropertyName("certificate_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CertificatePassword { get; set; }

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
    /// The name of the Container Apps Environment Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The Thumbprint of the Certificate.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

}
