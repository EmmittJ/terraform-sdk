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
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    /// The issuer_arn attribute.
    /// </summary>
    public TerraformValue<string> IssuerArn
        => CreateReference("issuer_arn");

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    public TerraformValue<string> IssuerId
        => CreateReference("issuer_id");

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    public TerraformValue<string> IssuerName
        => CreateReference("issuer_name");

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    public TerraformValue<string> SessionName
        => CreateReference("session_name");

}
