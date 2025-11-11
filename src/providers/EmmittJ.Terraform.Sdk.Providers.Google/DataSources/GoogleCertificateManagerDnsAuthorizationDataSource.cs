using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_certificate_manager_dns_authorization.
/// </summary>
public partial class GoogleCertificateManagerDnsAuthorizationDataSource : TerraformDataSource
{
    public GoogleCertificateManagerDnsAuthorizationDataSource(string name) : base("google_certificate_manager_dns_authorization", name)
    {
    }

    /// <summary>
    /// A domain which is being authorized. A DnsAuthorization resource covers a
    /// single domain and its wildcard, e.g. authorization for &amp;quot;example.com&amp;quot; can
    /// be used to issue certificates for &amp;quot;example.com&amp;quot; and &amp;quot;*.example.com&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The structure describing the DNS Resource Record that needs to be added
    /// to DNS configuration for the authorization to be usable by
    /// certificate.
    /// </summary>
    [TerraformProperty("dns_resource_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DnsResourceRecord { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Set of label tags associated with the DNS Authorization resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// type of DNS authorization. If unset during the resource creation, FIXED_RECORD will
    /// be used for global resources, and PER_PROJECT_RECORD will be used for other locations.
    /// 
    /// FIXED_RECORD DNS authorization uses DNS-01 validation method
    /// 
    /// PER_PROJECT_RECORD DNS authorization allows for independent management
    /// of Google-managed certificates with DNS authorization across multiple
    /// projects. Possible values: [&amp;quot;FIXED_RECORD&amp;quot;, &amp;quot;PER_PROJECT_RECORD&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
