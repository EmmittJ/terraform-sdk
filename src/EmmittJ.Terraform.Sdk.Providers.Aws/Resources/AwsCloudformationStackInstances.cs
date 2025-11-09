using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudformation_stack_instances resource.
/// </summary>
public class AwsCloudformationStackInstances : TerraformResource
{
    public AwsCloudformationStackInstances(string name) : base("aws_cloudformation_stack_instances", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("stack_instance_summaries");
        this.DeclareOutput("stack_set_id");
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Accounts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("accounts");
        set => this.WithProperty("accounts", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformProperty<string>? CallAs
    {
        get => GetProperty<TerraformProperty<string>>("call_as");
        set => this.WithProperty("call_as", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The parameter_overrides attribute.
    /// </summary>
    public TerraformMapProperty<string>? ParameterOverrides
    {
        get => GetProperty<TerraformMapProperty<string>>("parameter_overrides");
        set => this.WithProperty("parameter_overrides", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Regions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The retain_stacks attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainStacks
    {
        get => GetProperty<TerraformProperty<bool>>("retain_stacks");
        set => this.WithProperty("retain_stacks", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformProperty<string>? StackSetName
    {
        get => GetProperty<TerraformProperty<string>>("stack_set_name");
        set => this.WithProperty("stack_set_name", value);
    }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformExpression StackInstanceSummaries => this["stack_instance_summaries"];

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformExpression StackSetId => this["stack_set_id"];

}
