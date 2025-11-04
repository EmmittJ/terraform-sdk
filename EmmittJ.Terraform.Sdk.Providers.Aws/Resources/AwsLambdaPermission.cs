using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_permission resource.
/// </summary>
public class AwsLambdaPermission : TerraformResource
{
    public AwsLambdaPermission(string name) : base("aws_lambda_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    public string? EventSourceToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_source_token")?.Value;
        set => this.WithProperty("event_source_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    public string? FunctionUrlAuthType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_url_auth_type")?.Value;
        set => this.WithProperty("function_url_auth_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    public string? PrincipalOrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_org_id")?.Value;
        set => this.WithProperty("principal_org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public string? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier")?.Value;
        set => this.WithProperty("qualifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The source_account attribute.
    /// </summary>
    public string? SourceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_account")?.Value;
        set => this.WithProperty("source_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public string? SourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arn")?.Value;
        set => this.WithProperty("source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public string? StatementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id")?.Value;
        set => this.WithProperty("statement_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public string? StatementIdPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id_prefix")?.Value;
        set => this.WithProperty("statement_id_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
