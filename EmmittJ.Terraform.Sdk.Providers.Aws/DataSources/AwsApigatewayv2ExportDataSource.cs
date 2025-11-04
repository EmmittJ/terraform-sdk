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
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    public string? ExportVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export_version")?.Value;
        set => this.WithProperty("export_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The include_extensions attribute.
    /// </summary>
    public bool? IncludeExtensions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_extensions")?.Value;
        set => this.WithProperty("include_extensions", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    public string? OutputType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_type")?.Value;
        set => this.WithProperty("output_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The specification attribute.
    /// </summary>
    public string? Specification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("specification")?.Value;
        set => this.WithProperty("specification", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public string? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name")?.Value;
        set => this.WithProperty("stage_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

}
