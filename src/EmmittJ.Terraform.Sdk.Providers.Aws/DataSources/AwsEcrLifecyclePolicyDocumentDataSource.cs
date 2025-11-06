using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_lifecycle_policy_document.
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSource : TerraformDataSource
{
    public AwsEcrLifecyclePolicyDocumentDataSource(string name) : base("aws_ecr_lifecycle_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("json");
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
