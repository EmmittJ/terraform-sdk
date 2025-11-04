using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securitylake_aws_log_source resource.
/// </summary>
public class AwsSecuritylakeAwsLogSource : TerraformResource
{
    public AwsSecuritylakeAwsLogSource(string name) : base("aws_securitylake_aws_log_source", name)
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
