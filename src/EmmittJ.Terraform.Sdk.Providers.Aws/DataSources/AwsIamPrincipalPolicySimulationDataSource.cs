using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformLiteralProperty<HashSet<string>>? ActionNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("action_names");
        set => this.WithProperty("action_names", value);
    }

    /// <summary>
    /// Additional principal-based policies to use in the simulation.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AdditionalPoliciesJson
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_policies_json");
        set => this.WithProperty("additional_policies_json", value);
    }

    /// <summary>
    /// ARN of a user to use as the caller of the simulated requests. If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN.
    /// </summary>
    public TerraformLiteralProperty<string>? CallerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("caller_arn");
        set => this.WithProperty("caller_arn", value);
    }

    /// <summary>
    /// Additional permission boundary policies to use in the simulation.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PermissionsBoundaryPoliciesJson
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permissions_boundary_policies_json");
        set => this.WithProperty("permissions_boundary_policies_json", value);
    }

    /// <summary>
    /// ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicySourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_source_arn");
        set => this.WithProperty("policy_source_arn", value);
    }

    /// <summary>
    /// ARNs of specific resources to use as the targets of the specified actions during simulation. If not specified, the simulator assumes &amp;quot;*&amp;quot; which represents general access across all resources.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ResourceArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_arns");
        set => this.WithProperty("resource_arns", value);
    }

    /// <summary>
    /// Specifies the type of simulation to run. Some API operations need a particular resource handling option in order to produce a correct reesult.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceHandlingOption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_handling_option");
        set => this.WithProperty("resource_handling_option", value);
    }

    /// <summary>
    /// An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID. Defaults to the account given as part of caller_arn.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceOwnerAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_owner_account_id");
        set => this.WithProperty("resource_owner_account_id", value);
    }

    /// <summary>
    /// A resource policy to associate with all of the target resources for simulation purposes. The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s).
    /// </summary>
    public TerraformLiteralProperty<string>? ResourcePolicyJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_policy_json");
        set => this.WithProperty("resource_policy_json", value);
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
