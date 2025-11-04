using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_devopsguru_service_integration resource.
/// </summary>
public class AwsDevopsguruServiceIntegration : TerraformResource
{
    public AwsDevopsguruServiceIntegration(string name) : base("aws_devopsguru_service_integration", name)
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
