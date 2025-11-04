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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
