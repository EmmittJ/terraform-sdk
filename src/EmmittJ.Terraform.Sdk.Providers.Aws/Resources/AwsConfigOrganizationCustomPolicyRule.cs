using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_organization_custom_policy_rule resource.
/// </summary>
public class AwsConfigOrganizationCustomPolicyRule : TerraformResource
{
    public AwsConfigOrganizationCustomPolicyRule(string name) : base("aws_config_organization_custom_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The debug_log_delivery_accounts attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DebugLogDeliveryAccounts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("debug_log_delivery_accounts");
        set => this.WithProperty("debug_log_delivery_accounts", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ExcludedAccounts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("excluded_accounts");
        set => this.WithProperty("excluded_accounts", value);
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
    /// The input_parameters attribute.
    /// </summary>
    public TerraformProperty<string>? InputParameters
    {
        get => GetProperty<TerraformProperty<string>>("input_parameters");
        set => this.WithProperty("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? MaximumExecutionFrequency
    {
        get => GetProperty<TerraformProperty<string>>("maximum_execution_frequency");
        set => this.WithProperty("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_runtime attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyRuntime
    {
        get => GetProperty<TerraformProperty<string>>("policy_runtime");
        set => this.WithProperty("policy_runtime", value);
    }

    /// <summary>
    /// The policy_text attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyText
    {
        get => GetProperty<TerraformProperty<string>>("policy_text");
        set => this.WithProperty("policy_text", value);
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
    /// The resource_id_scope attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdScope
    {
        get => GetProperty<TerraformProperty<string>>("resource_id_scope");
        set => this.WithProperty("resource_id_scope", value);
    }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ResourceTypesScope
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_types_scope");
        set => this.WithProperty("resource_types_scope", value);
    }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    public TerraformProperty<string>? TagKeyScope
    {
        get => GetProperty<TerraformProperty<string>>("tag_key_scope");
        set => this.WithProperty("tag_key_scope", value);
    }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    public TerraformProperty<string>? TagValueScope
    {
        get => GetProperty<TerraformProperty<string>>("tag_value_scope");
        set => this.WithProperty("tag_value_scope", value);
    }

    /// <summary>
    /// The trigger_types attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TriggerTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("trigger_types");
        set => this.WithProperty("trigger_types", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
