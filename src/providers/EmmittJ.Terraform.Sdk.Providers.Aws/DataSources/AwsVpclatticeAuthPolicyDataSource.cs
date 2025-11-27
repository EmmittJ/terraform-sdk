using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpclattice_auth_policy Terraform data source.
/// Retrieves information about a aws_vpclattice_auth_policy.
/// </summary>
public partial class AwsVpclatticeAuthPolicyDataSource(string name) : TerraformDataSource("aws_vpclattice_auth_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceIdentifier is required")]
    public required TerraformValue<string> ResourceIdentifier
    {
        get => new TerraformReference<string>(this, "resource_identifier");
        set => SetArgument("resource_identifier", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}
