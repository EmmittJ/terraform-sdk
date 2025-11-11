using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for private_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSecureSourceManagerInstancePrivateConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// CA pool resource, resource must in the format of &#39;projects/{project}/locations/{location}/caPools/{ca_pool}&#39;.
    /// </summary>
    [TerraformProperty("ca_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CaPool { get; set; }


    /// <summary>
    /// &#39;Indicate if it&#39;s private instance.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrivate is required")]
    [TerraformProperty("is_private")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsPrivate { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecureSourceManagerInstanceTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for workforce_identity_federation_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// &#39;Whether Workforce Identity Federation is enabled.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Manages a google_secure_source_manager_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSecureSourceManagerInstance : TerraformResource
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
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// Customer-managed encryption key name, in the format projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the Instance.
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
    /// Block for private_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConfig block(s) allowed")]
    [TerraformProperty("private_config")]
    public partial TerraformList<TerraformBlock<GoogleSecureSourceManagerInstancePrivateConfigBlock>>? PrivateConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleSecureSourceManagerInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for workforce_identity_federation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceIdentityFederationConfig block(s) allowed")]
    [TerraformProperty("workforce_identity_federation_config")]
    public partial TerraformList<TerraformBlock<GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock>>? WorkforceIdentityFederationConfig { get; set; }

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// A list of hostnames for this instance.
    /// </summary>
    [TerraformProperty("host_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HostConfig { get; }

    /// <summary>
    /// The resource name for the Instance.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the Instance.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Provides information about the current instance state.
    /// </summary>
    [TerraformProperty("state_note")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateNote { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
