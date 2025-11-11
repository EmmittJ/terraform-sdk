using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_random_password ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class AwsSecretsmanagerRandomPasswordEphemeralResource : TerraformEphemeralResource
{
    public AwsSecretsmanagerRandomPasswordEphemeralResource(string name) : base("aws_secretsmanager_random_password", name)
    {
    }

    /// <summary>
    /// The exclude_characters attribute.
    /// </summary>
    [TerraformProperty("exclude_characters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExcludeCharacters { get; set; }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    [TerraformProperty("exclude_lowercase")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeLowercase { get; set; }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    [TerraformProperty("exclude_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeNumbers { get; set; }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    [TerraformProperty("exclude_punctuation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludePunctuation { get; set; }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    [TerraformProperty("exclude_uppercase")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludeUppercase { get; set; }

    /// <summary>
    /// The include_space attribute.
    /// </summary>
    [TerraformProperty("include_space")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeSpace { get; set; }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    [TerraformProperty("password_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PasswordLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The require_each_included_type attribute.
    /// </summary>
    [TerraformProperty("require_each_included_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireEachIncludedType { get; set; }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    [TerraformProperty("random_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RandomPassword { get; }

}
