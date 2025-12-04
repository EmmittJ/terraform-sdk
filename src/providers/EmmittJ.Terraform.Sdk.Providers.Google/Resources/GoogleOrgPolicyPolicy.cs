using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dry_run_spec in GoogleOrgPolicyPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicyDryRunSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dry_run_spec";

    /// <summary>
    /// An opaque tag indicating the current version of the policy, used for concurrency control. This field is ignored if used in a &#39;CreatePolicy&#39; request. When the policy&#39; is returned from either a &#39;GetPolicy&#39; or a &#39;ListPolicies&#39; request, this &#39;etag&#39; indicates the version of the current policy to use when executing a read-modify-write loop. When the policy is returned from a &#39;GetEffectivePolicy&#39; request, the &#39;etag&#39; will be unset.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Determines the inheritance behavior for this policy. If &#39;inherit_from_parent&#39; is true, policy rules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this policy becomes the new root for evaluation. This field can be set only for policies which configure list constraints.
    /// </summary>
    public TerraformValue<bool>? InheritFromParent
    {
        get => GetArgument<TerraformValue<bool>>("inherit_from_parent");
        set => SetArgument("inherit_from_parent", value);
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the &#39;constraint_default&#39; enforcement behavior of the specific constraint at this resource. This field can be set in policies for either list or boolean constraints. If set, &#39;rules&#39; must be empty and &#39;inherit_from_parent&#39; must be set to false.
    /// </summary>
    public TerraformValue<bool>? Reset
    {
        get => GetArgument<TerraformValue<bool>>("reset");
        set => SetArgument("reset", value);
    }

    /// <summary>
    /// Output only. The time stamp this was previously updated. This represents the last time a call to &#39;CreatePolicy&#39; or &#39;UpdatePolicy&#39; was made for that policy.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Rules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlock>? Rules
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for rules in GoogleOrgPolicyPolicyDryRunSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// Setting this to &#39;&amp;quot;TRUE&amp;quot;&#39; means that all values are allowed. This field can be set only in Policies for list constraints.
    /// </summary>
    public TerraformValue<string>? AllowAll
    {
        get => GetArgument<TerraformValue<string>>("allow_all");
        set => SetArgument("allow_all", value);
    }

    /// <summary>
    /// Setting this to &#39;&amp;quot;TRUE&amp;quot;&#39; means that all values are denied. This field can be set only in Policies for list constraints.
    /// </summary>
    public TerraformValue<string>? DenyAll
    {
        get => GetArgument<TerraformValue<string>>("deny_all");
        set => SetArgument("deny_all", value);
    }

    /// <summary>
    /// If &#39;&amp;quot;TRUE&amp;quot;&#39;, then the &#39;Policy&#39; is enforced. If &#39;&amp;quot;FALSE&amp;quot;&#39;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.
    /// </summary>
    public TerraformValue<string>? Enforce
    {
        get => GetArgument<TerraformValue<string>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { \&amp;quot;allowedLocations\&amp;quot; : [\&amp;quot;us-east1\&amp;quot;, \&amp;quot;us-west1\&amp;quot;], \&amp;quot;allowAll\&amp;quot; : true }
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// ValuesAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValuesAttribute block(s) allowed")]
    public TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlockValuesAttributeBlock>? ValuesAttribute
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlockValuesAttributeBlock>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for condition in GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for values in GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicyDryRunSpecBlockRulesBlockValuesAttributeBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_values");
        set => SetArgument("allowed_values", value);
    }

    /// <summary>
    /// List of values denied at this resource.
    /// </summary>
    public TerraformList<string>? DeniedValues
    {
        get => GetArgument<TerraformList<string>>("denied_values");
        set => SetArgument("denied_values", value);
    }

}


/// <summary>
/// Block type for spec in GoogleOrgPolicyPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicySpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// An opaque tag indicating the current version of the &#39;Policy&#39;, used for concurrency control. This field is ignored if used in a &#39;CreatePolicy&#39; request. When the &#39;Policy&#39; is returned from either a &#39;GetPolicy&#39; or a &#39;ListPolicies&#39; request, this &#39;etag&#39; indicates the version of the current &#39;Policy&#39; to use when executing a read-modify-write loop. When the &#39;Policy&#39; is returned from a &#39;GetEffectivePolicy&#39; request, the &#39;etag&#39; will be unset.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Determines the inheritance behavior for this &#39;Policy&#39;. If &#39;inherit_from_parent&#39; is true, PolicyRules set higher up in the hierarchy (up to the closest root) are inherited and present in the effective policy. If it is false, then no rules are inherited, and this Policy becomes the new root for evaluation. This field can be set only for Policies which configure list constraints.
    /// </summary>
    public TerraformValue<bool>? InheritFromParent
    {
        get => GetArgument<TerraformValue<bool>>("inherit_from_parent");
        set => SetArgument("inherit_from_parent", value);
    }

    /// <summary>
    /// Ignores policies set above this resource and restores the &#39;constraint_default&#39; enforcement behavior of the specific &#39;Constraint&#39; at this resource. This field can be set in policies for either list or boolean constraints. If set, &#39;rules&#39; must be empty and &#39;inherit_from_parent&#39; must be set to false.
    /// </summary>
    public TerraformValue<bool>? Reset
    {
        get => GetArgument<TerraformValue<bool>>("reset");
        set => SetArgument("reset", value);
    }

    /// <summary>
    /// Output only. The time stamp this was previously updated. This represents the last time a call to &#39;CreatePolicy&#39; or &#39;UpdatePolicy&#39; was made for that &#39;Policy&#39;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Rules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOrgPolicyPolicySpecBlockRulesBlock>? Rules
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicySpecBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for rules in GoogleOrgPolicyPolicySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicySpecBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// Setting this to &#39;&amp;quot;TRUE&amp;quot;&#39; means that all values are allowed. This field can be set only in Policies for list constraints.
    /// </summary>
    public TerraformValue<string>? AllowAll
    {
        get => GetArgument<TerraformValue<string>>("allow_all");
        set => SetArgument("allow_all", value);
    }

    /// <summary>
    /// Setting this to &#39;&amp;quot;TRUE&amp;quot;&#39; means that all values are denied. This field can be set only in Policies for list constraints.
    /// </summary>
    public TerraformValue<string>? DenyAll
    {
        get => GetArgument<TerraformValue<string>>("deny_all");
        set => SetArgument("deny_all", value);
    }

    /// <summary>
    /// If &#39;&amp;quot;TRUE&amp;quot;&#39;, then the &#39;Policy&#39; is enforced. If &#39;&amp;quot;FALSE&amp;quot;&#39;, then any configuration is acceptable. This field can be set only in Policies for boolean constraints.
    /// </summary>
    public TerraformValue<string>? Enforce
    {
        get => GetArgument<TerraformValue<string>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Optional. Required for Managed Constraints if parameters defined in constraints. Pass parameter values when policy enforcement is enabled. Ensure that parameter value types match those defined in the constraint definition. For example: { \&amp;quot;allowedLocations\&amp;quot; : [\&amp;quot;us-east1\&amp;quot;, \&amp;quot;us-west1\&amp;quot;], \&amp;quot;allowAll\&amp;quot; : true }
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleOrgPolicyPolicySpecBlockRulesBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicySpecBlockRulesBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// ValuesAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValuesAttribute block(s) allowed")]
    public TerraformList<GoogleOrgPolicyPolicySpecBlockRulesBlockValuesAttributeBlock>? ValuesAttribute
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicySpecBlockRulesBlockValuesAttributeBlock>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for condition in GoogleOrgPolicyPolicySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicySpecBlockRulesBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for values in GoogleOrgPolicyPolicySpecBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOrgPolicyPolicySpecBlockRulesBlockValuesAttributeBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_values");
        set => SetArgument("allowed_values", value);
    }

    /// <summary>
    /// List of values denied at this resource.
    /// </summary>
    public TerraformList<string>? DeniedValues
    {
        get => GetArgument<TerraformList<string>>("denied_values");
        set => SetArgument("denied_values", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOrgPolicyPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleOrgPolicyPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_org_policy_policy Terraform resource.
/// Manages a google_org_policy_policy resource.
/// </summary>
public partial class GoogleOrgPolicyPolicy(string name) : TerraformResource("google_org_policy_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * &#39;projects/{project_number}/policies/{constraint_name}&#39; * &#39;folders/{folder_id}/policies/{constraint_name}&#39; * &#39;organizations/{organization_id}/policies/{constraint_name}&#39; For example, &amp;quot;projects/123/policies/compute.disableSerialPortAccess&amp;quot;. Note: &#39;projects/{project_id}/policies/{constraint_name}&#39; is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This &#39;etag&#39; is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// DryRunSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DryRunSpec block(s) allowed")]
    public TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlock>? DryRunSpec
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicyDryRunSpecBlock>>("dry_run_spec");
        set => SetArgument("dry_run_spec", value);
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<GoogleOrgPolicyPolicySpecBlock>? Spec
    {
        get => GetArgument<TerraformList<GoogleOrgPolicyPolicySpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOrgPolicyPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOrgPolicyPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
