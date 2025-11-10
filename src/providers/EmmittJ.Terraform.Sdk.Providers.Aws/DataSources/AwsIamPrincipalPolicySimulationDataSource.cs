using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for context in .
/// Nesting mode: set
/// </summary>
public class AwsIamPrincipalPolicySimulationDataSourceContextBlock : TerraformBlock
{
    /// <summary>
    /// The key name of the context entry, such as &amp;quot;aws:CurrentTime&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The type that the simulator should use to interpret the strings given in argument &amp;quot;values&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// One or more values to assign to the context key, given as a string in a syntax appropriate for the selected value type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_iam_principal_policy_simulation.
/// </summary>
public class AwsIamPrincipalPolicySimulationDataSource : TerraformDataSource
{
    public AwsIamPrincipalPolicySimulationDataSource(string name) : base("aws_iam_principal_policy_simulation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("all_allowed");
        this.DeclareOutput("id");
        this.DeclareOutput("results");
    }

    /// <summary>
    /// One or more names of actions, like &amp;quot;iam:CreateUser&amp;quot;, that should be included in the simulation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionNames is required")]
    public HashSet<TerraformProperty<string>>? ActionNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("action_names");
        set => this.WithProperty("action_names", value);
    }

    /// <summary>
    /// Additional principal-based policies to use in the simulation.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AdditionalPoliciesJson
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("additional_policies_json");
        set => this.WithProperty("additional_policies_json", value);
    }

    /// <summary>
    /// ARN of a user to use as the caller of the simulated requests. If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN.
    /// </summary>
    public TerraformProperty<string>? CallerArn
    {
        get => GetProperty<TerraformProperty<string>>("caller_arn");
        set => this.WithProperty("caller_arn", value);
    }

    /// <summary>
    /// Additional permission boundary policies to use in the simulation.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PermissionsBoundaryPoliciesJson
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permissions_boundary_policies_json");
        set => this.WithProperty("permissions_boundary_policies_json", value);
    }

    /// <summary>
    /// ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySourceArn is required")]
    public required TerraformProperty<string> PolicySourceArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("policy_source_arn");
        set => this.WithProperty("policy_source_arn", value);
    }

    /// <summary>
    /// ARNs of specific resources to use as the targets of the specified actions during simulation. If not specified, the simulator assumes &amp;quot;*&amp;quot; which represents general access across all resources.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_arns");
        set => this.WithProperty("resource_arns", value);
    }

    /// <summary>
    /// Specifies the type of simulation to run. Some API operations need a particular resource handling option in order to produce a correct reesult.
    /// </summary>
    public TerraformProperty<string>? ResourceHandlingOption
    {
        get => GetProperty<TerraformProperty<string>>("resource_handling_option");
        set => this.WithProperty("resource_handling_option", value);
    }

    /// <summary>
    /// An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID. Defaults to the account given as part of caller_arn.
    /// </summary>
    public TerraformProperty<string>? ResourceOwnerAccountId
    {
        get => GetProperty<TerraformProperty<string>>("resource_owner_account_id");
        set => this.WithProperty("resource_owner_account_id", value);
    }

    /// <summary>
    /// A resource policy to associate with all of the target resources for simulation purposes. The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s).
    /// </summary>
    public TerraformProperty<string>? ResourcePolicyJson
    {
        get => GetProperty<TerraformProperty<string>>("resource_policy_json");
        set => this.WithProperty("resource_policy_json", value);
    }

    /// <summary>
    /// Block for context.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIamPrincipalPolicySimulationDataSourceContextBlock>? Context
    {
        get => GetProperty<HashSet<AwsIamPrincipalPolicySimulationDataSourceContextBlock>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// A summary of the results attribute which is true if all of the results have decision &amp;quot;allowed&amp;quot;, and false otherwise.
    /// </summary>
    public TerraformExpression AllAllowed => this["all_allowed"];

    /// <summary>
    /// Do not use
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The results attribute.
    /// </summary>
    public TerraformExpression Results => this["results"];

}
