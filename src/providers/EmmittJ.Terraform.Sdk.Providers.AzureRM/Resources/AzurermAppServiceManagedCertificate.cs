using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceManagedCertificateTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_app_service_managed_certificate resource.
/// </summary>
public class AzurermAppServiceManagedCertificate : TerraformResource
{
    public AzurermAppServiceManagedCertificate(string name) : base("azurerm_app_service_managed_certificate", name)
    {
    }

    /// <summary>
    /// The custom_hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHostnameBindingId is required")]
    [TerraformPropertyName("custom_hostname_binding_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomHostnameBindingId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public TerraformBlock<AzurermAppServiceManagedCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The canonical_name attribute.
    /// </summary>
    [TerraformPropertyName("canonical_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CanonicalName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "canonical_name");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FriendlyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "friendly_name");

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformPropertyName("host_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> HostNames => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "host_names");

    /// <summary>
    /// The issue_date attribute.
    /// </summary>
    [TerraformPropertyName("issue_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IssueDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issue_date");

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Issuer => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issuer");

    /// <summary>
    /// The subject_name attribute.
    /// </summary>
    [TerraformPropertyName("subject_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubjectName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subject_name");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

}
