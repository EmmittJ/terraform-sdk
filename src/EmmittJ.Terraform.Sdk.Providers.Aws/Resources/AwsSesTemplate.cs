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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The html attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Html
    {
        get => GetProperty<TerraformLiteralProperty<string>>("html");
        set => this.WithProperty("html", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Subject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subject");
        set => this.WithProperty("subject", value);
    }

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Text
    {
        get => GetProperty<TerraformLiteralProperty<string>>("text");
        set => this.WithProperty("text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
