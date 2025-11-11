using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsIamServerCertificateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_iam_server_certificate resource.
/// </summary>
public partial class AwsIamServerCertificate : TerraformResource
{
    public AwsIamServerCertificate(string name) : base("aws_iam_server_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBody is required")]
    [TerraformProperty("certificate_body")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateBody { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateChain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    [TerraformProperty("private_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrivateKey { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsIamServerCertificateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Expiration { get; }

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    [TerraformProperty("upload_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UploadDate { get; }

}
