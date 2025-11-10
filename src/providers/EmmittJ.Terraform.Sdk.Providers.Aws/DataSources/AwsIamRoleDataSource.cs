using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_role.
/// </summary>
public class AwsIamRoleDataSource : TerraformDataSource
{
    public AwsIamRoleDataSource(string name) : base("aws_iam_role", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The assume_role_policy attribute.
    /// </summary>
    [TerraformPropertyName("assume_role_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssumeRolePolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "assume_role_policy");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The max_session_duration attribute.
    /// </summary>
    [TerraformPropertyName("max_session_duration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxSessionDuration => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_session_duration");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The permissions_boundary attribute.
    /// </summary>
    [TerraformPropertyName("permissions_boundary")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PermissionsBoundary => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "permissions_boundary");

    /// <summary>
    /// The role_last_used attribute.
    /// </summary>
    [TerraformPropertyName("role_last_used")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RoleLastUsed => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "role_last_used");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_id");

}
