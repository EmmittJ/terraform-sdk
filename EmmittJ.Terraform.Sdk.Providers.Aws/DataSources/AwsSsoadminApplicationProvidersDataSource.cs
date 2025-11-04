using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application_providers.
/// </summary>
public class AwsSsoadminApplicationProvidersDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationProvidersDataSource(string name) : base("aws_ssoadmin_application_providers", name)
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
