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
        SetOutput("profiles");
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
    /// The profiles attribute.
    /// </summary>
    public TerraformExpression Profiles => this["profiles"];

}
