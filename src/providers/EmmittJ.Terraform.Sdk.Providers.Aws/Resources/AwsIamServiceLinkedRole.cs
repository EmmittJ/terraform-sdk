using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_service_linked_role resource.
/// </summary>
public class AwsIamServiceLinkedRole : TerraformResource
{
    public AwsIamServiceLinkedRole(string name) : base("aws_iam_service_linked_role", name)
    {
    }

    /// <summary>
    /// The aws_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsServiceName is required")]
    [TerraformPropertyName("aws_service_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AwsServiceName { get; set; }

    /// <summary>
    /// The custom_suffix attribute.
    /// </summary>
    [TerraformPropertyName("custom_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomSuffix { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    [TerraformPropertyName("create_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_date");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_id");

}
