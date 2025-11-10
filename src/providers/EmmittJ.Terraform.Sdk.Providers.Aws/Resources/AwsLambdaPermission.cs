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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    public TerraformProperty<string>? EventSourceToken
    {
        get => GetProperty<TerraformProperty<string>>("event_source_token");
        set => this.WithProperty("event_source_token", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    public TerraformProperty<string>? FunctionUrlAuthType
    {
        get => GetProperty<TerraformProperty<string>>("function_url_auth_type");
        set => this.WithProperty("function_url_auth_type", value);
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
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredProperty<TerraformProperty<string>>("principal");
        set => this.WithProperty("principal", value);
    }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalOrgId
    {
        get => GetProperty<TerraformProperty<string>>("principal_org_id");
        set => this.WithProperty("principal_org_id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string>? Qualifier
    {
        get => GetProperty<TerraformProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
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
    /// The source_account attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAccount
    {
        get => GetProperty<TerraformProperty<string>>("source_account");
        set => this.WithProperty("source_account", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceArn
    {
        get => GetProperty<TerraformProperty<string>>("source_arn");
        set => this.WithProperty("source_arn", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public TerraformProperty<string>? StatementId
    {
        get => GetProperty<TerraformProperty<string>>("statement_id");
        set => this.WithProperty("statement_id", value);
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? StatementIdPrefix
    {
        get => GetProperty<TerraformProperty<string>>("statement_id_prefix");
        set => this.WithProperty("statement_id_prefix", value);
    }

}
