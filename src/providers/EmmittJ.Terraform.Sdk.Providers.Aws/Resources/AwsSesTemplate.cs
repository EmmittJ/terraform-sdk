using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_template resource.
/// </summary>
public class AwsSesTemplate : TerraformResource
{
    public AwsSesTemplate(string name) : base("aws_ses_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("html");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("subject");
        SetOutput("text");
    }

    /// <summary>
    /// The html attribute.
    /// </summary>
    public TerraformProperty<string> Html
    {
        get => GetRequiredOutput<TerraformProperty<string>>("html");
        set => SetProperty("html", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string> Subject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subject");
        set => SetProperty("subject", value);
    }

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformProperty<string> Text
    {
        get => GetRequiredOutput<TerraformProperty<string>>("text");
        set => SetProperty("text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
