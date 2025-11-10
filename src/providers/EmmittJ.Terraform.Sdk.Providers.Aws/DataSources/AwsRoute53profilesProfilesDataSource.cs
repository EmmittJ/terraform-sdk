using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53profiles_profiles.
/// </summary>
public class AwsRoute53profilesProfilesDataSource : TerraformDataSource
{
    public AwsRoute53profilesProfilesDataSource(string name) : base("aws_route53profiles_profiles", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The profiles attribute.
    /// </summary>
    [TerraformPropertyName("profiles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Profiles => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "profiles");

}
