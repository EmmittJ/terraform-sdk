using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for context in AwsIamPrincipalPolicySimulationDataSource.
/// Nesting mode: set
/// </summary>
public class AwsIamPrincipalPolicySimulationDataSourceContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// The key name of the context entry, such as &amp;quot;aws:CurrentTime&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type that the simulator should use to interpret the strings given in argument &amp;quot;values&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// One or more values to assign to the context key, given as a string in a syntax appropriate for the selected value type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_iam_principal_policy_simulation Terraform data source.
/// Retrieves information about a aws_iam_principal_policy_simulation.
/// </summary>
public partial class AwsIamPrincipalPolicySimulationDataSource(string name) : TerraformDataSource("aws_iam_principal_policy_simulation", name)
{
    /// <summary>
    /// One or more names of actions, like &amp;quot;iam:CreateUser&amp;quot;, that should be included in the simulation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionNames is required")]
    public required TerraformSet<string> ActionNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "action_names").ResolveNodes(ctx));
        set => SetArgument("action_names", value);
    }

    /// <summary>
    /// Additional principal-based policies to use in the simulation.
    /// </summary>
    public TerraformSet<string>? AdditionalPoliciesJson
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_policies_json").ResolveNodes(ctx));
        set => SetArgument("additional_policies_json", value);
    }

    /// <summary>
    /// ARN of a user to use as the caller of the simulated requests. If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN.
    /// </summary>
    public TerraformValue<string>? CallerArn
    {
        get => new TerraformReference<string>(this, "caller_arn");
        set => SetArgument("caller_arn", value);
    }

    /// <summary>
    /// Additional permission boundary policies to use in the simulation.
    /// </summary>
    public TerraformSet<string>? PermissionsBoundaryPoliciesJson
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "permissions_boundary_policies_json").ResolveNodes(ctx));
        set => SetArgument("permissions_boundary_policies_json", value);
    }

    /// <summary>
    /// ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySourceArn is required")]
    public required TerraformValue<string> PolicySourceArn
    {
        get => new TerraformReference<string>(this, "policy_source_arn");
        set => SetArgument("policy_source_arn", value);
    }

    /// <summary>
    /// ARNs of specific resources to use as the targets of the specified actions during simulation. If not specified, the simulator assumes &amp;quot;*&amp;quot; which represents general access across all resources.
    /// </summary>
    public TerraformSet<string>? ResourceArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resource_arns").ResolveNodes(ctx));
        set => SetArgument("resource_arns", value);
    }

    /// <summary>
    /// Specifies the type of simulation to run. Some API operations need a particular resource handling option in order to produce a correct reesult.
    /// </summary>
    public TerraformValue<string>? ResourceHandlingOption
    {
        get => new TerraformReference<string>(this, "resource_handling_option");
        set => SetArgument("resource_handling_option", value);
    }

    /// <summary>
    /// An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID. Defaults to the account given as part of caller_arn.
    /// </summary>
    public TerraformValue<string>? ResourceOwnerAccountId
    {
        get => new TerraformReference<string>(this, "resource_owner_account_id");
        set => SetArgument("resource_owner_account_id", value);
    }

    /// <summary>
    /// A resource policy to associate with all of the target resources for simulation purposes. The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s).
    /// </summary>
    public TerraformValue<string>? ResourcePolicyJson
    {
        get => new TerraformReference<string>(this, "resource_policy_json");
        set => SetArgument("resource_policy_json", value);
    }

    /// <summary>
    /// A summary of the results attribute which is true if all of the results have decision &amp;quot;allowed&amp;quot;, and false otherwise.
    /// </summary>
    public TerraformValue<bool> AllAllowed
    {
        get => new TerraformReference<bool>(this, "all_allowed");
    }

    /// <summary>
    /// Do not use
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The results attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Results
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "results").ResolveNodes(ctx));
    }

    /// <summary>
    /// Context block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIamPrincipalPolicySimulationDataSourceContextBlock>? Context
    {
        get => GetArgument<TerraformSet<AwsIamPrincipalPolicySimulationDataSourceContextBlock>>("context");
        set => SetArgument("context", value);
    }

}
