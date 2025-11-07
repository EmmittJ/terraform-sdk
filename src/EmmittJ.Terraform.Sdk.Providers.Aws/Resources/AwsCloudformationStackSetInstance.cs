using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudformation_stack_set_instance resource.
/// </summary>
public class AwsCloudformationStackSetInstance : TerraformResource
{
    public AwsCloudformationStackSetInstance(string name) : base("aws_cloudformation_stack_set_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("organizational_unit_id");
        this.DeclareOutput("stack_id");
        this.DeclareOutput("stack_instance_summaries");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    public TerraformProperty<Dictionary<string, string>>? ParameterOverrides
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("parameter_overrides");
        set => this.WithProperty("parameter_overrides", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retain_stack attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainStack
    {
        get => GetProperty<TerraformProperty<bool>>("retain_stack");
        set => this.WithProperty("retain_stack", value);
    }

    /// <summary>
    /// The stack_set_instance_region attribute.
    /// </summary>
    public TerraformProperty<string>? StackSetInstanceRegion
    {
        get => GetProperty<TerraformProperty<string>>("stack_set_instance_region");
        set => this.WithProperty("stack_set_instance_region", value);
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
    /// The organizational_unit_id attribute.
    /// </summary>
    public TerraformExpression OrganizationalUnitId => this["organizational_unit_id"];

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public TerraformExpression StackId => this["stack_id"];

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformExpression StackInstanceSummaries => this["stack_instance_summaries"];

}
