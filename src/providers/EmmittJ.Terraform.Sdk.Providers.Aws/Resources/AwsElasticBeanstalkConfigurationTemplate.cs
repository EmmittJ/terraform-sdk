using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for setting in .
/// Nesting mode: set
/// </summary>
public class AwsElasticBeanstalkConfigurationTemplateSettingBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformProperty<string>? Resource
    {
        set => SetProperty("resource", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_elastic_beanstalk_configuration_template resource.
/// </summary>
public class AwsElasticBeanstalkConfigurationTemplate : TerraformResource
{
    public AwsElasticBeanstalkConfigurationTemplate(string name) : base("aws_elastic_beanstalk_configuration_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application");
        SetOutput("description");
        SetOutput("environment_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("solution_stack_name");
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Application is required")]
    public required TerraformProperty<string> Application
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application");
        set => SetProperty("application", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformProperty<string> EnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_id");
        set => SetProperty("environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    public TerraformProperty<string> SolutionStackName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("solution_stack_name");
        set => SetProperty("solution_stack_name", value);
    }

    /// <summary>
    /// Block for setting.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElasticBeanstalkConfigurationTemplateSettingBlock>? Setting
    {
        set => SetProperty("setting", value);
    }

}
