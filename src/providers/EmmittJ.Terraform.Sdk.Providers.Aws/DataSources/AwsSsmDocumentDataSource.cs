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
        SetOutput("arn");
        SetOutput("content");
        SetOutput("document_type");
        SetOutput("document_format");
        SetOutput("document_version");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformProperty<string> DocumentFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_format");
        set => SetProperty("document_format", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformProperty<string> DocumentVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_version");
        set => SetProperty("document_version", value);
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
