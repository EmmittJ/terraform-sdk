using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for private_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerInstancePrivateConfigBlock : ITerraformBlock
{
    /// <summary>
    /// CA pool resource, resource must in the format of &#39;projects/{project}/locations/{location}/caPools/{ca_pool}&#39;.
    /// </summary>
    [TerraformPropertyName("ca_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CaPool { get; set; }

    /// <summary>
    /// Service Attachment for HTTP, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    [TerraformPropertyName("http_service_attachment")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HttpServiceAttachment => new TerraformReferenceProperty<TerraformProperty<string>>("", "http_service_attachment");

    /// <summary>
    /// &#39;Indicate if it&#39;s private instance.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrivate is required")]
    [TerraformPropertyName("is_private")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsPrivate { get; set; }

    /// <summary>
    /// Service Attachment for SSH, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    [TerraformPropertyName("ssh_service_attachment")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SshServiceAttachment => new TerraformReferenceProperty<TerraformProperty<string>>("", "ssh_service_attachment");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerInstanceTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for workforce_identity_federation_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// &#39;Whether Workforce Identity Federation is enabled.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Manages a google_secure_source_manager_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecureSourceManagerInstance : TerraformResource
{
    public GoogleSecureSourceManagerInstance(string name) : base("google_secure_source_manager_instance", name)
    {
    }

    /// <summary>
    /// The deletion policy for the instance. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned, rather than deleted. Setting &#39;DELETE&#39; deletes the resource
    /// and all its contents. Setting &#39;PREVENT&#39; prevents the resource from accidental
    /// deletion by erroring out during plan.
    /// Default is &#39;PREVENT&#39;.  Possible values are:
    ///   * DELETE
    ///   * PREVENT
    ///   * ABANDON
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// Customer-managed encryption key name, in the format projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location for the Instance.
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
    /// Block for private_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConfig block(s) allowed")]
    [TerraformPropertyName("private_config")]
    public TerraformList<TerraformBlock<GoogleSecureSourceManagerInstancePrivateConfigBlock>>? PrivateConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSecureSourceManagerInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workforce_identity_federation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceIdentityFederationConfig block(s) allowed")]
    [TerraformPropertyName("workforce_identity_federation_config")]
    public TerraformList<TerraformBlock<GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock>>? WorkforceIdentityFederationConfig { get; set; } = new();

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// A list of hostnames for this instance.
    /// </summary>
    [TerraformPropertyName("host_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HostConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "host_config");

    /// <summary>
    /// The resource name for the Instance.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The current state of the Instance.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Provides information about the current instance state.
    /// </summary>
    [TerraformPropertyName("state_note")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateNote => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_note");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
