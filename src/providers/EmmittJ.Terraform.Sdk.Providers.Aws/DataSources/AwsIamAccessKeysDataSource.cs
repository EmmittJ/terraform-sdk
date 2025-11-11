using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_access_keys.
/// </summary>
public class AwsIamAccessKeysDataSource : TerraformDataSource
{
    public AwsIamAccessKeysDataSource(string name) : base("aws_iam_access_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformPropertyName("user")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> User { get; set; }

    /// <summary>
    /// The access_keys attribute.
    /// </summary>
    [TerraformPropertyName("access_keys")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> AccessKeys => new TerraformReference(this, "access_keys");

}
