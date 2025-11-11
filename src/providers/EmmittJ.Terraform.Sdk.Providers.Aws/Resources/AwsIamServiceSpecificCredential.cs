using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_specific_credential resource.
/// </summary>
public partial class AwsIamServiceSpecificCredential : TerraformResource
{
    public AwsIamServiceSpecificCredential(string name) : base("aws_iam_service_specific_credential", name)
    {
    }

    /// <summary>
    /// The credential_age_days attribute.
    /// </summary>
    [TerraformProperty("credential_age_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CredentialAgeDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformProperty("create_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateDate { get; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The service_credential_alias attribute.
    /// </summary>
    [TerraformProperty("service_credential_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceCredentialAlias { get; }

    /// <summary>
    /// The service_credential_secret attribute.
    /// </summary>
    [TerraformProperty("service_credential_secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceCredentialSecret { get; }

    /// <summary>
    /// The service_password attribute.
    /// </summary>
    [TerraformProperty("service_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServicePassword { get; }

    /// <summary>
    /// The service_specific_credential_id attribute.
    /// </summary>
    [TerraformProperty("service_specific_credential_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceSpecificCredentialId { get; }

    /// <summary>
    /// The service_user_name attribute.
    /// </summary>
    [TerraformProperty("service_user_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceUserName { get; }

}
