using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsInspector2DelegatedAdminAccount.
/// Nesting mode: single
/// </summary>
public class AwsInspector2DelegatedAdminAccountTimeoutsBlock : TerraformBlock
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
/// Represents a aws_inspector2_delegated_admin_account Terraform resource.
/// Manages a aws_inspector2_delegated_admin_account resource.
/// </summary>
public partial class AwsInspector2DelegatedAdminAccount(string name) : TerraformResource("aws_inspector2_delegated_admin_account", name)
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
    /// The relationship_status attribute.
    /// </summary>
    public TerraformValue<string> RelationshipStatus
        => AsReference("relationship_status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsInspector2DelegatedAdminAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsInspector2DelegatedAdminAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
