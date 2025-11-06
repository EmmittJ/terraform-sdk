using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codedeploy_deployment_config resource.
/// </summary>
public class AwsCodedeployDeploymentConfig : TerraformResource
{
    public AwsCodedeployDeploymentConfig(string name) : base("aws_codedeploy_deployment_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("deployment_config_id");
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public string? ComputePlatform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_platform")?.Value;
        set => this.WithProperty("compute_platform", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public string? DeploymentConfigName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_config_name")?.Value;
        set => this.WithProperty("deployment_config_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The deployment_config_id attribute.
    /// </summary>
    public TerraformExpression DeploymentConfigId => this["deployment_config_id"];

}
