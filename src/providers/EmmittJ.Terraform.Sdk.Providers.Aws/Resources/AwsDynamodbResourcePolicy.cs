using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dynamodb_resource_policy Terraform resource.
/// Manages a aws_dynamodb_resource_policy resource.
/// </summary>
public partial class AwsDynamodbResourcePolicy(string name) : TerraformResource("aws_dynamodb_resource_policy", name)
{
    /// <summary>
    /// The confirm_remove_self_resource_access attribute.
    /// </summary>
    public TerraformValue<bool> ConfirmRemoveSelfResourceAccess
    {
        get => GetArgument<TerraformValue<bool>>("confirm_remove_self_resource_access") ?? AsReference("confirm_remove_self_resource_access");
        set => SetArgument("confirm_remove_self_resource_access", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    public TerraformValue<string> RevisionId
        => AsReference("revision_id");

}
