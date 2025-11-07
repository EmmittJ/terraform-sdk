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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_arn");
        set => this.WithProperty("service_arn", value);
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
