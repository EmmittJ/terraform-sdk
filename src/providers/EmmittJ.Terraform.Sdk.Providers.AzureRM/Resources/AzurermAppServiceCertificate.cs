using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceCertificateTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_app_service_certificate resource.
/// </summary>
public partial class AzurermAppServiceCertificate : TerraformResource
{
    public AzurermAppServiceCertificate(string name) : base("azurerm_app_service_certificate", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [TerraformProperty("app_service_plan_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppServicePlanId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultId { get; set; }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The pfx_blob attribute.
    /// </summary>
    [TerraformProperty("pfx_blob")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PfxBlob { get; set; }

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
    public TerraformBlock<AzurermAppServiceCertificateTimeoutsBlock>? Timeouts { get; set; }

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
    /// The hosting_environment_profile_id attribute.
    /// </summary>
    [TerraformProperty("hosting_environment_profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostingEnvironmentProfileId { get; }

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
