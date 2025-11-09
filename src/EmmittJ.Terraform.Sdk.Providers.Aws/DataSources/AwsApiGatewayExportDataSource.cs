using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_export.
/// </summary>
public class AwsApiGatewayExportDataSource : TerraformDataSource
{
    public AwsApiGatewayExportDataSource(string name) : base("aws_api_gateway_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("body");
        this.DeclareOutput("content_disposition");
        this.DeclareOutput("content_type");
    }

    /// <summary>
    /// The accepts attribute.
    /// </summary>
    public TerraformProperty<string>? Accepts
    {
        get => GetProperty<TerraformProperty<string>>("accepts");
        set => this.WithProperty("accepts", value);
    }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    public TerraformProperty<string>? ExportType
    {
        get => GetProperty<TerraformProperty<string>>("export_type");
        set => this.WithProperty("export_type", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    public TerraformProperty<string>? StageName
    {
        get => GetProperty<TerraformProperty<string>>("stage_name");
        set => this.WithProperty("stage_name", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformExpression ContentDisposition => this["content_disposition"];

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

}
