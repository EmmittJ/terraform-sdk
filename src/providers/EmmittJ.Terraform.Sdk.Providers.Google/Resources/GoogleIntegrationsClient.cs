using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_kms_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsClientCloudKmsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A Cloud KMS key is a named object containing one or more key versions, along
    /// with metadata for the key. A key exists on exactly one key ring tied to a
    /// specific location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// Each version of a key contains key material used for encryption or signing.
    /// A key&#39;s version is represented by an integer, starting at 1. To decrypt data
    /// or verify a signature, you must use the same key version that was used to
    /// encrypt or sign the data.
    /// </summary>
    [TerraformPropertyName("key_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyVersion { get; set; }

    /// <summary>
    /// Location name of the key ring, e.g. &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsLocation is required")]
    [TerraformPropertyName("kms_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsLocation { get; set; }

    /// <summary>
    /// The Google Cloud project id of the project where the kms key stored. If empty,
    /// the kms key is stored at the same project as customer&#39;s project and ecrypted
    /// with CMEK, otherwise, the kms key is stored in the tenant project and
    /// encrypted with GMEK.
    /// </summary>
    [TerraformPropertyName("kms_project_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsProjectId { get; set; }

    /// <summary>
    /// A key ring organizes keys in a specific Google Cloud location and allows you to
    /// manage access control on groups of keys. A key ring&#39;s name does not need to be
    /// unique across a Google Cloud project, but must be unique within a given location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsRing is required")]
    [TerraformPropertyName("kms_ring")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsRing { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationsClientTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_integrations_client resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIntegrationsClient : TerraformResource
{
    public GoogleIntegrationsClient(string name) : base("google_integrations_client", name)
    {
    }

    /// <summary>
    /// Indicates if sample integrations should be created along with provisioning.
    /// </summary>
    [TerraformPropertyName("create_sample_integrations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateSampleIntegrations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// User input run-as service account, if empty, will bring up a new default service account.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("run_as_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RunAsServiceAccount { get; set; }

    /// <summary>
    /// Block for cloud_kms_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudKmsConfig block(s) allowed")]
    [TerraformPropertyName("cloud_kms_config")]
    public TerraformList<TerraformBlock<GoogleIntegrationsClientCloudKmsConfigBlock>>? CloudKmsConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIntegrationsClientTimeoutsBlock>? Timeouts { get; set; } = new();

}
