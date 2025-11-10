using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for context in .
/// Nesting mode: set
/// </summary>
public class AwsIamPrincipalPolicySimulationDataSourceContextBlock : ITerraformBlock
{
    /// <summary>
    /// The key name of the context entry, such as &amp;quot;aws:CurrentTime&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The type that the simulator should use to interpret the strings given in argument &amp;quot;values&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// One or more values to assign to the context key, given as a string in a syntax appropriate for the selected value type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_iam_principal_policy_simulation.
/// </summary>
public class AwsIamPrincipalPolicySimulationDataSource : TerraformDataSource
{
    public AwsIamPrincipalPolicySimulationDataSource(string name) : base("aws_iam_principal_policy_simulation", name)
    {
    }

    /// <summary>
    /// One or more names of actions, like &amp;quot;iam:CreateUser&amp;quot;, that should be included in the simulation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionNames is required")]
    [TerraformPropertyName("action_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ActionNames { get; set; }

    /// <summary>
    /// Additional principal-based policies to use in the simulation.
    /// </summary>
    [TerraformPropertyName("additional_policies_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AdditionalPoliciesJson { get; set; }

    /// <summary>
    /// ARN of a user to use as the caller of the simulated requests. If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN.
    /// </summary>
    [TerraformPropertyName("caller_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CallerArn { get; set; }

    /// <summary>
    /// Additional permission boundary policies to use in the simulation.
    /// </summary>
    [TerraformPropertyName("permissions_boundary_policies_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PermissionsBoundaryPoliciesJson { get; set; }

    /// <summary>
    /// ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySourceArn is required")]
    [TerraformPropertyName("policy_source_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PolicySourceArn { get; set; }

    /// <summary>
    /// ARNs of specific resources to use as the targets of the specified actions during simulation. If not specified, the simulator assumes &amp;quot;*&amp;quot; which represents general access across all resources.
    /// </summary>
    [TerraformPropertyName("resource_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ResourceArns { get; set; }

    /// <summary>
    /// Specifies the type of simulation to run. Some API operations need a particular resource handling option in order to produce a correct reesult.
    /// </summary>
    [TerraformPropertyName("resource_handling_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceHandlingOption { get; set; }

    /// <summary>
    /// An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID. Defaults to the account given as part of caller_arn.
    /// </summary>
    [TerraformPropertyName("resource_owner_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceOwnerAccountId { get; set; }

    /// <summary>
    /// A resource policy to associate with all of the target resources for simulation purposes. The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s).
    /// </summary>
    [TerraformPropertyName("resource_policy_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourcePolicyJson { get; set; }

    /// <summary>
    /// Block for context.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("context")]
    public TerraformSet<TerraformBlock<AwsIamPrincipalPolicySimulationDataSourceContextBlock>>? Context { get; set; } = new();

    /// <summary>
    /// A summary of the results attribute which is true if all of the results have decision &amp;quot;allowed&amp;quot;, and false otherwise.
    /// </summary>
    [TerraformPropertyName("all_allowed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllAllowed => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "all_allowed");

    /// <summary>
    /// Do not use
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The results attribute.
    /// </summary>
    [TerraformPropertyName("results")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Results => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "results");

}
