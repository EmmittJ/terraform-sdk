using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSecurityhubConfigurationPolicyAssociation.
/// Nesting mode: single
/// </summary>
public class AwsSecurityhubConfigurationPolicyAssociationTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_securityhub_configuration_policy_association Terraform resource.
/// Manages a aws_securityhub_configuration_policy_association resource.
/// </summary>
public partial class AwsSecurityhubConfigurationPolicyAssociation(string name) : TerraformResource("aws_securityhub_configuration_policy_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The universally unique identifier (UUID) of the configuration policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformValue<string> PolicyId
    {
        get => GetArgument<TerraformValue<string>>("policy_id");
        set => SetArgument("policy_id", value);
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
    /// The identifier of the target account, organizational unit, or the root to associate with the specified configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformValue<string> TargetId
    {
        get => GetArgument<TerraformValue<string>>("target_id");
        set => SetArgument("target_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSecurityhubConfigurationPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSecurityhubConfigurationPolicyAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
