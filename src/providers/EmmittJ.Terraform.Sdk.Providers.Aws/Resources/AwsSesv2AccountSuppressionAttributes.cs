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
        SetOutput("id");
        SetOutput("region");
        SetOutput("suppressed_reasons");
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
    /// The suppressed_reasons attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SuppressedReasons is required")]
    public HashSet<TerraformProperty<string>> SuppressedReasons
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("suppressed_reasons");
        set => SetProperty("suppressed_reasons", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
