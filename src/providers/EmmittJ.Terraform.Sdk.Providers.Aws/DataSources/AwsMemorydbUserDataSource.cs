using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_user.
/// </summary>
public class AwsMemorydbUserDataSource : TerraformDataSource
{
    public AwsMemorydbUserDataSource(string name) : base("aws_memorydb_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserName { get; set; }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    [TerraformPropertyName("access_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_string");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("authentication_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthenticationMode => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authentication_mode");

    /// <summary>
    /// The minimum_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinimumEngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "minimum_engine_version");

}
