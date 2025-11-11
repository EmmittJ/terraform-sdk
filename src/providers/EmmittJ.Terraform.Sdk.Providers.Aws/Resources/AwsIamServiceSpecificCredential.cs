using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_specific_credential resource.
/// </summary>
public class AwsIamServiceSpecificCredential : TerraformResource
{
    public AwsIamServiceSpecificCredential(string name) : base("aws_iam_service_specific_credential", name)
    {
    }

    /// <summary>
    /// The credential_age_days attribute.
    /// </summary>
    [TerraformPropertyName("credential_age_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CredentialAgeDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformPropertyName("service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateDate => new TerraformReference(this, "create_date");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationDate => new TerraformReference(this, "expiration_date");

    /// <summary>
    /// The service_credential_alias attribute.
    /// </summary>
    [TerraformPropertyName("service_credential_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceCredentialAlias => new TerraformReference(this, "service_credential_alias");

    /// <summary>
    /// The service_credential_secret attribute.
    /// </summary>
    [TerraformPropertyName("service_credential_secret")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceCredentialSecret => new TerraformReference(this, "service_credential_secret");

    /// <summary>
    /// The service_password attribute.
    /// </summary>
    [TerraformPropertyName("service_password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServicePassword => new TerraformReference(this, "service_password");

    /// <summary>
    /// The service_specific_credential_id attribute.
    /// </summary>
    [TerraformPropertyName("service_specific_credential_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceSpecificCredentialId => new TerraformReference(this, "service_specific_credential_id");

    /// <summary>
    /// The service_user_name attribute.
    /// </summary>
    [TerraformPropertyName("service_user_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceUserName => new TerraformReference(this, "service_user_name");

}
