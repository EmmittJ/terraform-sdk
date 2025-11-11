using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_user_ssh_key.
/// </summary>
public partial class AwsIamUserSshKeyDataSource : TerraformDataSource
{
    public AwsIamUserSshKeyDataSource(string name) : base("aws_iam_user_ssh_key", name)
    {
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    [TerraformProperty("encoding")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Encoding { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ssh_public_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeyId is required")]
    [TerraformProperty("ssh_public_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SshPublicKeyId { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicKey { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
