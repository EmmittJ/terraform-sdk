using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_account_suppression_attributes resource.
/// </summary>
public class AwsSesv2AccountSuppressionAttributes : TerraformResource
{
    public AwsSesv2AccountSuppressionAttributes(string name) : base("aws_sesv2_account_suppression_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    public HashSet<string>? SuppressedReasons
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("suppressed_reasons")?.Value;
        set => this.WithProperty("suppressed_reasons", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
