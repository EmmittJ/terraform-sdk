using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicequotas_templates.
/// </summary>
public class AwsServicequotasTemplatesDataSource : TerraformDataSource
{
    public AwsServicequotasTemplatesDataSource(string name) : base("aws_servicequotas_templates", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("templates");
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public string? AwsRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_region")?.Value;
        set => this.WithProperty("aws_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The templates attribute.
    /// </summary>
    public TerraformExpression Templates => this["templates"];

}
