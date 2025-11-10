using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_document.
/// </summary>
public class AwsSsmDocumentDataSource : TerraformDataSource
{
    public AwsSsmDocumentDataSource(string name) : base("aws_ssm_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("content");
        this.DeclareOutput("document_type");
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentFormat
    {
        get => GetProperty<TerraformProperty<string>>("document_format");
        set => this.WithProperty("document_format", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentVersion
    {
        get => GetProperty<TerraformProperty<string>>("document_version");
        set => this.WithProperty("document_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformExpression Content => this["content"];

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    public TerraformExpression DocumentType => this["document_type"];

}
