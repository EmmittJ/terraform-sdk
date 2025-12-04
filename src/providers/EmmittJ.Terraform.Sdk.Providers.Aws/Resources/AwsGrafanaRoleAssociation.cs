using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsGrafanaRoleAssociation.
/// Nesting mode: single
/// </summary>
public class AwsGrafanaRoleAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_grafana_role_association Terraform resource.
/// Manages a aws_grafana_role_association resource.
/// </summary>
public partial class AwsGrafanaRoleAssociation(string name) : TerraformResource("aws_grafana_role_association", name)
{
    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public TerraformSet<string>? GroupIds
    {
        get => GetArgument<TerraformSet<string>>("group_ids");
        set => SetArgument("group_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The user_ids attribute.
    /// </summary>
    public TerraformSet<string>? UserIds
    {
        get => GetArgument<TerraformSet<string>>("user_ids");
        set => SetArgument("user_ids", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGrafanaRoleAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGrafanaRoleAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
