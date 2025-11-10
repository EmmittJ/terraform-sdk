using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_session_context.
/// </summary>
public class AwsIamSessionContextDataSource : TerraformDataSource
{
    public AwsIamSessionContextDataSource(string name) : base("aws_iam_session_context", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The issuer_arn attribute.
    /// </summary>
    [TerraformPropertyName("issuer_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IssuerArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issuer_arn");

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    [TerraformPropertyName("issuer_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IssuerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issuer_id");

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    [TerraformPropertyName("issuer_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IssuerName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issuer_name");

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    [TerraformPropertyName("session_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SessionName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "session_name");

}
