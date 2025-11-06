using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents the aws Terraform provider.
/// Version: ~&gt; 6.0
/// </summary>
public class AwsProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AwsProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "aws".</param>
    public AwsProvider(string name = "aws") : base(name)
    {
    }
}
