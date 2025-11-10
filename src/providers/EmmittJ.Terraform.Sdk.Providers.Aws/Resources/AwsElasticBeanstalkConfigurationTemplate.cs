using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkConfigurationTemplateSettingBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformPropertyName("namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Namespace { get; set; }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Resource { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_configuration_template resource.
/// </summary>
public class AwsElasticBeanstalkConfigurationTemplate : TerraformResource
{
    public AwsElasticBeanstalkConfigurationTemplate(string name) : base("aws_elastic_beanstalk_configuration_template", name)
    {
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    [TerraformPropertyName("application")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Application { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [TerraformPropertyName("environment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    [TerraformPropertyName("solution_stack_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SolutionStackName { get; set; }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("setting")]
    public TerraformSet<TerraformBlock<AwsElasticBeanstalkConfigurationTemplateSettingBlock>>? Setting { get; set; } = new();

}
