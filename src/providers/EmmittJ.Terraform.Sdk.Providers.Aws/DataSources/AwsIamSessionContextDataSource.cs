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
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The issuer_arn attribute.
    /// </summary>
    [TerraformPropertyName("issuer_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IssuerArn => new TerraformReference(this, "issuer_arn");

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    [TerraformPropertyName("issuer_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IssuerId => new TerraformReference(this, "issuer_id");

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    [TerraformPropertyName("issuer_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IssuerName => new TerraformReference(this, "issuer_name");

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    [TerraformPropertyName("session_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SessionName => new TerraformReference(this, "session_name");

}
