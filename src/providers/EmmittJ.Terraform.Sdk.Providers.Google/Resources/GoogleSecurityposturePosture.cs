using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for policy_sets in GoogleSecurityposturePosture.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_sets";

    /// <summary>
    /// Description of the policy set.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// ID of the policy set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySetId is required")]
    public required TerraformValue<string> PolicySetId
    {
        get => new TerraformReference<string>(this, "policy_set_id");
        set => SetArgument("policy_set_id", value);
    }

    /// <summary>
    /// Policies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Policies block(s) required")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlock> Policies
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlock>>("policies");
        set => SetArgument("policies", value);
    }

}

/// <summary>
/// Block type for policies in GoogleSecurityposturePosturePolicySetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policies";

    /// <summary>
    /// Description of the policy.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// ID of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformValue<string> PolicyId
    {
        get => new TerraformReference<string>(this, "policy_id");
        set => SetArgument("policy_id", value);
    }

    /// <summary>
    /// ComplianceStandards block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockComplianceStandardsBlock>? ComplianceStandards
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockComplianceStandardsBlock>>("compliance_standards");
        set => SetArgument("compliance_standards", value);
    }

    /// <summary>
    /// Constraint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Constraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Constraint block(s) allowed")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock> Constraint
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock>>("constraint");
        set => SetArgument("constraint", value);
    }

}

/// <summary>
/// Block type for compliance_standards in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockComplianceStandardsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compliance_standards";

    /// <summary>
    /// Mapping of security controls for the policy.
    /// </summary>
    public TerraformValue<string>? Control
    {
        get => new TerraformReference<string>(this, "control");
        set => SetArgument("control", value);
    }

    /// <summary>
    /// Mapping of compliance standards for the policy.
    /// </summary>
    public TerraformValue<string>? Standard
    {
        get => new TerraformReference<string>(this, "standard");
        set => SetArgument("standard", value);
    }

}

/// <summary>
/// Block type for constraint in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "constraint";

    /// <summary>
    /// OrgPolicyConstraint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgPolicyConstraint block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlock>? OrgPolicyConstraint
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlock>>("org_policy_constraint");
        set => SetArgument("org_policy_constraint", value);
    }

    /// <summary>
    /// OrgPolicyConstraintCustom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgPolicyConstraintCustom block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlock>? OrgPolicyConstraintCustom
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlock>>("org_policy_constraint_custom");
        set => SetArgument("org_policy_constraint_custom", value);
    }

    /// <summary>
    /// SecurityHealthAnalyticsCustomModule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHealthAnalyticsCustomModule block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlock>? SecurityHealthAnalyticsCustomModule
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlock>>("security_health_analytics_custom_module");
        set => SetArgument("security_health_analytics_custom_module", value);
    }

    /// <summary>
    /// SecurityHealthAnalyticsModule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHealthAnalyticsModule block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsModuleBlock>? SecurityHealthAnalyticsModule
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsModuleBlock>>("security_health_analytics_module");
        set => SetArgument("security_health_analytics_module", value);
    }

}

/// <summary>
/// Block type for org_policy_constraint in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "org_policy_constraint";

    /// <summary>
    /// Organization policy canned constraint Id
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CannedConstraintId is required")]
    public required TerraformValue<string> CannedConstraintId
    {
        get => new TerraformReference<string>(this, "canned_constraint_id");
        set => SetArgument("canned_constraint_id", value);
    }

    /// <summary>
    /// PolicyRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyRules block(s) required")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlock> PolicyRules
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlock>>("policy_rules");
        set => SetArgument("policy_rules", value);
    }

}

/// <summary>
/// Block type for policy_rules in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_rules";

    /// <summary>
    /// Setting this to true means that all values are allowed. This field can be set only in policies for list constraints.
    /// </summary>
    public TerraformValue<bool>? AllowAll
    {
        get => new TerraformReference<bool>(this, "allow_all");
        set => SetArgument("allow_all", value);
    }

    /// <summary>
    /// Setting this to true means that all values are denied. This field can be set only in policies for list constraints.
    /// </summary>
    public TerraformValue<bool>? DenyAll
    {
        get => new TerraformReference<bool>(this, "deny_all");
        set => SetArgument("deny_all", value);
    }

    /// <summary>
    /// If &#39;true&#39;, then the policy is enforced. If &#39;false&#39;, then any configuration is acceptable.
    /// This field can be set only in policies for boolean constraints.
    /// </summary>
    public TerraformValue<bool>? Enforce
    {
        get => new TerraformReference<bool>(this, "enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// ValuesAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValuesAttribute block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlockValuesAttributeBlock>? ValuesAttribute
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlockValuesAttributeBlock>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for condition in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for values in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintBlockPolicyRulesBlockValuesAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "values";

    /// <summary>
    /// List of values allowed at this resource.
    /// </summary>
    public TerraformList<string>? AllowedValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_values").ResolveNodes(ctx));
        set => SetArgument("allowed_values", value);
    }

    /// <summary>
    /// List of values denied at this resource.
    /// </summary>
    public TerraformList<string>? DeniedValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "denied_values").ResolveNodes(ctx));
        set => SetArgument("denied_values", value);
    }

}

/// <summary>
/// Block type for org_policy_constraint_custom in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "org_policy_constraint_custom";

    /// <summary>
    /// CustomConstraint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomConstraint block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockCustomConstraintBlock>? CustomConstraint
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockCustomConstraintBlock>>("custom_constraint");
        set => SetArgument("custom_constraint", value);
    }

    /// <summary>
    /// PolicyRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyRules block(s) required")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlock> PolicyRules
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlock>>("policy_rules");
        set => SetArgument("policy_rules", value);
    }

}

/// <summary>
/// Block type for custom_constraint in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockCustomConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_constraint";

    /// <summary>
    /// The action to take if the condition is met. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformValue<string> ActionType
    {
        get => new TerraformReference<string>(this, "action_type");
        set => SetArgument("action_type", value);
    }

    /// <summary>
    /// A CEL condition that refers to a supported service resource, for example &#39;resource.management.autoUpgrade == false&#39;. For details about CEL usage, see [Common Expression Language](https://cloud.google.com/resource-manager/docs/organization-policy/creating-managing-custom-constraints#common_expression_language).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    public required TerraformValue<string> Condition
    {
        get => new TerraformReference<string>(this, "condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// A human-friendly description of the constraint to display as an error message when the policy is violated.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A human-friendly name for the constraint.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// A list of RESTful methods for which to enforce the constraint. Can be &#39;CREATE&#39;, &#39;UPDATE&#39;, or both. Not all Google Cloud services support both methods. To see supported methods for each service, find the service in [Supported services](https://cloud.google.com/resource-manager/docs/organization-policy/custom-constraint-supported-services).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodTypes is required")]
    public TerraformList<string>? MethodTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "method_types").ResolveNodes(ctx));
        set => SetArgument("method_types", value);
    }

    /// <summary>
    /// Immutable. The name of the custom constraint. This is unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Immutable. The fully qualified name of the Google Cloud REST resource containing the object and field you want to restrict. For example, &#39;container.googleapis.com/NodePool&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

}

/// <summary>
/// Block type for policy_rules in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_rules";

    /// <summary>
    /// Setting this to true means that all values are allowed. This field can be set only in policies for list constraints.
    /// </summary>
    public TerraformValue<bool>? AllowAll
    {
        get => new TerraformReference<bool>(this, "allow_all");
        set => SetArgument("allow_all", value);
    }

    /// <summary>
    /// Setting this to true means that all values are denied. This field can be set only in policies for list constraints.
    /// </summary>
    public TerraformValue<bool>? DenyAll
    {
        get => new TerraformReference<bool>(this, "deny_all");
        set => SetArgument("deny_all", value);
    }

    /// <summary>
    /// If &#39;true&#39;, then the policy is enforced. If &#39;false&#39;, then any configuration is acceptable.
    /// This field can be set only in policies for boolean constraints.
    /// </summary>
    public TerraformValue<bool>? Enforce
    {
        get => new TerraformReference<bool>(this, "enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// ValuesAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValuesAttribute block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlockValuesAttributeBlock>? ValuesAttribute
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlockValuesAttributeBlock>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for condition in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for values in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockOrgPolicyConstraintCustomBlockPolicyRulesBlockValuesAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "values";

    /// <summary>
    /// List of values allowed at this resource.
    /// </summary>
    public TerraformList<string>? AllowedValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_values").ResolveNodes(ctx));
        set => SetArgument("allowed_values", value);
    }

    /// <summary>
    /// List of values denied at this resource.
    /// </summary>
    public TerraformList<string>? DeniedValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "denied_values").ResolveNodes(ctx));
        set => SetArgument("denied_values", value);
    }

}

/// <summary>
/// Block type for security_health_analytics_custom_module in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_health_analytics_custom_module";

    /// <summary>
    /// The display name of the Security Health Analytics custom module. This
    /// display name becomes the finding category for all findings that are
    /// returned by this custom module.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// A server generated id of custom module.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The state of enablement for the module at its level of the resource hierarchy. Possible values: [&amp;quot;ENABLEMENT_STATE_UNSPECIFIED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ModuleEnablementState
    {
        get => new TerraformReference<string>(this, "module_enablement_state");
        set => SetArgument("module_enablement_state", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

}

/// <summary>
/// Block type for config in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// Text that describes the vulnerability or misconfiguration that the custom
    /// module detects.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// An explanation of the recommended steps that security teams can take to
    /// resolve the detected issue
    /// </summary>
    public TerraformValue<string>? Recommendation
    {
        get => new TerraformReference<string>(this, "recommendation");
        set => SetArgument("recommendation", value);
    }

    /// <summary>
    /// The severity to assign to findings generated by the module. Possible values: [&amp;quot;SEVERITY_UNSPECIFIED&amp;quot;, &amp;quot;CRITICAL&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LOW&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<string> Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// CustomOutput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomOutput block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlock>? CustomOutput
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlock>>("custom_output");
        set => SetArgument("custom_output", value);
    }

    /// <summary>
    /// Predicate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Predicate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Predicate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predicate block(s) allowed")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockPredicateBlock> Predicate
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockPredicateBlock>>("predicate");
        set => SetArgument("predicate", value);
    }

    /// <summary>
    /// ResourceSelector block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSelector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceSelector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSelector block(s) allowed")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockResourceSelectorBlock> ResourceSelector
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockResourceSelectorBlock>>("resource_selector");
        set => SetArgument("resource_selector", value);
    }

}

/// <summary>
/// Block type for custom_output in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_output";

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for properties in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// Name of the property for the custom output.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ValueExpression block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValueExpression block(s) allowed")]
    public TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlockValueExpressionBlock>? ValueExpression
    {
        get => GetArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlockValueExpressionBlock>>("value_expression");
        set => SetArgument("value_expression", value);
    }

}

/// <summary>
/// Block type for value_expression in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockCustomOutputBlockPropertiesBlockValueExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_expression";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for predicate in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockPredicateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predicate";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for resource_selector in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsCustomModuleBlockConfigBlockResourceSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_selector";

    /// <summary>
    /// The resource types to run the detector on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

}

/// <summary>
/// Block type for security_health_analytics_module in GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlockPoliciesBlockConstraintBlockSecurityHealthAnalyticsModuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_health_analytics_module";

    /// <summary>
    /// The state of enablement for the module at its level of the resource hierarchy. Possible values: [&amp;quot;ENABLEMENT_STATE_UNSPECIFIED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ModuleEnablementState
    {
        get => new TerraformReference<string>(this, "module_enablement_state");
        set => SetArgument("module_enablement_state", value);
    }

    /// <summary>
    /// The name of the module eg: BIGQUERY_TABLE_CMEK_DISABLED.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModuleName is required")]
    public required TerraformValue<string> ModuleName
    {
        get => new TerraformReference<string>(this, "module_name");
        set => SetArgument("module_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSecurityposturePosture.
/// Nesting mode: single
/// </summary>
public class GoogleSecurityposturePostureTimeoutsBlock : TerraformBlock
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
/// Represents a google_securityposture_posture Terraform resource.
/// Manages a google_securityposture_posture resource.
/// </summary>
public partial class GoogleSecurityposturePosture(string name) : TerraformResource("google_securityposture_posture", name)
{
    /// <summary>
    /// Description of the posture.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// Location of the resource, eg: global.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Id of the posture. It is an immutable field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureId is required")]
    public required TerraformValue<string> PostureId
    {
        get => new TerraformReference<string>(this, "posture_id");
        set => SetArgument("posture_id", value);
    }

    /// <summary>
    /// State of the posture. Update to state field should not be triggered along with
    /// with other field updates. Possible values: [&amp;quot;DEPRECATED&amp;quot;, &amp;quot;DRAFT&amp;quot;, &amp;quot;ACTIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// Time the Posture was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Name of the posture.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// If set, there are currently changes in flight to the posture.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// Revision_id of the posture.
    /// </summary>
    public TerraformValue<string> RevisionId
    {
        get => new TerraformReference<string>(this, "revision_id");
    }

    /// <summary>
    /// Time the Posture was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// PolicySets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicySets block(s) required")]
    public required TerraformList<GoogleSecurityposturePosturePolicySetsBlock> PolicySets
    {
        get => GetRequiredArgument<TerraformList<GoogleSecurityposturePosturePolicySetsBlock>>("policy_sets");
        set => SetArgument("policy_sets", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecurityposturePostureTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecurityposturePostureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
