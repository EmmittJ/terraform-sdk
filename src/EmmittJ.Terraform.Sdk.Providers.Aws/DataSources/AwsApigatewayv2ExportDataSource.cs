using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_export.
/// </summary>
public class AwsApigatewayv2ExportDataSource : TerraformDataSource
{
    public AwsApigatewayv2ExportDataSource(string name) : base("aws_apigatewayv2_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("body");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExportVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_version");
        set => this.WithProperty("export_version", value);
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
    /// The include_extensions attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeExtensions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_extensions");
        set => this.WithProperty("include_extensions", value);
    }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OutputType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_type");
        set => this.WithProperty("output_type", value);
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
    /// The specification attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Specification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("specification");
        set => this.WithProperty("specification", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

}
