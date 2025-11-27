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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "group_ids").ResolveNodes(ctx));
        set => SetArgument("group_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The user_ids attribute.
    /// </summary>
    public TerraformSet<string>? UserIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "user_ids").ResolveNodes(ctx));
        set => SetArgument("user_ids", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
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
