using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_mode in .
/// Nesting mode: list
/// </summary>
public partial class AwsElasticacheUserDataSourceAuthenticationModeBlock : TerraformBlockBase
{
    /// <summary>
    /// The password_count attribute.
    /// </summary>
    [TerraformProperty("password_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PasswordCount { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Retrieves information about a aws_elasticache_user.
/// </summary>
public partial class AwsElasticacheUserDataSource : TerraformDataSource
{
    public AwsElasticacheUserDataSource(string name) : base("aws_elasticache_user", name)
    {
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    [TerraformProperty("access_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessString { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The no_password_required attribute.
    /// </summary>
    [TerraformProperty("no_password_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NoPasswordRequired { get; set; }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    [TerraformProperty("passwords")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Passwords { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    [TerraformProperty("user_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserId { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserName { get; set; }

    /// <summary>
    /// Block for authentication_mode.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("authentication_mode")]
    public partial TerraformList<TerraformBlock<AwsElasticacheUserDataSourceAuthenticationModeBlock>>? AuthenticationMode { get; set; }

}
