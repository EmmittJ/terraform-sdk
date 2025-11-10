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
        this.WithOutput("id");
        this.WithOutput("templates");
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string>? AwsRegion
    {
        get => GetProperty<TerraformProperty<string>>("aws_region");
        set => this.WithProperty("aws_region", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
