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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformPropertyName("user")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> User { get; set; }

    /// <summary>
    /// The access_keys attribute.
    /// </summary>
    [TerraformPropertyName("access_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> AccessKeys => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "access_keys");

}
