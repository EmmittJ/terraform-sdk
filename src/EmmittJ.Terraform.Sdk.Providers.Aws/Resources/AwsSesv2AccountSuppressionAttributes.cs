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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SuppressedReasons
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("suppressed_reasons");
        set => this.WithProperty("suppressed_reasons", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
