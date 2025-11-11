using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_service_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The minimum_instance_metadata_service_version attribute.
    /// </summary>
    [TerraformProperty("minimum_instance_metadata_service_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinimumInstanceMetadataServiceVersion { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_notebook_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerNotebookInstance : TerraformResource
{
    public AwsSagemakerNotebookInstance(string name) : base("aws_sagemaker_notebook_instance", name)
    {
    }

    /// <summary>
    /// The additional_code_repositories attribute.
    /// </summary>
    [TerraformProperty("additional_code_repositories")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AdditionalCodeRepositories { get; set; }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    [TerraformProperty("default_code_repository")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultCodeRepository { get; set; }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    [TerraformProperty("direct_internet_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectInternetAccess { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    [TerraformProperty("lifecycle_config_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LifecycleConfigName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    [TerraformProperty("platform_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PlatformIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    [TerraformProperty("root_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RootAccess { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VolumeSize { get; set; }

    /// <summary>
    /// Block for instance_metadata_service_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataServiceConfiguration block(s) allowed")]
    [TerraformProperty("instance_metadata_service_configuration")]
    public partial TerraformList<TerraformBlock<AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock>>? InstanceMetadataServiceConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkInterfaceId { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
