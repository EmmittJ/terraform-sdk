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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The application_version attribute.
    /// </summary>
    public double? ApplicationVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_version")?.Value;
        set => this.WithProperty("application_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The force_stop attribute.
    /// </summary>
    public bool? ForceStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_stop")?.Value;
        set => this.WithProperty("force_stop", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public bool? Start
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start")?.Value;
        set => this.WithProperty("start", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
