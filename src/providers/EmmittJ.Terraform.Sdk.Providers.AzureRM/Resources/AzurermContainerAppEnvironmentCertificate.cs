using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentCertificateTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_container_app_environment_certificate resource.
/// </summary>
public partial class AzurermContainerAppEnvironmentCertificate : TerraformResource
{
    public AzurermContainerAppEnvironmentCertificate(string name) : base("azurerm_container_app_environment_certificate", name)
    {
    }

    /// <summary>
    /// The Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBlobBase64 is required")]
    [TerraformProperty("certificate_blob_base64")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateBlobBase64 { get; set; }

    /// <summary>
    /// The password for the Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificatePassword is required")]
    [TerraformProperty("certificate_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificatePassword { get; set; }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Certificate on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Container Apps Environment Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    public TerraformBlock<AzurermContainerAppEnvironmentCertificateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The expiration date for the Certificate.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The date of issue for the Certificate.
    /// </summary>
    [TerraformProperty("issue_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IssueDate { get; }

    /// <summary>
    /// The Certificate Issuer.
    /// </summary>
    [TerraformProperty("issuer")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Issuer { get; }

    /// <summary>
    /// The Subject Name for the Certificate.
    /// </summary>
    [TerraformProperty("subject_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubjectName { get; }

    /// <summary>
    /// The Thumbprint of the Certificate.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Thumbprint { get; }

}
