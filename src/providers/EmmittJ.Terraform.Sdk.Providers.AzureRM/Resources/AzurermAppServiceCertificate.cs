using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_app_service_certificate resource.
/// </summary>
public class AzurermAppServiceCertificate : TerraformResource
{
    public AzurermAppServiceCertificate(string name) : base("azurerm_app_service_certificate", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("app_service_plan_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppServicePlanId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultId { get; set; }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// The pfx_blob attribute.
    /// </summary>
    [TerraformPropertyName("pfx_blob")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PfxBlob { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

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
    public TerraformBlock<AzurermAppServiceCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The hosting_environment_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("hosting_environment_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostingEnvironmentProfileId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosting_environment_profile_id");

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
