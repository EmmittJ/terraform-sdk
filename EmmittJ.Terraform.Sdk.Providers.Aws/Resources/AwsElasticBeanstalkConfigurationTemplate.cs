using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    }

    /// <summary>
    /// The application attribute.
    /// </summary>
    public string? Application
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application")?.Value;
        set => this.WithProperty("application", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public string? EnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_id")?.Value;
        set => this.WithProperty("environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The solution_stack_name attribute.
    /// </summary>
    public string? SolutionStackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("solution_stack_name")?.Value;
        set => this.WithProperty("solution_stack_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
