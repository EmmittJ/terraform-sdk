using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_mode in .
/// Nesting mode: list
/// </summary>
public class AwsElasticacheUserDataSourceAuthenticationModeBlock
{
    /// <summary>
    /// The password_count attribute.
    /// </summary>
    [TerraformPropertyName("password_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PasswordCount { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Retrieves information about a aws_elasticache_user.
/// </summary>
public class AwsElasticacheUserDataSource : TerraformDataSource
{
    public AwsElasticacheUserDataSource(string name) : base("aws_elasticache_user", name)
    {
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    [TerraformPropertyName("access_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessString { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The no_password_required attribute.
    /// </summary>
    [TerraformPropertyName("no_password_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NoPasswordRequired { get; set; }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    [TerraformPropertyName("passwords")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Passwords { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    [TerraformPropertyName("user_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserId { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserName { get; set; }

    /// <summary>
    /// Block for authentication_mode.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("authentication_mode")]
    public TerraformList<TerraformBlock<AwsElasticacheUserDataSourceAuthenticationModeBlock>>? AuthenticationMode { get; set; }

}
