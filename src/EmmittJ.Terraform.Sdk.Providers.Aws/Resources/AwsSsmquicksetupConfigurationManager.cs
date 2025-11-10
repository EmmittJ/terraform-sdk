using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The local_deployment_administration_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LocalDeploymentAdministrationRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("local_deployment_administration_role_arn");
        set => WithProperty("local_deployment_administration_role_arn", value);
    }

    /// <summary>
    /// The local_deployment_execution_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? LocalDeploymentExecutionRoleName
    {
        get => GetProperty<TerraformProperty<string>>("local_deployment_execution_role_name");
        set => WithProperty("local_deployment_execution_role_name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The type_version attribute.
    /// </summary>
    public TerraformProperty<string>? TypeVersion
    {
        get => GetProperty<TerraformProperty<string>>("type_version");
        set => WithProperty("type_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsmquicksetupConfigurationManagerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ssmquicksetup_configuration_manager resource.
/// </summary>
public class AwsSsmquicksetupConfigurationManager : TerraformResource
{
    public AwsSsmquicksetupConfigurationManager(string name) : base("aws_ssmquicksetup_configuration_manager", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("manager_arn");
        this.DeclareOutput("status_summaries");
        this.DeclareOutput("tags_all");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for configuration_definition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock>? ConfigurationDefinition
    {
        get => GetProperty<List<AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock>>("configuration_definition");
        set => this.WithProperty("configuration_definition", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSsmquicksetupConfigurationManagerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSsmquicksetupConfigurationManagerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The manager_arn attribute.
    /// </summary>
    public TerraformExpression ManagerArn => this["manager_arn"];

    /// <summary>
    /// The status_summaries attribute.
    /// </summary>
    public TerraformExpression StatusSummaries => this["status_summaries"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
