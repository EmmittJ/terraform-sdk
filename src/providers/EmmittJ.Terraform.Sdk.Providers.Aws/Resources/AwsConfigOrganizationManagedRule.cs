using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsConfigOrganizationManagedRule.
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationManagedRuleTimeoutsBlock : TerraformBlock
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
/// Represents a aws_config_organization_managed_rule Terraform resource.
/// Manages a aws_config_organization_managed_rule resource.
/// </summary>
public partial class AwsConfigOrganizationManagedRule(string name) : TerraformResource("aws_config_organization_managed_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedAccounts
    {
        get => GetArgument<TerraformSet<string>>("excluded_accounts");
        set => SetArgument("excluded_accounts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    public TerraformValue<string>? InputParameters
    {
        get => GetArgument<TerraformValue<string>>("input_parameters");
        set => SetArgument("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformValue<string>? MaximumExecutionFrequency
    {
        get => GetArgument<TerraformValue<string>>("maximum_execution_frequency");
        set => SetArgument("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The resource_id_scope attribute.
    /// </summary>
    public TerraformValue<string>? ResourceIdScope
    {
        get => GetArgument<TerraformValue<string>>("resource_id_scope");
        set => SetArgument("resource_id_scope", value);
    }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    public TerraformSet<string>? ResourceTypesScope
    {
        get => GetArgument<TerraformSet<string>>("resource_types_scope");
        set => SetArgument("resource_types_scope", value);
    }

    /// <summary>
    /// The rule_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIdentifier is required")]
    public required TerraformValue<string> RuleIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_identifier");
        set => SetArgument("rule_identifier", value);
    }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    public TerraformValue<string>? TagKeyScope
    {
        get => GetArgument<TerraformValue<string>>("tag_key_scope");
        set => SetArgument("tag_key_scope", value);
    }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    public TerraformValue<string>? TagValueScope
    {
        get => GetArgument<TerraformValue<string>>("tag_value_scope");
        set => SetArgument("tag_value_scope", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsConfigOrganizationManagedRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsConfigOrganizationManagedRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
