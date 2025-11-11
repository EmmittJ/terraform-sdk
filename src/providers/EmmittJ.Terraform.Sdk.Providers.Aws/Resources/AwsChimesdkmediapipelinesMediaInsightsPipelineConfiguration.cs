using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elements in .
/// Nesting mode: list
/// </summary>
public partial class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for real_time_alert_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Disabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_chimesdkmediapipelines_media_insights_pipeline_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration : TerraformResource
{
    public AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration(string name) : base("aws_chimesdkmediapipelines_media_insights_pipeline_configuration", name)
    {
    }

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
    /// The resource_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAccessRoleArn is required")]
    [TerraformProperty("resource_access_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceAccessRoleArn { get; set; }

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
    /// Block for elements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Elements is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Elements block(s) required")]
    [TerraformProperty("elements")]
    public TerraformList<TerraformBlock<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock>>? Elements { get; set; }

    /// <summary>
    /// Block for real_time_alert_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RealTimeAlertConfiguration block(s) allowed")]
    [TerraformProperty("real_time_alert_configuration")]
    public TerraformList<TerraformBlock<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock>>? RealTimeAlertConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
