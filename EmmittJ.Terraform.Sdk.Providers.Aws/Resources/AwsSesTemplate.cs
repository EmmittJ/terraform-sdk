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
    public string? Html
    {
        get => GetProperty<TerraformLiteralProperty<string>>("html")?.Value;
        set => this.WithProperty("html", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public string? Subject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subject")?.Value;
        set => this.WithProperty("subject", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The text attribute.
    /// </summary>
    public string? Text
    {
        get => GetProperty<TerraformLiteralProperty<string>>("text")?.Value;
        set => this.WithProperty("text", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
