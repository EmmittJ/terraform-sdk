using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_stage resource.
/// </summary>
public class AwsApigatewayv2Stage : TerraformResource
{
    public AwsApigatewayv2Stage(string name) : base("aws_apigatewayv2_stage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("invoke_url");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The auto_deploy attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoDeploy
    {
        get => GetProperty<TerraformProperty<bool>>("auto_deploy");
        set => this.WithProperty("auto_deploy", value);
    }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_id");
        set => this.WithProperty("client_certificate_id", value);
    }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("deployment_id");
        set => this.WithProperty("deployment_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The stage_variables attribute.
    /// </summary>
    public TerraformMapProperty<string>? StageVariables
    {
        get => GetProperty<TerraformMapProperty<string>>("stage_variables");
        set => this.WithProperty("stage_variables", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    public TerraformExpression InvokeUrl => this["invoke_url"];

}
