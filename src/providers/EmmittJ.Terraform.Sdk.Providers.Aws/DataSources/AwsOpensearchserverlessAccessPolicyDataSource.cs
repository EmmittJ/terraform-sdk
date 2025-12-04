using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_opensearchserverless_access_policy Terraform data source.
/// Retrieves information about a aws_opensearchserverless_access_policy.
/// </summary>
public partial class AwsOpensearchserverlessAccessPolicyDataSource(string name) : TerraformDataSource("aws_opensearchserverless_access_policy", name)
{
    /// <summary>
    /// Name of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Type of access policy. Must be `data`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Description of the policy. Typically used to store information about the permissions defined in the policy.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// JSON policy document to use as the content for the new policy.
    /// </summary>
    public TerraformValue<string> Policy
        => AsReference("policy");

    /// <summary>
    /// Version of the policy.
    /// </summary>
    public TerraformValue<string> PolicyVersion
        => AsReference("policy_version");

}
