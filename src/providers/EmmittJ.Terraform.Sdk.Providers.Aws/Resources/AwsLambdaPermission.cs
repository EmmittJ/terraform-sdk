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
        SetOutput("action");
        SetOutput("event_source_token");
        SetOutput("function_name");
        SetOutput("function_url_auth_type");
        SetOutput("id");
        SetOutput("principal");
        SetOutput("principal_org_id");
        SetOutput("qualifier");
        SetOutput("region");
        SetOutput("source_account");
        SetOutput("source_arn");
        SetOutput("statement_id");
        SetOutput("statement_id_prefix");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    public TerraformProperty<string> EventSourceToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_source_token");
        set => SetProperty("event_source_token", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
    }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    public TerraformProperty<string> FunctionUrlAuthType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_url_auth_type");
        set => SetProperty("function_url_auth_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal");
        set => SetProperty("principal", value);
    }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    public TerraformProperty<string> PrincipalOrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_org_id");
        set => SetProperty("principal_org_id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string> Qualifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qualifier");
        set => SetProperty("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    public TerraformProperty<string> SourceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_account");
        set => SetProperty("source_account", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformProperty<string> SourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_arn");
        set => SetProperty("source_arn", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public TerraformProperty<string> StatementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement_id");
        set => SetProperty("statement_id", value);
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public TerraformProperty<string> StatementIdPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statement_id_prefix");
        set => SetProperty("statement_id_prefix", value);
    }

}
