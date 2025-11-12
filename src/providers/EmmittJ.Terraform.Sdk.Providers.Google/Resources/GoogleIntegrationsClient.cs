using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_kms_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationsClientCloudKmsConfigBlock() : TerraformBlock("cloud_kms_config")
{
    /// <summary>
    /// A Cloud KMS key is a named object containing one or more key versions, along
    /// with metadata for the key. A key exists on exactly one key ring tied to a
    /// specific location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// Each version of a key contains key material used for encryption or signing.
    /// A key&#39;s version is represented by an integer, starting at 1. To decrypt data
    /// or verify a signature, you must use the same key version that was used to
    /// encrypt or sign the data.
    /// </summary>
    [TerraformProperty("key_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVersion { get; set; }

    /// <summary>
    /// Location name of the key ring, e.g. &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsLocation is required")]
    [TerraformProperty("kms_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsLocation { get; set; }

    /// <summary>
    /// The Google Cloud project id of the project where the kms key stored. If empty,
    /// the kms key is stored at the same project as customer&#39;s project and ecrypted
    /// with CMEK, otherwise, the kms key is stored in the tenant project and
    /// encrypted with GMEK.
    /// </summary>
    [TerraformProperty("kms_project_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsProjectId { get; set; }

    /// <summary>
    /// A key ring organizes keys in a specific Google Cloud location and allows you to
    /// manage access control on groups of keys. A key ring&#39;s name does not need to be
    /// unique across a Google Cloud project, but must be unique within a given location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsRing is required")]
    [TerraformProperty("kms_ring")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsRing { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIntegrationsClientTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_integrations_client resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIntegrationsClient : TerraformResource
{
    public GoogleIntegrationsClient(string name) : base("google_integrations_client", name)
    {
    }

    /// <summary>
    /// Indicates if sample integrations should be created along with provisioning.
    /// </summary>
    [TerraformProperty("create_sample_integrations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateSampleIntegrations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// User input run-as service account, if empty, will bring up a new default service account.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("run_as_service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RunAsServiceAccount { get; set; }

    /// <summary>
    /// Block for cloud_kms_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudKmsConfig block(s) allowed")]
    [TerraformProperty("cloud_kms_config")]
    public TerraformList<GoogleIntegrationsClientCloudKmsConfigBlock> CloudKmsConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIntegrationsClientTimeoutsBlock Timeouts { get; set; } = new();

}
