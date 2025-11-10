using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_group.
/// </summary>
public class AwsIamGroupDataSource : TerraformDataSource
{
    public AwsIamGroupDataSource(string name) : base("aws_iam_group", name)
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    [TerraformPropertyName("group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [TerraformPropertyName("group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "group_id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The users attribute.
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Users => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "users");

}
