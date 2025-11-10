using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_ssl_certificate.
/// </summary>
public class GoogleComputeSslCertificateDataSource : TerraformDataSource
{
    public GoogleComputeSslCertificateDataSource(string name) : base("google_compute_ssl_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The certificate in PEM format.
    /// The certificate chain must be no greater than 5 certs long.
    /// The chain must include at least one intermediate cert.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Certificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate");

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CertificateId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "certificate_id");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Expire time of the certificate in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpireTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expire_time");

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NamePrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The write-only private key in PEM format.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_key");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
