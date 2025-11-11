using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_random_password.
/// </summary>
public class AwsSecretsmanagerRandomPasswordDataSource : TerraformDataSource
{
    public AwsSecretsmanagerRandomPasswordDataSource(string name) : base("aws_secretsmanager_random_password", name)
    {
    }

    /// <summary>
    /// The exclude_characters attribute.
    /// </summary>
    [TerraformPropertyName("exclude_characters")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExcludeCharacters { get; set; }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    [TerraformPropertyName("exclude_lowercase")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExcludeLowercase { get; set; }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    [TerraformPropertyName("exclude_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExcludeNumbers { get; set; }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    [TerraformPropertyName("exclude_punctuation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExcludePunctuation { get; set; }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    [TerraformPropertyName("exclude_uppercase")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExcludeUppercase { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_space attribute.
    /// </summary>
    [TerraformPropertyName("include_space")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeSpace { get; set; }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    [TerraformPropertyName("password_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PasswordLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The require_each_included_type attribute.
    /// </summary>
    [TerraformPropertyName("require_each_included_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireEachIncludedType { get; set; }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    [TerraformPropertyName("random_password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RandomPassword => new TerraformReference(this, "random_password");

}
