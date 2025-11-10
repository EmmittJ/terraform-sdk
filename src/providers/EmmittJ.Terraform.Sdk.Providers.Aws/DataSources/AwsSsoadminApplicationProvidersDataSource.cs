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
        SetOutput("application_providers");
        SetOutput("id");
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
    /// The application_providers attribute.
    /// </summary>
    public TerraformExpression ApplicationProviders => this["application_providers"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
