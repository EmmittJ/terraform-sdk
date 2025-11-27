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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The issuer_arn attribute.
    /// </summary>
    public TerraformValue<string> IssuerArn
    {
        get => new TerraformReference<string>(this, "issuer_arn");
    }

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    public TerraformValue<string> IssuerId
    {
        get => new TerraformReference<string>(this, "issuer_id");
    }

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    public TerraformValue<string> IssuerName
    {
        get => new TerraformReference<string>(this, "issuer_name");
    }

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    public TerraformValue<string> SessionName
    {
        get => new TerraformReference<string>(this, "session_name");
    }

}
