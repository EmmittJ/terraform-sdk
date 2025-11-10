using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_service_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The minimum_instance_metadata_service_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_instance_metadata_service_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinimumInstanceMetadataServiceVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "minimum_instance_metadata_service_version");

}

/// <summary>
/// Manages a aws_sagemaker_notebook_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerNotebookInstance : TerraformResource
{
    public AwsSagemakerNotebookInstance(string name) : base("aws_sagemaker_notebook_instance", name)
    {
    }

    /// <summary>
    /// The additional_code_repositories attribute.
    /// </summary>
    [TerraformPropertyName("additional_code_repositories")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AdditionalCodeRepositories { get; set; }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    [TerraformPropertyName("default_code_repository")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultCodeRepository { get; set; }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    [TerraformPropertyName("direct_internet_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DirectInternetAccess { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_config_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LifecycleConfigName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    [TerraformPropertyName("platform_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PlatformIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_identifier");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    [TerraformPropertyName("root_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RootAccess { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

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
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VolumeSize { get; set; }

    /// <summary>
    /// Block for instance_metadata_service_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataServiceConfiguration block(s) allowed")]
    [TerraformPropertyName("instance_metadata_service_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock>>? InstanceMetadataServiceConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkInterfaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_interface_id");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
