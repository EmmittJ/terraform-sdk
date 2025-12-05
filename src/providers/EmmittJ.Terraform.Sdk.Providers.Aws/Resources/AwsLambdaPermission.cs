using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_permission Terraform resource.
/// Manages a aws_lambda_permission resource.
/// </summary>
public partial class AwsLambdaPermission(string name) : TerraformResource("aws_lambda_permission", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    public TerraformValue<string>? EventSourceToken
    {
        get => GetArgument<TerraformValue<string>>("event_source_token");
        set => SetArgument("event_source_token", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    public TerraformValue<string>? FunctionUrlAuthType
    {
        get => GetArgument<TerraformValue<string>>("function_url_auth_type");
        set => SetArgument("function_url_auth_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalOrgId
    {
        get => GetArgument<TerraformValue<string>>("principal_org_id");
        set => SetArgument("principal_org_id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => GetArgument<TerraformValue<string>>("qualifier");
        set => SetArgument("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    public TerraformValue<string>? SourceAccount
    {
        get => GetArgument<TerraformValue<string>>("source_account");
        set => SetArgument("source_account", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceArn
    {
        get => GetArgument<TerraformValue<string>>("source_arn");
        set => SetArgument("source_arn", value);
    }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    public TerraformValue<string> StatementId
    {
        get => GetArgument<TerraformValue<string>>("statement_id") ?? CreateReference("statement_id");
        set => SetArgument("statement_id", value);
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public TerraformValue<string> StatementIdPrefix
    {
        get => GetArgument<TerraformValue<string>>("statement_id_prefix") ?? CreateReference("statement_id_prefix");
        set => SetArgument("statement_id_prefix", value);
    }

}
