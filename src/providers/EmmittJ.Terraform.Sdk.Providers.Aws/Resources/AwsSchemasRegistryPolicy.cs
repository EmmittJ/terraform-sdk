using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_schemas_registry_policy Terraform resource.
/// Manages a aws_schemas_registry_policy resource.
/// </summary>
public partial class AwsSchemasRegistryPolicy(string name) : TerraformResource("aws_schemas_registry_policy", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
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
    /// The registry_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryName is required")]
    public required TerraformValue<string> RegistryName
    {
        get => new TerraformReference<string>(this, "registry_name");
        set => SetArgument("registry_name", value);
    }

}
