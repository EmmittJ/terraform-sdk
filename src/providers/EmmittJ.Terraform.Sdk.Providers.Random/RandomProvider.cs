using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Random;

/// <summary>
/// Represents the random Terraform provider.
/// Version: ~&gt; 3.0
/// Resources: 8
/// Data Sources: 0
/// </summary>
public partial class RandomProvider(string name = "random") : TerraformProvider(name)
{
}
