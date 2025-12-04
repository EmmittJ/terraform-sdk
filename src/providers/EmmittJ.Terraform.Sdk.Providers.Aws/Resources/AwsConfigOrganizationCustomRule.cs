using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsConfigOrganizationCustomRule.
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationCustomRuleTimeoutsBlock : TerraformBlock
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
/// Represents a aws_config_organization_custom_rule Terraform resource.
/// Manages a aws_config_organization_custom_rule resource.
/// </summary>
public partial class AwsConfigOrganizationCustomRule(string name) : TerraformResource("aws_config_organization_custom_rule", name)
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
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
    /// The lambda_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaFunctionArn is required")]
    public required TerraformValue<string> LambdaFunctionArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_function_arn");
        set => SetArgument("lambda_function_arn", value);
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
    /// The trigger_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTypes is required")]
    public required TerraformSet<string> TriggerTypes
    {
        get => GetArgument<TerraformSet<string>>("trigger_types");
        set => SetArgument("trigger_types", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsConfigOrganizationCustomRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsConfigOrganizationCustomRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
