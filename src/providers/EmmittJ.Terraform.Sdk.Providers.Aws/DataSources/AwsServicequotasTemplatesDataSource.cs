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
        SetOutput("id");
        SetOutput("templates");
        SetOutput("aws_region");
        SetOutput("region");
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string> AwsRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_region");
        set => SetProperty("aws_region", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
