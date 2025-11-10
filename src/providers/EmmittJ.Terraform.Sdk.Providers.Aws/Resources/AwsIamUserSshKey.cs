using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_user_ssh_key resource.
/// </summary>
public class AwsIamUserSshKey : TerraformResource
{
    public AwsIamUserSshKey(string name) : base("aws_iam_user_ssh_key", name)
    {
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encoding is required")]
    [TerraformPropertyName("encoding")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Encoding { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformPropertyName("public_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PublicKey { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The ssh_public_key_id attribute.
    /// </summary>
    [TerraformPropertyName("ssh_public_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SshPublicKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssh_public_key_id");

}
