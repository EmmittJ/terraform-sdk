using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_session_context Terraform data source.
/// Retrieves information about a aws_iam_session_context.
/// </summary>
public partial class AwsIamSessionContextDataSource(string name) : TerraformDataSource("aws_iam_session_context", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The issuer_arn attribute.
    /// </summary>
    public TerraformValue<string> IssuerArn
        => AsReference("issuer_arn");

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    public TerraformValue<string> IssuerId
        => AsReference("issuer_id");

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    public TerraformValue<string> IssuerName
        => AsReference("issuer_name");

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    public TerraformValue<string> SessionName
        => AsReference("session_name");

}
