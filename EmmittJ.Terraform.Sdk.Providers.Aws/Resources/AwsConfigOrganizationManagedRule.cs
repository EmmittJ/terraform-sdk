using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_organization_managed_rule resource.
/// </summary>
public class AwsConfigOrganizationManagedRule : TerraformResource
{
    public AwsConfigOrganizationManagedRule(string name) : base("aws_config_organization_managed_rule", name)
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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public HashSet<string>? ExcludedAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("excluded_accounts")?.Value;
        set => this.WithProperty("excluded_accounts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    public string? InputParameters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input_parameters")?.Value;
        set => this.WithProperty("input_parameters", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public string? MaximumExecutionFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maximum_execution_frequency")?.Value;
        set => this.WithProperty("maximum_execution_frequency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_id_scope attribute.
    /// </summary>
    public string? ResourceIdScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id_scope")?.Value;
        set => this.WithProperty("resource_id_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    public HashSet<string>? ResourceTypesScope
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_types_scope")?.Value;
        set => this.WithProperty("resource_types_scope", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The rule_identifier attribute.
    /// </summary>
    public string? RuleIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_identifier")?.Value;
        set => this.WithProperty("rule_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    public string? TagKeyScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_key_scope")?.Value;
        set => this.WithProperty("tag_key_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    public string? TagValueScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_value_scope")?.Value;
        set => this.WithProperty("tag_value_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
