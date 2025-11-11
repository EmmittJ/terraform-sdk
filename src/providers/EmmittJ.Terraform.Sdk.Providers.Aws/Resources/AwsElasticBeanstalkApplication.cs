using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appversion_lifecycle in .
/// Nesting mode: list
/// </summary>
public partial class AwsElasticBeanstalkApplicationAppversionLifecycleBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete_source_from_s3 attribute.
    /// </summary>
    [TerraformProperty("delete_source_from_s3")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteSourceFromS3 { get; set; }

    /// <summary>
    /// The max_age_in_days attribute.
    /// </summary>
    [TerraformProperty("max_age_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxAgeInDays { get; set; }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    [TerraformProperty("max_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxCount { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformProperty("service_role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceRole { get; set; }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsElasticBeanstalkApplication : TerraformResource
{
    public AwsElasticBeanstalkApplication(string name) : base("aws_elastic_beanstalk_application", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    /// Block for appversion_lifecycle.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppversionLifecycle block(s) allowed")]
    [TerraformProperty("appversion_lifecycle")]
    public TerraformList<TerraformBlock<AwsElasticBeanstalkApplicationAppversionLifecycleBlock>>? AppversionLifecycle { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
