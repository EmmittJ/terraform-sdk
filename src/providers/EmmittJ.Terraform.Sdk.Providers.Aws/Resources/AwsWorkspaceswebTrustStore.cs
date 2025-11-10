using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: set
/// </summary>
public class AwsWorkspaceswebTrustStoreCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    [TerraformPropertyName("body")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Body { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Issuer => new TerraformReferenceProperty<TerraformProperty<string>>("", "issuer");

    /// <summary>
    /// The not_valid_after attribute.
    /// </summary>
    [TerraformPropertyName("not_valid_after")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotValidAfter => new TerraformReferenceProperty<TerraformProperty<string>>("", "not_valid_after");

    /// <summary>
    /// The not_valid_before attribute.
    /// </summary>
    [TerraformPropertyName("not_valid_before")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotValidBefore => new TerraformReferenceProperty<TerraformProperty<string>>("", "not_valid_before");

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subject => new TerraformReferenceProperty<TerraformProperty<string>>("", "subject");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>("", "thumbprint");

}

/// <summary>
/// Manages a aws_workspacesweb_trust_store resource.
/// </summary>
public class AwsWorkspaceswebTrustStore : TerraformResource
{
    public AwsWorkspaceswebTrustStore(string name) : base("aws_workspacesweb_trust_store", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("certificate")]
    public TerraformSet<TerraformBlock<AwsWorkspaceswebTrustStoreCertificateBlock>>? Certificate { get; set; } = new();

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformPropertyName("associated_portal_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssociatedPortalArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "associated_portal_arns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformPropertyName("trust_store_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustStoreArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_store_arn");

}
