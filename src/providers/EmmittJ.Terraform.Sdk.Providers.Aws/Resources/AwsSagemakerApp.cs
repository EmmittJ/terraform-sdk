using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_spec in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppResourceSpecBlock : ITerraformBlock
{
    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceType { get; set; }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_config_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LifecycleConfigArn { get; set; }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    [TerraformPropertyName("sagemaker_image_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SagemakerImageArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "sagemaker_image_arn");

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    [TerraformPropertyName("sagemaker_image_version_alias")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SagemakerImageVersionAlias { get; set; }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("sagemaker_image_version_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SagemakerImageVersionArn { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AppName { get; set; }

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppType is required")]
    [TerraformPropertyName("app_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppType { get; set; }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformPropertyName("domain_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainId { get; set; }

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
    /// The space_name attribute.
    /// </summary>
    [TerraformPropertyName("space_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpaceName { get; set; }

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
    /// The user_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("user_profile_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserProfileName { get; set; }

    /// <summary>
    /// Block for resource_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    [TerraformPropertyName("resource_spec")]
    public TerraformList<TerraformBlock<AwsSagemakerAppResourceSpecBlock>>? ResourceSpec { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
