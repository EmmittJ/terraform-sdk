using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53profiles_profiles.
/// </summary>
public partial class AwsRoute53profilesProfilesDataSource : TerraformDataSource
{
    public AwsRoute53profilesProfilesDataSource(string name) : base("aws_route53profiles_profiles", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The profiles attribute.
    /// </summary>
    [TerraformProperty("profiles")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Profiles { get; }

}
