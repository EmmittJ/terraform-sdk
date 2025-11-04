using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53profiles_profiles.
/// </summary>
public class AwsRoute53profilesProfilesDataSource : TerraformDataSource
{
    public AwsRoute53profilesProfilesDataSource(string name) : base("aws_route53profiles_profiles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("profiles");
    }

    /// <summary>
    /// The profiles attribute.
    /// </summary>
    public TerraformExpression Profiles => this["profiles"];

}
