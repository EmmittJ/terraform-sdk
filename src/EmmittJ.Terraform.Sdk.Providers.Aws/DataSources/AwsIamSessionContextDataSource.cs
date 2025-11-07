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
        this.DeclareOutput("issuer_arn");
        this.DeclareOutput("issuer_id");
        this.DeclareOutput("issuer_name");
        this.DeclareOutput("session_name");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
