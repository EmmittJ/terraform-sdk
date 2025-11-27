using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsConfigOrganizationCustomPolicyRule.
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationCustomPolicyRuleTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_config_organization_custom_policy_rule Terraform resource.
/// Manages a aws_config_organization_custom_policy_rule resource.
/// </summary>
public partial class AwsConfigOrganizationCustomPolicyRule(string name) : TerraformResource("aws_config_organization_custom_policy_rule", name)
{
    /// <summary>
    /// The debug_log_delivery_accounts attribute.
    /// </summary>
    public TerraformSet<string>? DebugLogDeliveryAccounts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "debug_log_delivery_accounts").ResolveNodes(ctx));
        set => SetArgument("debug_log_delivery_accounts", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedAccounts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_accounts").ResolveNodes(ctx));
        set => SetArgument("excluded_accounts", value);
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
    /// The input_parameters attribute.
    /// </summary>
    public TerraformValue<string>? InputParameters
    {
        get => new TerraformReference<string>(this, "input_parameters");
        set => SetArgument("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformValue<string>? MaximumExecutionFrequency
    {
        get => new TerraformReference<string>(this, "maximum_execution_frequency");
        set => SetArgument("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyRuntime is required")]
    public required TerraformValue<string> PolicyRuntime
    {
        get => new TerraformReference<string>(this, "policy_runtime");
        set => SetArgument("policy_runtime", value);
    }

    /// <summary>
    /// The policy_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyText is required")]
    public required TerraformValue<string> PolicyText
    {
        get => new TerraformReference<string>(this, "policy_text");
        set => SetArgument("policy_text", value);
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
    /// The resource_id_scope attribute.
    /// </summary>
    public TerraformValue<string>? ResourceIdScope
    {
        get => new TerraformReference<string>(this, "resource_id_scope");
        set => SetArgument("resource_id_scope", value);
    }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    public TerraformSet<string>? ResourceTypesScope
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resource_types_scope").ResolveNodes(ctx));
        set => SetArgument("resource_types_scope", value);
    }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    public TerraformValue<string>? TagKeyScope
    {
        get => new TerraformReference<string>(this, "tag_key_scope");
        set => SetArgument("tag_key_scope", value);
    }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    public TerraformValue<string>? TagValueScope
    {
        get => new TerraformReference<string>(this, "tag_value_scope");
        set => SetArgument("tag_value_scope", value);
    }

    /// <summary>
    /// The trigger_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTypes is required")]
    public required TerraformSet<string> TriggerTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "trigger_types").ResolveNodes(ctx));
        set => SetArgument("trigger_types", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsConfigOrganizationCustomPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsConfigOrganizationCustomPolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
