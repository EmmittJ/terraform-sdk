using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_default_auto_scaling_configuration_version resource.
/// </summary>
public class AwsApprunnerDefaultAutoScalingConfigurationVersion : TerraformResource
{
    public AwsApprunnerDefaultAutoScalingConfigurationVersion(string name) : base("aws_apprunner_default_auto_scaling_configuration_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The auto_scaling_configuration_arn attribute.
    /// </summary>
    public string? AutoScalingConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_scaling_configuration_arn")?.Value;
        set => this.WithProperty("auto_scaling_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
