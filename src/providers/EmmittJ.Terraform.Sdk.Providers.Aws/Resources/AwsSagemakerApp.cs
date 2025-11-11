using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_spec in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppResourceSpecBlock
{
    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LifecycleConfigArn { get; set; }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    [TerraformPropertyName("sagemaker_image_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SagemakerImageArn { get; set; } = default!;

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    [TerraformPropertyName("sagemaker_image_version_alias")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SagemakerImageVersionAlias { get; set; }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("sagemaker_image_version_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SagemakerImageVersionArn { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerApp : TerraformResource
{
    public AwsSagemakerApp(string name) : base("aws_sagemaker_app", name)
    {
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformPropertyName("app_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppName { get; set; }

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppType is required")]
    [TerraformPropertyName("app_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppType { get; set; }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformPropertyName("domain_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainId { get; set; }

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
    /// The space_name attribute.
    /// </summary>
    [TerraformPropertyName("space_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SpaceName { get; set; }

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
    /// The user_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("user_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserProfileName { get; set; }

    /// <summary>
    /// Block for resource_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    [TerraformPropertyName("resource_spec")]
    public TerraformList<TerraformBlock<AwsSagemakerAppResourceSpecBlock>>? ResourceSpec { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
