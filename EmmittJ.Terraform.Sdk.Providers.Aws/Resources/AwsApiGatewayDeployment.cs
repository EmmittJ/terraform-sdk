using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_deployment resource.
/// </summary>
public class AwsApiGatewayDeployment : TerraformResource
{
    public AwsApiGatewayDeployment(string name) : base("aws_api_gateway_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("invoke_url");
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stage_description attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? StageDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_description")?.Value;
        set => this.WithProperty("stage_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name")?.Value;
        set => this.WithProperty("stage_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, string>? Variables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("variables")?.Value;
        set => this.WithProperty("variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    public TerraformExpression InvokeUrl => this["invoke_url"];

}
