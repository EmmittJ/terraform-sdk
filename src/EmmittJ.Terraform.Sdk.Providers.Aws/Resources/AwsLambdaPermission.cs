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
    public TerraformLiteralProperty<string>? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventSourceToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_source_token");
        set => this.WithProperty("event_source_token", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionUrlAuthType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_url_auth_type");
        set => this.WithProperty("function_url_auth_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal");
        set => this.WithProperty("principal", value);
    }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalOrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_org_id");
        set => this.WithProperty("principal_org_id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
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
    /// The source_account attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_account");
        set => this.WithProperty("source_account", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arn");
        set => this.WithProperty("source_arn", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StatementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id");
        set => this.WithProperty("statement_id", value);
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StatementIdPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id_prefix");
        set => this.WithProperty("statement_id_prefix", value);
    }

}
