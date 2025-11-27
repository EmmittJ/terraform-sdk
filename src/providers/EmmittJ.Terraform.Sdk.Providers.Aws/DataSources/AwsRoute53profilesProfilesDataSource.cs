using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53profiles_profiles Terraform data source.
/// Retrieves information about a aws_route53profiles_profiles.
/// </summary>
public partial class AwsRoute53profilesProfilesDataSource(string name) : TerraformDataSource("aws_route53profiles_profiles", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The profiles attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Profiles
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "profiles").ResolveNodes(ctx));
    }

}
