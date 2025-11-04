using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_emr_supported_instance_types.
/// </summary>
public class AwsEmrSupportedInstanceTypesDataSource : TerraformDataSource
{
    public AwsEmrSupportedInstanceTypesDataSource(string name) : base("aws_emr_supported_instance_types", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("supported_instance_types");
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
    /// The release_label attribute.
    /// </summary>
    public string? ReleaseLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_label")?.Value;
        set => this.WithProperty("release_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The supported_instance_types attribute.
    /// </summary>
    public TerraformExpression SupportedInstanceTypes => this["supported_instance_types"];

}
