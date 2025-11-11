using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for allowed_publishers in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigAllowedPublishersBlock
{
    /// <summary>
    /// The signing_profile_version_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProfileVersionArns is required")]
    [TerraformPropertyName("signing_profile_version_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SigningProfileVersionArns { get; set; }

}

/// <summary>
/// Block type for policies in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigPoliciesBlock
{
    /// <summary>
    /// The untrusted_artifact_on_deployment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UntrustedArtifactOnDeployment is required")]
    [TerraformPropertyName("untrusted_artifact_on_deployment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UntrustedArtifactOnDeployment { get; set; }

}

/// <summary>
/// Manages a aws_lambda_code_signing_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaCodeSigningConfig : TerraformResource
{
    public AwsLambdaCodeSigningConfig(string name) : base("aws_lambda_code_signing_config", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for allowed_publishers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPublishers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedPublishers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedPublishers block(s) allowed")]
    [TerraformPropertyName("allowed_publishers")]
    public TerraformList<TerraformBlock<AwsLambdaCodeSigningConfigAllowedPublishersBlock>>? AllowedPublishers { get; set; }

    /// <summary>
    /// Block for policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policies block(s) allowed")]
    [TerraformPropertyName("policies")]
    public TerraformList<TerraformBlock<AwsLambdaCodeSigningConfigPoliciesBlock>>? Policies { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    [TerraformPropertyName("config_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigId => new TerraformReference(this, "config_id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

}
