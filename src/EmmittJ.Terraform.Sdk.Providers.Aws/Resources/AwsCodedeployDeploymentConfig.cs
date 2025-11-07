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
    public TerraformProperty<string>? ComputePlatform
    {
        get => GetProperty<TerraformProperty<string>>("compute_platform");
        set => this.WithProperty("compute_platform", value);
    }

    /// <summary>
    /// The deployment_config_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentConfigName
    {
        get => GetProperty<TerraformProperty<string>>("deployment_config_name");
        set => this.WithProperty("deployment_config_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
