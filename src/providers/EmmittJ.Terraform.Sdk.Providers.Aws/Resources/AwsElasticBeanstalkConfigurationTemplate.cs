using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public partial class AwsElasticBeanstalkConfigurationTemplateSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformProperty("resource")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Resource { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_configuration_template resource.
/// </summary>
public partial class AwsElasticBeanstalkConfigurationTemplate : TerraformResource
{
    public AwsElasticBeanstalkConfigurationTemplate(string name) : base("aws_elastic_beanstalk_configuration_template", name)
    {
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    [TerraformProperty("application")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Application { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [TerraformProperty("environment_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    [TerraformProperty("solution_stack_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SolutionStackName { get; set; }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("setting")]
    public partial TerraformSet<TerraformBlock<AwsElasticBeanstalkConfigurationTemplateSettingBlock>>? Setting { get; set; }

}
