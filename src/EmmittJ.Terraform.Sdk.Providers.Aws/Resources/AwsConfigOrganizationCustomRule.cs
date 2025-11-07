using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_organization_custom_rule resource.
/// </summary>
public class AwsConfigOrganizationCustomRule : TerraformResource
{
    public AwsConfigOrganizationCustomRule(string name) : base("aws_config_organization_custom_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ExcludedAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("excluded_accounts");
        set => this.WithProperty("excluded_accounts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InputParameters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input_parameters");
        set => this.WithProperty("input_parameters", value);
    }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LambdaFunctionArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lambda_function_arn");
        set => this.WithProperty("lambda_function_arn", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaximumExecutionFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maximum_execution_frequency");
        set => this.WithProperty("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_id_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceIdScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id_scope");
        set => this.WithProperty("resource_id_scope", value);
    }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ResourceTypesScope
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_types_scope");
        set => this.WithProperty("resource_types_scope", value);
    }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TagKeyScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_key_scope");
        set => this.WithProperty("tag_key_scope", value);
    }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TagValueScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_value_scope");
        set => this.WithProperty("tag_value_scope", value);
    }

    /// <summary>
    /// The trigger_types attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? TriggerTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("trigger_types");
        set => this.WithProperty("trigger_types", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
