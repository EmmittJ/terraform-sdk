using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for allowed_publishers in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaCodeSigningConfigAllowedPublishersBlock : TerraformBlockBase
{
    /// <summary>
    /// The signing_profile_version_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProfileVersionArns is required")]
    [TerraformProperty("signing_profile_version_arns")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SigningProfileVersionArns { get; set; }

}

/// <summary>
/// Block type for policies in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaCodeSigningConfigPoliciesBlock : TerraformBlockBase
{
    /// <summary>
    /// The untrusted_artifact_on_deployment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UntrustedArtifactOnDeployment is required")]
    [TerraformProperty("untrusted_artifact_on_deployment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UntrustedArtifactOnDeployment { get; set; }

}

/// <summary>
/// Manages a aws_lambda_code_signing_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLambdaCodeSigningConfig : TerraformResource
{
    public AwsLambdaCodeSigningConfig(string name) : base("aws_lambda_code_signing_config", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for allowed_publishers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPublishers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedPublishers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedPublishers block(s) allowed")]
    [TerraformProperty("allowed_publishers")]
    public TerraformList<TerraformBlock<AwsLambdaCodeSigningConfigAllowedPublishersBlock>>? AllowedPublishers { get; set; }

    /// <summary>
    /// Block for policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policies block(s) allowed")]
    [TerraformProperty("policies")]
    public TerraformList<TerraformBlock<AwsLambdaCodeSigningConfigPoliciesBlock>>? Policies { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    [TerraformProperty("config_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigId { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

}
