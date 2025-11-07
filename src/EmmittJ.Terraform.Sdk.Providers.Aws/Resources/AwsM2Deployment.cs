using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_m2_deployment resource.
/// </summary>
public class AwsM2Deployment : TerraformResource
{
    public AwsM2Deployment(string name) : base("aws_m2_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("deployment_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The application_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ApplicationVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_version");
        set => this.WithProperty("application_version", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
    }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_stop");
        set => this.WithProperty("force_stop", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Start
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start");
        set => this.WithProperty("start", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformExpression DeploymentId => this["deployment_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
