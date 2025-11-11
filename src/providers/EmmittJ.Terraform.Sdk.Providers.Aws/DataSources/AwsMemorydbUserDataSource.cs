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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    [TerraformPropertyName("access_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessString => new TerraformReference(this, "access_string");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformPropertyName("authentication_mode")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthenticationMode => new TerraformReference(this, "authentication_mode");

    /// <summary>
    /// The minimum_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MinimumEngineVersion => new TerraformReference(this, "minimum_engine_version");

}
