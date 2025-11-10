using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for allowed_publishers in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigAllowedPublishersBlock : ITerraformBlock
{
    /// <summary>
    /// The signing_profile_version_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProfileVersionArns is required")]
    [TerraformPropertyName("signing_profile_version_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SigningProfileVersionArns { get; set; }

}

/// <summary>
/// Block type for policies in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigPoliciesBlock : ITerraformBlock
{
    /// <summary>
    /// The untrusted_artifact_on_deployment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UntrustedArtifactOnDeployment is required")]
    [TerraformPropertyName("untrusted_artifact_on_deployment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UntrustedArtifactOnDeployment { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for allowed_publishers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPublishers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedPublishers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedPublishers block(s) allowed")]
    [TerraformPropertyName("allowed_publishers")]
    public TerraformList<TerraformBlock<AwsLambdaCodeSigningConfigAllowedPublishersBlock>>? AllowedPublishers { get; set; } = new();

    /// <summary>
    /// Block for policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policies block(s) allowed")]
    [TerraformPropertyName("policies")]
    public TerraformList<TerraformBlock<AwsLambdaCodeSigningConfigPoliciesBlock>>? Policies { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    [TerraformPropertyName("config_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

}
