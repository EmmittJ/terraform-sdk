using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_synthetics_runtime_versions.
/// </summary>
public class AwsSyntheticsRuntimeVersionsDataSource : TerraformDataSource
{
    public AwsSyntheticsRuntimeVersionsDataSource(string name) : base("aws_synthetics_runtime_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("runtime_versions");
        SetOutput("region");
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The runtime_versions attribute.
    /// </summary>
    public TerraformExpression RuntimeVersions => this["runtime_versions"];

}
