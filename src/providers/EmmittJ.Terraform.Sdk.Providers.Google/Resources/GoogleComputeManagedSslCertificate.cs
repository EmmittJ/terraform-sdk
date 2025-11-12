using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeManagedSslCertificateManagedBlock() : TerraformBlock("managed")
{
    /// <summary>
    /// Domains for which a managed SSL certificate will be valid.  Currently,
    /// there can be up to 100 domains in this list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domains is required")]
    [TerraformProperty("domains")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Domains { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeManagedSslCertificateTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_compute_managed_ssl_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeManagedSslCertificate : TerraformResource
{
    public GoogleComputeManagedSslCertificate(string name) : base("google_compute_managed_ssl_certificate", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// 
    /// These are in the same namespace as the managed SSL certificates.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Enum field whose value is always &#39;MANAGED&#39; - used to signal to the API
    /// which type this is. Default value: &amp;quot;MANAGED&amp;quot; Possible values: [&amp;quot;MANAGED&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    [TerraformProperty("managed")]
    public TerraformList<GoogleComputeManagedSslCertificateManagedBlock> Managed { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeManagedSslCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformProperty("certificate_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CertificateId { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Expire time of the certificate in RFC3339 text format.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Domains associated with the certificate via Subject Alternative Name.
    /// </summary>
    [TerraformProperty("subject_alternative_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SubjectAlternativeNames { get; }

}
