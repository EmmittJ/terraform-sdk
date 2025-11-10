using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_session_context.
/// </summary>
public class AwsIamSessionContextDataSource : TerraformDataSource
{
    public AwsIamSessionContextDataSource(string name) : base("aws_iam_session_context", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("issuer_arn");
        SetOutput("issuer_id");
        SetOutput("issuer_name");
        SetOutput("session_name");
        SetOutput("arn");
        SetOutput("id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// The issuer_arn attribute.
    /// </summary>
    public TerraformExpression IssuerArn => this["issuer_arn"];

    /// <summary>
    /// The issuer_id attribute.
    /// </summary>
    public TerraformExpression IssuerId => this["issuer_id"];

    /// <summary>
    /// The issuer_name attribute.
    /// </summary>
    public TerraformExpression IssuerName => this["issuer_name"];

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    public TerraformExpression SessionName => this["session_name"];

}
