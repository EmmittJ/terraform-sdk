using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lakeformation_resource Terraform resource.
/// Manages a aws_lakeformation_resource resource.
/// </summary>
public partial class AwsLakeformationResource(string name) : TerraformResource("aws_lakeformation_resource", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HybridAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("hybrid_access_enabled") ?? CreateReference("hybrid_access_enabled");
        set => SetArgument("hybrid_access_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn") ?? CreateReference("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The use_service_linked_role attribute.
    /// </summary>
    public TerraformValue<bool>? UseServiceLinkedRole
    {
        get => GetArgument<TerraformValue<bool>>("use_service_linked_role");
        set => SetArgument("use_service_linked_role", value);
    }

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    public TerraformValue<bool> WithFederation
    {
        get => GetArgument<TerraformValue<bool>>("with_federation") ?? CreateReference("with_federation");
        set => SetArgument("with_federation", value);
    }

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    public TerraformValue<bool> WithPrivilegedAccess
    {
        get => GetArgument<TerraformValue<bool>>("with_privileged_access") ?? CreateReference("with_privileged_access");
        set => SetArgument("with_privileged_access", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => CreateReference("last_modified");

}
