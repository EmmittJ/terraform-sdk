using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_deployment resource.
/// </summary>
public class AwsApprunnerDeployment : TerraformResource
{
    public AwsApprunnerDeployment(string name) : base("aws_apprunner_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("operation_id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public string? ServiceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_arn")?.Value;
        set => this.WithProperty("service_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The operation_id attribute.
    /// </summary>
    public TerraformExpression OperationId => this["operation_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
