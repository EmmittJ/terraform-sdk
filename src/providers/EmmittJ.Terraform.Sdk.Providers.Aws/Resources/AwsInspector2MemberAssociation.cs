using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsInspector2MemberAssociation.
/// Nesting mode: single
/// </summary>
public class AwsInspector2MemberAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_inspector2_member_association Terraform resource.
/// Manages a aws_inspector2_member_association resource.
/// </summary>
public partial class AwsInspector2MemberAssociation(string name) : TerraformResource("aws_inspector2_member_association", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
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
    /// The delegated_admin_account_id attribute.
    /// </summary>
    public TerraformValue<string> DelegatedAdminAccountId
        => AsReference("delegated_admin_account_id");

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    public TerraformValue<string> RelationshipStatus
        => AsReference("relationship_status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsInspector2MemberAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsInspector2MemberAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
