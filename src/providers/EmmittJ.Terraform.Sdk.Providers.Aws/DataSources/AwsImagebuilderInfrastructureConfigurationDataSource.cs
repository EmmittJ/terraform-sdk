using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_infrastructure_configuration.
/// </summary>
public partial class AwsImagebuilderInfrastructureConfigurationDataSource : TerraformDataSource
{
    public AwsImagebuilderInfrastructureConfigurationDataSource(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ResourceTags { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    [TerraformProperty("date_updated")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateUpdated { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    [TerraformProperty("instance_metadata_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InstanceMetadataOptions { get; }

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [TerraformProperty("instance_profile_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceProfileName { get; }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    [TerraformProperty("instance_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> InstanceTypes { get; }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    [TerraformProperty("key_pair")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyPair { get; }

    /// <summary>
    /// The logging attribute.
    /// </summary>
    [TerraformProperty("logging")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Logging { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    [TerraformProperty("placement")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Placement { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroupIds { get; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnsTopicArn { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    [TerraformProperty("terminate_instance_on_failure")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TerminateInstanceOnFailure { get; }

}
