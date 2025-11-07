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
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseLabel
    {
        get => GetProperty<TerraformProperty<string>>("release_label");
        set => this.WithProperty("release_label", value);
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
